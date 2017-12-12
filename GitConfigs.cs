using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitManager
{
    [Serializable]
    public class GitConfigs
    {
        [Serializable]
        public class GitInformation
        {
            public List<Project> ProjectList  = new List<Project>();
            public List<Branch> BranchList { get; set; } = new List<Branch>();
        }

        [Serializable]
        public class Project
        {
            public string EntityGuid { get; set; } = String.Empty;
            public string EntityName { get; set; } = String.Empty;
            public string OutputFileName { get; set; } = String.Empty;
            public bool Active { get; set; } = true;

            public List<Repository> RepositoryList { get; set; } = new List<Repository>();
        }

        [Serializable]
        public class Repository
        {
            public string EntityGuid { get; set; } = String.Empty;
            public string EntityName { get; set; } = String.Empty;
            public string FolderPath { get; set; } = String.Empty;
            public bool PerformPruneAtEnd { get; set; } = true;
            public bool Active { get; set; } = true;

            public List<RepositoryBranchOrder> repositoryBranchOrderList { get; set; } = new List<RepositoryBranchOrder>();
        }

        [Serializable]
        public class Branch
        {
            public string EntityGuid { get; set; } = String.Empty;
            public string EntityName { get; set; } = String.Empty;
            public bool PullFirst { get; set; } = false;
            public string MergeFromBranchEntityGuid { get; set; } = String.Empty;
            public bool UndoAnyChanges { get; set; } = true;
            public bool Active { get; set; } = true;
        }

        [Serializable]
        public class RepositoryBranchOrder
        {
            public int OrderBy { get; set; } = -1;
            public string BranchGuid { get; set; } = String.Empty;
        }


    }
}
