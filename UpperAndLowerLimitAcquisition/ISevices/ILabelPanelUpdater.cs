using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.ISevices
{
    public interface ILabelPanelUpdater
    {
        string PanelId { get; }
        void UpdateLabels(int total, int success, int failed);
        void SetFailedFiles(List<DirectoryInfo> failedFiles);
    }
}
