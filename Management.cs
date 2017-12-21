using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Diagnostics;

namespace GitManager
{
    public partial class Management : Form
    {
        private GitConfigs.GitInformation settingsXml = new GitConfigs.GitInformation();
        private string settingFileName = ConfigurationManager.AppSettings["DataXml"].ToString();
        private string settingOutputFolder = ConfigurationManager.AppSettings["OutputFolder"].ToString();
        private BindingSource bProjectSource = new BindingSource();
        private BindingSource bRepositorySource = new BindingSource();
        private BindingSource bBranchSource = new BindingSource();

        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingFileName))
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(GitConfigs.GitInformation));
                using (StreamReader reader = new StreamReader(settingFileName))
                {
                    settingsXml = (GitConfigs.GitInformation)xsSubmit.Deserialize(reader);
                }
            }

            bProjectSource.DataSource = settingsXml.ProjectList;

            dgvProjects.DataSource = bProjectSource;
            dgvProjects.ClearSelection();

            bBranchSource.DataSource = getBranches();

            dgvBranches.DataSource = bBranchSource;
            dgvBranches.ClearSelection();

            pnlRepositories.Enabled = false;
            btnBuildBashFile.Enabled = false;
            btnViewBashFile.Enabled = false;

            enableDisableBranches(null);

            resetBranchAppliesTo();

            rdBranchAppliesToAllRepositoriesInCurrentProject.Enabled = false;
            rdBranchAppliesToSpecificRepositories.Enabled = false;

            cbBranchMergeFromBranch.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void enableDisableBranches(GitConfigs.Project currentproject)
        {
            pnlBranches.Enabled = settingsXml.ProjectList.Count > 0 && (from project in settingsXml.ProjectList
                                                                        where project.RepositoryList.Count > 0
                                                                        select project.EntityGuid).ToList<string>().Count > 0;

            if (pnlBranches.Enabled)
            {
                loadBranchMergeFromBranch_DataSet();
                if (currentproject != null)
                {
                    bool enableDisbale = currentproject.RepositoryList.Count > 0;
                    rdBranchAppliesToAllRepositoriesInCurrentProject.Enabled = enableDisbale;
                    rdBranchAppliesToSpecificRepositories.Enabled = enableDisbale;
                }
            }
        }

        private void saveSettings()
        {
            XmlSerializer serializer = new XmlSerializer(settingsXml.GetType());
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            using (StringWriter stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, writerSettings))
                {
                    serializer.Serialize(xmlWriter, settingsXml);
                }

                File.WriteAllText(settingFileName, stringWriter.ToString());
            }
        }

        private void btnProjectGuidGenerator_Click(object sender, EventArgs e)
        {
            txtProjectGuid.Text = Guid.NewGuid().ToString();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            GitConfigs.Project recordObj;
            bool newRecord = false;

            if (settingsXml.ProjectList.Count > 0 && txtProjectGuid.Text == String.Empty)
            {
                List<GitConfigs.Project> projectsFound = settingsXml.ProjectList.FindAll(x => x.EntityName == txtProjectName.Text  || x.OutputFileName == txtProjectOutputFileName.Text);
                if (projectsFound.Count > 1)
                {
                    MessageBox.Show("There are duplicate records with that Name and Output File Name");
                    return;
                }

                if (projectsFound.Count == 1)
                {
                    txtProjectGuid.Text = projectsFound[0].EntityGuid;
                }
            }

            if (settingsXml.ProjectList.Count == 0 || txtProjectGuid.Text == String.Empty)
            {
                newRecord = true;
                recordObj = new GitConfigs.Project();
            }
            else
            {
                recordObj = settingsXml.ProjectList.Find(x => x.EntityGuid == txtProjectGuid.Text);
                if (recordObj == null)
                {
                    newRecord = true;
                    recordObj = new GitConfigs.Project();
                }
            }

            recordObj.EntityName = txtProjectName.Text;
            recordObj.OutputFileName = txtProjectOutputFileName.Text;
            recordObj.Active = chkProjectActive.Checked;

            if (newRecord)
            {
                if (txtProjectGuid.Text == String.Empty)
                {
                    btnProjectGuidGenerator_Click(null, null);
                }

                recordObj.EntityGuid = txtProjectGuid.Text;
                settingsXml.ProjectList.Add(recordObj);
            }

            saveSettings();
            btnProjectClear_Click(null, null);
            bProjectSource.ResetBindings(true);
        }

        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                GitConfigs.Project project = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString());

                txtProjectGuid.Text = project.EntityGuid;
                txtProjectName.Text = project.EntityName;
                txtProjectOutputFileName.Text = project.OutputFileName;
                chkProjectActive.Checked = project.Active;

                txtProjectGuid.Enabled = false;
                pnlRepositories.Enabled = true;
                btnBuildBashFile.Enabled = true;
                btnViewBashFile.Enabled = true;

                bRepositorySource.DataSource = project.RepositoryList;

                if (dgvRepositories.DataSource == null)
                {
                    dgvRepositories.DataSource = bRepositorySource;
                }
                else
                {
                    bRepositorySource.ResetBindings(true);
                }
                
                chkRepositoryPerformPruneAtEnd.Checked = true;

                enableDisableBranches(project);
            }
        }

        private void dgvRepositories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRepositories.SelectedRows.Count > 0)
            {
                GitConfigs.Repository repository = getRepository();

                txtRepositoryGuid.Text = repository.EntityGuid;
                txtRepositoryName.Text = repository.EntityName;
                txtRepositoryFolderPath.Text = repository.FolderPath;
                chkRepositoryPerformPruneAtEnd.Checked = repository.PerformPruneAtEnd;
                chkRepositoryActive.Checked = repository.Active;
                
                txtRepositoryGuid.Enabled = false;

                bBranchSource.DataSource = getBranches();
                bBranchSource.ResetBindings(true);
                dgvBranches.ClearSelection();
                
                chklRepositoryBranches.ClearSelected();
                chklRepositoryBranches.Items.Clear();

                List<QuickBranchList> qBranchList = buildRepositoryBranchList(repository);

                if (qBranchList.Count > 0)
                {
                    chklRepositoryBranches.Visible = true;
                    chklRepositoryBranches.Items.AddRange(qBranchList.ToArray<QuickBranchList>());
                    chklRepositoryBranches.DisplayMember = "BranchName";
                    chklRepositoryBranches.ValueMember = "BranchGuid";

                    for (int i = 0; i < chklRepositoryBranches.Items.Count; i++)
                    {
                        chklRepositoryBranches.SetItemChecked(i, true);
                    }
                }
                else
                {
                    chklRepositoryBranches.Visible = false;
                }

                loadBranchMergeFromBranch_DataSet();
            }
        }

        private void dgvBranches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBranches.SelectedRows.Count > 0)
            {
                GitConfigs.Branch branch = settingsXml.BranchList.Find(x => x.EntityGuid == dgvBranches.SelectedRows[0].Cells["BranchGuid"].Value.ToString());

                txtBranchGuid.Text = branch.EntityGuid;
                txtBranchName.Text = branch.EntityName;
                chkBranchPullFirst.Checked = branch.PullFirst;
                chkBranchUndoAnyChanges.Checked = branch.UndoAnyChanges;
                chkBranchActive.Checked = branch.Active;

                rdBranchEditMode.Checked = true;

                txtBranchGuid.Enabled = false;
                rdBranchEditMode.Enabled = true;
                rdBranchAppliesToAllRepositoriesAllProjects.Checked = false;
                rdBranchAppliesToAllRepositoriesInCurrentProject.Checked = false;
                rdBranchAppliesToAllRepositoriesInCurrentProject.Enabled = false;
                rdBranchAppliesToSpecificRepositories.Enabled = false;

                loadBranchMergeFromBranch_DataSet();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            openFileInNotepad(settingFileName);
        }

        private void btnBuildBashFile_Click(object sender, EventArgs e)
        {
            //settingOutputFolder
        }

        private GitConfigs.Repository getRepository()
        {
            return settingsXml.ProjectList
                .Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString()).RepositoryList
                .Find(x => x.EntityGuid == dgvRepositories.SelectedRows[0].Cells["RepositoryGuid"].Value.ToString());
        }

        private void btnViewBashFile_Click(object sender, EventArgs e)
        {
            GitConfigs.Project project = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString());
            openFileInNotepad(settingOutputFolder + project.OutputFileName);
        }

        private void openFileInNotepad(string fileName)
        {
            Process proc = new Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "notepad.exe";
            proc.StartInfo.Arguments = "\"" + fileName + "\"";
            proc.Start();
        }

        private void btnSaveRepository_Click(object sender, EventArgs e)
        {
            GitConfigs.Repository recordObj;
            bool newRecord = false;
            GitConfigs.Project project = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString());

            if (project.RepositoryList.Count > 0 && txtRepositoryGuid.Text == String.Empty)
            {
                List<GitConfigs.Repository> repositoriesFound = project.RepositoryList.FindAll(x => x.EntityName == txtRepositoryName.Text || x.FolderPath == txtRepositoryFolderPath.Text);
                if (repositoriesFound.Count > 1)
                {
                    MessageBox.Show("There are duplicate records with that Name and Folder Path");
                    return;
                }

                if (repositoriesFound.Count == 1)
                {
                    txtRepositoryGuid.Text = repositoriesFound[0].EntityGuid;
                }
            }

            if (project.RepositoryList.Count == 0 || txtRepositoryGuid.Text == String.Empty)
            {
                newRecord = true;
                recordObj = new GitConfigs.Repository();
            }
            else
            {
                recordObj = project.RepositoryList.Find(x => x.EntityGuid == txtRepositoryGuid.Text);
                if (recordObj == null)
                {
                    newRecord = true;
                    recordObj = new GitConfigs.Repository();
                }
            }

            recordObj.EntityName = txtRepositoryName.Text;
            recordObj.FolderPath = txtRepositoryFolderPath.Text;
            recordObj.PerformPruneAtEnd = chkRepositoryPerformPruneAtEnd.Checked;
            recordObj.Active = chkRepositoryActive.Checked;

            if (newRecord)
            {
                if (txtRepositoryGuid.Text == String.Empty)
                {
                    btnRepositoryGuidGenerator_Click(null, null);
                }

                recordObj.EntityGuid = txtRepositoryGuid.Text;
                project.RepositoryList.Add(recordObj);
            }

            saveSettings();
            btnRepositoryClear_Click(null, null);
            bRepositorySource.ResetBindings(true);
            enableDisableBranches(project);
        }

        private void btnRepositoryGuidGenerator_Click(object sender, EventArgs e)
        {
            txtRepositoryGuid.Text = Guid.NewGuid().ToString();
        }

        private void btnBranchGenerateGuid_Click(object sender, EventArgs e)
        {
            txtBranchGuid.Text = Guid.NewGuid().ToString();
        }      

        private void btnBranchClear_Click(object sender, EventArgs e)
        {
            txtBranchGuid.Enabled = true;
            txtBranchGuid.Text = String.Empty;
            txtBranchName.Text = String.Empty;
            chkBranchUndoAnyChanges.Checked = false;
            chkBranchPullFirst.Checked = false;
            rdBranchEditMode.Checked = false;
            rdBranchAppliesToAllRepositoriesAllProjects.Checked = true;
            rdBranchAppliesToAllRepositoriesInCurrentProject.Checked = false;
            rdBranchAppliesToSpecificRepositories.Checked = false;
            chkBranchActive.Checked = true;
            cbBranchMergeFromBranch.SelectedIndex = -1;
            loadBranchMergeFromBranch_DataSet();

            resetBranchAppliesTo();
            HandleApplyToSpecificRepositories();
            dgvBranches.ClearSelection();
        }

        private void resetBranchAppliesTo()
        {
            rdBranchEditMode.Checked = false;
            rdBranchAppliesToAllRepositoriesAllProjects.Checked = true;
            rdBranchAppliesToAllRepositoriesInCurrentProject.Checked = false;
            rdBranchAppliesToSpecificRepositories.Checked = false;
            rdBranchAppliesToClearRepositoryBranches.Checked = false;
        }

        private void btnSaveBranch_Click(object sender, EventArgs e)
        {
            var branchGuid = saveBranch();

            if (rdBranchAppliesToAllRepositoriesAllProjects.Checked)
            {
                foreach (GitConfigs.Project project in settingsXml.ProjectList)
                {
                    foreach (GitConfigs.Repository repository in project.RepositoryList)
                    {
                        if (!repository.repositoryBranchOrderList.Exists(x => x.BranchGuid == branchGuid))
                        {
                            GitConfigs.RepositoryBranchOrder repositoryBranchOrderItem = new GitConfigs.RepositoryBranchOrder();
                            repositoryBranchOrderItem.OrderBy = repository.repositoryBranchOrderList.Count + 1;
                            repositoryBranchOrderItem.BranchGuid = branchGuid;
                            repository.repositoryBranchOrderList.Add(repositoryBranchOrderItem);
                        }
                    }
                }
            }
            else if (rdBranchAppliesToAllRepositoriesInCurrentProject.Checked)
            {
                GitConfigs.Project project = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString());

                foreach (GitConfigs.Repository repository in project.RepositoryList)
                {
                    if (!repository.repositoryBranchOrderList.Exists(x => x.BranchGuid == branchGuid))
                    {
                        GitConfigs.RepositoryBranchOrder repositoryBranchOrderItem = new GitConfigs.RepositoryBranchOrder();
                        repositoryBranchOrderItem.OrderBy = repository.repositoryBranchOrderList.Count + 1;
                        repositoryBranchOrderItem.BranchGuid = branchGuid;
                        repository.repositoryBranchOrderList.Add(repositoryBranchOrderItem);
                    }
                }
            }
            else if (rdBranchAppliesToSpecificRepositories.Checked)
            {
                foreach (DataRowView view in chklBranchesAppliesToSpecificRepositories.CheckedItems)
                {
                    var checkedItem = view[chklBranchesAppliesToSpecificRepositories.ValueMember].ToString();
                    GitConfigs.Repository repository = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString()).RepositoryList.Find(x => x.EntityGuid == checkedItem);

                    if (!repository.repositoryBranchOrderList.Exists(x => x.BranchGuid == branchGuid))
                    {
                        GitConfigs.RepositoryBranchOrder repositoryBranchOrderItem = new GitConfigs.RepositoryBranchOrder();
                        repositoryBranchOrderItem.OrderBy = repository.repositoryBranchOrderList.Count + 1;
                        repositoryBranchOrderItem.BranchGuid = branchGuid;
                        repository.repositoryBranchOrderList.Add(repositoryBranchOrderItem);
                    }
                }
            }
            else if (rdBranchAppliesToClearRepositoryBranches.Checked)
            {
                foreach (GitConfigs.Project project in settingsXml.ProjectList)
                {
                    foreach (GitConfigs.Repository repository in project.RepositoryList)
                    {
                        GitConfigs.RepositoryBranchOrder repositoryBranchOrderItem = repository.repositoryBranchOrderList.Find(x => x.BranchGuid == branchGuid);
                        if (repositoryBranchOrderItem != null)
                        {
                            foreach (GitConfigs.RepositoryBranchOrder repositoryBranchOrderItemUpdate in repository.repositoryBranchOrderList)
                            {
                                repository.repositoryBranchOrderList.Remove(repositoryBranchOrderItem);
                                if (repositoryBranchOrderItemUpdate.OrderBy >= repositoryBranchOrderItem.OrderBy)
                                {
                                    repositoryBranchOrderItemUpdate.OrderBy = -1;
                                }
                            }
                        }
                    }
                }
            }

            saveSettings();
            btnBranchClear_Click(null, null);
            bBranchSource.DataSource = getBranches();
            bBranchSource.ResetBindings(true);
        }

        private string saveBranch()
        {
            GitConfigs.Branch recordObj;
            bool newRecord = false;

            if (settingsXml.BranchList.Count == 0)
            {
                newRecord = true;
                recordObj = new GitConfigs.Branch();
            }
            else
            {
                recordObj = settingsXml.BranchList.Find(x => x.EntityGuid == txtBranchGuid.Text);
                if (recordObj == null)
                {
                    newRecord = true;
                    recordObj = new GitConfigs.Branch();
                }
            }

            recordObj.EntityName = txtBranchName.Text;
            recordObj.UndoAnyChanges = chkBranchUndoAnyChanges.Checked;
            recordObj.PullFirst = chkBranchPullFirst.Checked;
            recordObj.Active = chkBranchActive.Checked;

            if (cbBranchMergeFromBranch.SelectedIndex != -1)
            {
                recordObj.MergeFromBranchEntityGuid = cbBranchMergeFromBranch.SelectedValue.ToString();
            }

            if (newRecord)
            {
                if (txtBranchGuid.Text == String.Empty)
                {
                    btnBranchGenerateGuid_Click(null, null);
                }

                recordObj.EntityGuid = txtBranchGuid.Text;
                settingsXml.BranchList.Add(recordObj);
            }

            return recordObj.EntityGuid;
        }

        private DataTable getBranches()
        {
            DataTable dtBranches = new DataTable();
            dtBranches.Columns.Add("Repository", typeof(string));
            dtBranches.Columns.Add("Name", typeof(string));
            dtBranches.Columns.Add("Guid", typeof(string));

            if (dgvRepositories.SelectedRows.Count > 0 || dgvProjects.SelectedRows.Count > 0)
            {
                if (dgvRepositories.SelectedRows.Count > 0)
                {
                    dtBranches = getBranchesByRepository(dtBranches, getRepository());
                }
                else
                {
                    GitConfigs.Project project = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString());
                    foreach (GitConfigs.Repository repository in project.RepositoryList)
                    {
                        dtBranches = getBranchesByRepository(dtBranches, repository);
                    }
                }
            }

            if (dtBranches.Rows.Count == 0)
            {
                foreach (GitConfigs.Branch branch in settingsXml.BranchList)
                {
                    if (branch.Active)
                    {
                        var newRow = dtBranches.NewRow();

                        newRow["Name"] = branch.EntityName;
                        newRow["Guid"] = branch.EntityGuid;

                        dtBranches.Rows.Add(newRow);
                    }
                }
            }

            if (dtBranches != null && dtBranches.Rows.Count > 0)
            {
                dgvBranches.Columns["Repository"].Visible = dtBranches.Rows[0]["Repository"].ToString() != String.Empty;
            }

            return dtBranches;
        }

        private DataTable getBranchesByRepository(DataTable dtBranches, GitConfigs.Repository repository)
        {
            foreach (GitConfigs.RepositoryBranchOrder repositoryBranchOrderItem in repository.repositoryBranchOrderList)
            {
                GitConfigs.Branch branch = settingsXml.BranchList.Find(x => x.EntityGuid == repositoryBranchOrderItem.BranchGuid);

                if (branch.Active)
                {
                    var newRow = dtBranches.NewRow();

                    newRow["Repository"] = repository.EntityName;
                    newRow["Name"] = branch.EntityName;
                    newRow["Guid"] = branch.EntityGuid;

                    dtBranches.Rows.Add(newRow);
                }
            }

            return dtBranches;
        }

        private void rdBranchAppliesToSpecificRepositories_CheckedChanged(object sender, EventArgs e)
        {
            HandleApplyToSpecificRepositories();
        }

        private void HandleApplyToSpecificRepositories()
        {
            if (rdBranchAppliesToSpecificRepositories.Checked)
            {
                chklBranchesAppliesToSpecificRepositories.Visible = true;
                GitConfigs.Project project = settingsXml.ProjectList.Find(x => x.EntityGuid == dgvProjects.SelectedRows[0].Cells["ProjectGuid"].Value.ToString());
                if (project != null)
                {
                    chklBranchesAppliesToSpecificRepositories.ClearSelected();
                    chklBranchesAppliesToSpecificRepositories.Items.Clear();
                    chklBranchesAppliesToSpecificRepositories.Items.AddRange(project.RepositoryList.ToArray<GitConfigs.Repository>());
                    chklBranchesAppliesToSpecificRepositories.DisplayMember = "EntityName";
                    chklBranchesAppliesToSpecificRepositories.ValueMember = "EntityGuid";
                }
            }
            else
            {
                chklBranchesAppliesToSpecificRepositories.Visible = false;
                chklBranchesAppliesToSpecificRepositories.Items.Clear();
            }
        }

        private void rdBranchAppliesToAllRepositories_CheckedChanged(object sender, EventArgs e)
        {
            HandleApplyToSpecificRepositories();
        }

        private void rdBranchEditMode_CheckedChanged(object sender, EventArgs e)
        {
            HandleApplyToSpecificRepositories();
        }

        private void txtRepositoryFolderPath_TextChanged(object sender, EventArgs e)
        {
            string[] pathPieces = txtRepositoryFolderPath.Text.Split('\\');
            txtRepositoryName.Text = pathPieces[pathPieces.Length - 1];
        }

        private void btnProjectClear_Click(object sender, EventArgs e)
        {
            txtProjectGuid.Enabled = true;
            txtProjectGuid.Text = String.Empty;
            txtProjectName.Text = String.Empty;
            txtProjectOutputFileName.Text = String.Empty;
            chkBranchActive.Checked = true;

            dgvProjects.ClearSelection();
        }

        private void btnRepositoryClear_Click(object sender, EventArgs e)
        {

            txtRepositoryGuid.Enabled = true;
            txtRepositoryGuid.Text = String.Empty;
            txtRepositoryName.Text = String.Empty;
            txtRepositoryFolderPath.Text = String.Empty;
            chkRepositoryPerformPruneAtEnd.Checked = true;
            chkRepositoryActive.Checked = true;

            chklRepositoryBranches.Visible = false;
            chklRepositoryBranches.Items.Clear();

            dgvRepositories.ClearSelection();
        }

        private void loadBranchMergeFromBranch_DataSet()
        {
            List<GitConfigs.Branch> branchList = new List<GitConfigs.Branch>();
            if (dgvRepositories.SelectedRows.Count > 0)
            {
                GitConfigs.Repository repository = getRepository();
                branchList = settingsXml.BranchList.FindAll(x => x.EntityGuid.Equals(from branchItem in repository.repositoryBranchOrderList
                                                                                                          where repository.EntityGuid.Equals(repository.EntityGuid)
                                                                                                          select branchItem.BranchGuid.FirstOrDefault()));
            } 
            else
            {
                branchList = settingsXml.BranchList;
            }

            branchList = branchList.GetRange(0, branchList.Count());

            if (dgvBranches.SelectedRows.Count > 0)
            {
                GitConfigs.Branch branch = settingsXml.BranchList.Find(x => x.EntityGuid == dgvBranches.SelectedRows[0].Cells["BranchGuid"].Value.ToString());

                if (branch != null)
                {
                    branchList.Remove(branch);
                }
            }

            BindingSource bBranceMergeSource = new BindingSource();
            bBranceMergeSource.DataSource = branchList;
            cbBranchMergeFromBranch.DataSource = bBranceMergeSource;
            bBranceMergeSource.ResetBindings(true);
        }

        private List<QuickBranchList> buildRepositoryBranchList(GitConfigs.Repository repository)
        {
            List<QuickBranchList> qBranchList = new List<QuickBranchList>();

            foreach (GitConfigs.RepositoryBranchOrder item in repository.repositoryBranchOrderList)
            {
                GitConfigs.Branch branch = settingsXml.BranchList.Find(branchItem => branchItem.EntityGuid == item.BranchGuid);
                QuickBranchList newBranchItem = new QuickBranchList();

                newBranchItem.BranchGuid = item.BranchGuid;
                newBranchItem.BranchName = branch.EntityName;

                qBranchList.Add(newBranchItem);
            }

            return qBranchList;
        }

        private void btnGitCommands_Click(object sender, EventArgs e)
        {
            frm_GitCommands gitComs = new frm_GitCommands();
            gitComs.ShowDialog(this);
        }
    }
}
