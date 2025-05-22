using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            // 如果打标配置文件路径为空，则使用默认路径  
            this.propertyGrid1.SelectedObject = GlobalData.Params;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 确保 propertyGrid1.SelectedObject 不为 null  
            if (propertyGrid1.SelectedObject is ParamsSetting selectedParams)
            {
                XmlSerializeHelper<ParamsSetting>.SerializeToFile(GlobalData.ParamsSettingPath, selectedParams);
            }
            else
            {
                MessageBox.Show("参数设置无效，无法保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //将全局变量中的参数设置更新为最新的配置
            GlobalData.Params = XmlSerializeHelper<ParamsSetting>.DeSerializeFronFile(GlobalData.ParamsSettingPath);
            this.Close();
        }
    }
}
