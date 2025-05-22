using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class AcquisitionProgressFailedNotification: INotification
    {     
        public string PanelId { get;}
        public int TotalCount { get;}
        public int SuccessCount { get;}
        public int FailedCount { get;}
        public List<DirectoryInfo> FailedFiles { get;}

        public AcquisitionProgressFailedNotification(string panelId, int total, int sucess, int fail, List<DirectoryInfo> files)
        { 
            PanelId = panelId;
            TotalCount = total;
            SuccessCount = sucess;
            FailedCount = fail;
            FailedFiles = files;
        }
    }
}
