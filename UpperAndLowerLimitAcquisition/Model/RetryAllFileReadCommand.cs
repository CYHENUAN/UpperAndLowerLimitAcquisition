using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class RetryAllFileReadCommand: IRequest
    {
        public string PanelId { get; set; }
        public List<DirectoryInfo> FailedFilesToRetry { get;}
        public RetryAllFileReadCommand(string panelId ,List<DirectoryInfo> files)
        {
            PanelId = panelId;
            FailedFilesToRetry = files;
        }
    }
}
