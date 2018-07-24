namespace FortyFourManagement.UserControls
{
    partial class UCCreateUploudPlan
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
            this.panelControlCreat = new DevExpress.XtraEditors.PanelControl();
            this.panelControlHistory = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCreat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlCreat
            // 
            this.panelControlCreat.Location = new System.Drawing.Point(3, 3);
            this.panelControlCreat.Name = "panelControlCreat";
            this.panelControlCreat.Size = new System.Drawing.Size(550, 390);
            this.panelControlCreat.TabIndex = 0;
            // 
            // panelControlHistory
            // 
            this.panelControlHistory.Location = new System.Drawing.Point(559, 3);
            this.panelControlHistory.Name = "panelControlHistory";
            this.panelControlHistory.Size = new System.Drawing.Size(192, 390);
            this.panelControlHistory.TabIndex = 1;
            // 
            // UCCreateUploudPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControlHistory);
            this.Controls.Add(this.panelControlCreat);
            this.Name = "UCCreateUploudPlan";
            this.Size = new System.Drawing.Size(754, 396);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCreat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlCreat;
        private DevExpress.XtraEditors.PanelControl panelControlHistory;
    }
}
