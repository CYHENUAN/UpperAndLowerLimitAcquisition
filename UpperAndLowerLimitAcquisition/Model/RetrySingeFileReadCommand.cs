using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class RetrySingeFileReadCommand : IRequest<Unit>
    {
        public string PanelId { get; }
        public int TotalCount { get; }
        public int SuccessCount { get; }
        public int FailedCount { get; }
        public DirectoryInfo FailedFileToRetry { get; }
        public RetrySingeFileReadCommand(string panelId ,int total, int sucess, int fail, DirectoryInfo file)
        {
            PanelId = panelId;
            TotalCount = total;
            SuccessCount = sucess;
            FailedCount = fail;
            FailedFileToRetry = file;
        }
    }
}
