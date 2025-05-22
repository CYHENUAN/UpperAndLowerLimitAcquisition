using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class RetryFileReadCommand: IRequest
    {
        public List<DirectoryInfo> FailedFilesToRetry { get;}
        public RetryFileReadCommand(List<DirectoryInfo> files)
        {
            FailedFilesToRetry = files;
        }
    }
}
