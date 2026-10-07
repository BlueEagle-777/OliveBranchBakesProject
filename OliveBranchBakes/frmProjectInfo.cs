using System.Globalization;

namespace OliveBranchBakes
{
    public partial class frmProjectInfo : Form
    {
        public frmProjectInfo()
        {
            InitializeComponent();
        }

        private void frmProjectInfo_Load(object sender, EventArgs e)
        {
            lblDateValue.Text = lblDateValue.Text = "9/27/2026";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
