using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FortyFourManagement.UserControls;

namespace FortyFourManagement
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void accordionControlElementUpdate2018191_Click(object sender, EventArgs e)
        {
            panelControlMain.Controls.Clear();

            String saision = accordionControlElement2018191.Text;
            String league = accordionControlElement2018191.OwnerElement.OwnerElement.Text.ToString();

            UCUpdate ucUpdate = new UCUpdate(league,saision);
            panelControlMain.Controls.Add(ucUpdate);
            ucUpdate.Show();
            ucUpdate.Dock = DockStyle.Fill;
            ucUpdate.GetData();
        }
    }
}