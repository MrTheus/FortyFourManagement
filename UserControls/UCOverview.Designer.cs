namespace FortyFourManagement.UserControls
{
    partial class UCOverview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridControlPlayers = new DevExpress.XtraGrid.GridControl();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlayerUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCaptain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControlAbove = new DevExpress.XtraEditors.PanelControl();
            this.gridControlTeam = new DevExpress.XtraGrid.GridControl();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeamUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeamPlayersUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlayerCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketValueMedian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlAbove)).BeginInit();
            this.panelControlAbove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Controls.Add(this.gridControlPlayers);
            this.panelControlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlBottom.Location = new System.Drawing.Point(0, 0);
            this.panelControlBottom.Name = "panelControlBottom";
            this.panelControlBottom.Size = new System.Drawing.Size(1015, 234);
            this.panelControlBottom.TabIndex = 0;
            // 
            // gridControlPlayers
            // 
            this.gridControlPlayers.DataSource = this.playerBindingSource;
            this.gridControlPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPlayers.Location = new System.Drawing.Point(2, 2);
            this.gridControlPlayers.MainView = this.gridView2;
            this.gridControlPlayers.Name = "gridControlPlayers";
            this.gridControlPlayers.Size = new System.Drawing.Size(1011, 230);
            this.gridControlPlayers.TabIndex = 0;
            this.gridControlPlayers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(FortyFourManagement.Objects.Player);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colPlayerUrl,
            this.colImageUrl,
            this.colPosition,
            this.colNumber,
            this.colBirthDate,
            this.colMarketValue1,
            this.colIsCaptain,
            this.colLoaned,
            this.colIsNew,
            this.colUsed});
            this.gridView2.GridControl = this.gridControlPlayers;
            this.gridView2.Name = "gridView2";
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colPlayerUrl
            // 
            this.colPlayerUrl.FieldName = "PlayerUrl";
            this.colPlayerUrl.Name = "colPlayerUrl";
            this.colPlayerUrl.Visible = true;
            this.colPlayerUrl.VisibleIndex = 1;
            // 
            // colImageUrl
            // 
            this.colImageUrl.FieldName = "ImageUrl";
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.Visible = true;
            this.colImageUrl.VisibleIndex = 2;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            // 
            // colNumber
            // 
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 4;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 5;
            // 
            // colMarketValue1
            // 
            this.colMarketValue1.FieldName = "MarketValue";
            this.colMarketValue1.Name = "colMarketValue1";
            this.colMarketValue1.Visible = true;
            this.colMarketValue1.VisibleIndex = 6;
            // 
            // colIsCaptain
            // 
            this.colIsCaptain.FieldName = "IsCaptain";
            this.colIsCaptain.Name = "colIsCaptain";
            this.colIsCaptain.Visible = true;
            this.colIsCaptain.VisibleIndex = 7;
            // 
            // colLoaned
            // 
            this.colLoaned.FieldName = "Loaned";
            this.colLoaned.Name = "colLoaned";
            this.colLoaned.Visible = true;
            this.colLoaned.VisibleIndex = 8;
            // 
            // colIsNew
            // 
            this.colIsNew.FieldName = "IsNew";
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.Visible = true;
            this.colIsNew.VisibleIndex = 9;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControlAbove);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControlBottom);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1015, 402);
            this.splitContainerControl1.SplitterPosition = 163;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControlAbove
            // 
            this.panelControlAbove.Controls.Add(this.gridControlTeam);
            this.panelControlAbove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlAbove.Location = new System.Drawing.Point(0, 0);
            this.panelControlAbove.Name = "panelControlAbove";
            this.panelControlAbove.Size = new System.Drawing.Size(1015, 163);
            this.panelControlAbove.TabIndex = 0;
            // 
            // gridControlTeam
            // 
            this.gridControlTeam.DataSource = this.teamBindingSource;
            this.gridControlTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTeam.Location = new System.Drawing.Point(2, 2);
            this.gridControlTeam.MainView = this.gridView1;
            this.gridControlTeam.Name = "gridControlTeam";
            this.gridControlTeam.Size = new System.Drawing.Size(1011, 159);
            this.gridControlTeam.TabIndex = 0;
            this.gridControlTeam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(FortyFourManagement.Objects.Team);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colTeamUrl,
            this.colTeamPlayersUrl,
            this.colPlayerCount,
            this.colMarketValue,
            this.colMarketValueMedian,
            this.colIcon});
            this.gridView1.GridControl = this.gridControlTeam;
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colTeamUrl
            // 
            this.colTeamUrl.FieldName = "TeamUrl";
            this.colTeamUrl.Name = "colTeamUrl";
            this.colTeamUrl.Visible = true;
            this.colTeamUrl.VisibleIndex = 1;
            // 
            // colTeamPlayersUrl
            // 
            this.colTeamPlayersUrl.FieldName = "TeamPlayersUrl";
            this.colTeamPlayersUrl.Name = "colTeamPlayersUrl";
            this.colTeamPlayersUrl.Visible = true;
            this.colTeamPlayersUrl.VisibleIndex = 2;
            // 
            // colPlayerCount
            // 
            this.colPlayerCount.FieldName = "PlayerCount";
            this.colPlayerCount.Name = "colPlayerCount";
            this.colPlayerCount.Visible = true;
            this.colPlayerCount.VisibleIndex = 3;
            // 
            // colMarketValue
            // 
            this.colMarketValue.FieldName = "MarketValue";
            this.colMarketValue.Name = "colMarketValue";
            this.colMarketValue.Visible = true;
            this.colMarketValue.VisibleIndex = 4;
            // 
            // colMarketValueMedian
            // 
            this.colMarketValueMedian.FieldName = "MarketValueMedian";
            this.colMarketValueMedian.Name = "colMarketValueMedian";
            this.colMarketValueMedian.Visible = true;
            this.colMarketValueMedian.VisibleIndex = 5;
            // 
            // colIcon
            // 
            this.colIcon.FieldName = "Icon";
            this.colIcon.Name = "colIcon";
            this.colIcon.Visible = true;
            this.colIcon.VisibleIndex = 6;
            // 
            // colUsed
            // 
            this.colUsed.FieldName = "Used";
            this.colUsed.Name = "colUsed";
            this.colUsed.Visible = true;
            this.colUsed.VisibleIndex = 10;
            // 
            // UCOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UCOverview";
            this.Size = new System.Drawing.Size(1015, 402);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlAbove)).EndInit();
            this.panelControlAbove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlBottom;
        private DevExpress.XtraGrid.GridControl gridControlPlayers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControlAbove;
        private DevExpress.XtraGrid.GridControl gridControlTeam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlayerUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketValue1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCaptain;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaned;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNew;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colTeamPlayersUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colPlayerCount;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketValue;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketValueMedian;
        private DevExpress.XtraGrid.Columns.GridColumn colIcon;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUsed;
    }
}
