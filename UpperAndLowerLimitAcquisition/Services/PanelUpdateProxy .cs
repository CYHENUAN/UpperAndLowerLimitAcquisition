using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.ISevices;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class PanelUpdateProxy : ILabelPanelUpdater
    {
        public string PanelId { get; }
        private readonly Label _lblTotal;
        private readonly Label _lblSuccess;
        private readonly Label _lblFailed;
        private List<DirectoryInfo> _failedFiles = new();

        public PanelUpdateProxy(string id, Label total, Label success, Label failed)
        {
            PanelId = id;
            _lblTotal = total;
            _lblSuccess = success;
            _lblFailed = failed;
        }

        //更修UI
        public void UpdateLabels(int total, int success, int failed)
        {
            if (_lblTotal.InvokeRequired)
            {
                _lblTotal.Invoke(() => UpdateLabels(total, success, failed));
                return;
            }

            _lblTotal.Text = $"{total.ToString()}";
            _lblSuccess.Text = $"{success.ToString()}";
            _lblFailed.Text = $"{failed.ToString()}";
        }


        public void SetFailedFiles(List<DirectoryInfo> files)
        {
            _failedFiles = files;
        }

        public List<DirectoryInfo> GetFailedFiles() => _failedFiles;
    }
}
