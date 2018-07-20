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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace FortyFourManagement.UserControls
{
    public partial class UCUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        List<Team> Teams { get; set; }
        List<Player> Players { get; set; }
        String Saison { get; set; }
        String League { get; set; }
        public object GridhitInfo { get; private set; }

        public UCUpdate()
        {
            InitializeComponent();
        }
        public UCUpdate(String league, String saison)
        {
            InitializeComponent();

            if (league == "Bundesliga")
            {
                League = PlayerDB.Leagues.BUNDESLIGA1;
            }

            if (saison.Contains("2018/19"))
            {
                Saison = "2018";
            }

            Teams = new List<Team>();
            teamBindingSource.DataSource = Teams;

            Players = new List<Player>();
            playerBindingSource.DataSource = Players;
        }

        public void GetTeams()
        {
            PlayerDB.PlayerDB playerDB = new PlayerDB.PlayerDB();
            List<PlayerDB.Models.Team> newTeams = new List<PlayerDB.Models.Team>();
            List<PlayerDB.Models.Player> newPlayers = new List<PlayerDB.Models.Player>();

            newTeams = playerDB.GetTeams(League, Saison);

            foreach (PlayerDB.Models.Team newTeam in newTeams)
            {
                Team team = new Team();
                team.Icon = newTeam.Icon;
                team.MarketValue = newTeam.MarketValue;
                team.MarketValueMedian = newTeam.MarketValueMedian;
                team.Name = newTeam.Name;
                team.PlayerCount = newTeam.PlayerCount;
                team.TeamPlayersUrl = newTeam.TeamPlayersUrl;
                team.TeamUrl = newTeam.TeamUrl;

                Teams.Add(team);

                newPlayers = playerDB.GetPlayers(newTeam);

                foreach (PlayerDB.Models.Player newPlayer in newPlayers)
                {
                    Player player = new Player();
                    player.BirthDate = newPlayer.BirthDate;
                    player.ImageUrl = newPlayer.ImageUrl;
                    player.IsCaptain = newPlayer.IsCaptain;
                    player.IsNew = newPlayer.IsNew;
                    player.Loaned = newPlayer.Loaned;
                    player.MarketValue = newPlayer.MarketValue;
                    player.Name = newPlayer.Name;
                    player.Number = newPlayer.Number;
                    player.PlayerUrl = newPlayer.PlayerUrl;
                    player.Position = newPlayer.Position;

                    Players.Add(player);
                }
            }
            
            gridViewTeam.RefreshData();
            gridView2.RefreshData();
        }

        private void gridControlTeam_MouseUp(object sender, MouseEventArgs e)
        {
            barButtonItemSaveTeams.Enabled = false;

            GridHitInfo hi = gridViewTeam.CalcHitInfo(e.Location);

            if (e.Button == System.Windows.Forms.MouseButtons.Right &&
               (hi.HitTest == GridHitTest.RowCell ||
               hi.HitTest == GridHitTest.EmptyRow))
            {
                Team team = gridViewTeam.GetFocusedRow() as Team;
                popupMenuTeams.ShowPopup(gridControlTeam.PointToScreen(new Point(e.X, e.Y)));
                if(null != team)
                {
                    barButtonItemSaveTeams.Enabled = true;
                }
            }

        }

        private void barButtonItemGetPlayers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PlayerDB.PlayerDB playerDB = new PlayerDB.PlayerDB();
            List<PlayerDB.Models.Player> newPlayers = new List<PlayerDB.Models.Player>();
            
        }
    }
}
