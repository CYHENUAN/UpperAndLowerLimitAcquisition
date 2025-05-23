using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class RetrySingeFileReadCommand : IRequest
    {
        public string PanelId { get; }
        public DirectoryInfo FailedFileToRetry { get; }
        public RetrySingeFileReadCommand(string panelId ,DirectoryInfo file)
        {
            PanelId = panelId;
            FailedFileToRetry = file;
        }
    }
}
