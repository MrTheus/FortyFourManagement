using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FortyFourManagement.Objects;

namespace FortyFourManagement.UserControls
{
    public partial class UCOverview : DevExpress.XtraEditors.XtraUserControl
    {
        List<Team> Teams { get; set; }
        List<Player> Players { get; set; }
        public UCOverview()
        {
            InitializeComponent();

            Teams = new List<Team>();
            teamBindingSource.DataSource = Teams;

            Players = new List<Player>();
            playerBindingSource.DataSource = Players;
        }
    }
}
