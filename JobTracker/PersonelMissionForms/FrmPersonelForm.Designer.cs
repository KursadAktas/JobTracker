namespace JobTracker.PersonelMissionForms
{
    partial class FrmPersonelForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnActiveMission = new DevExpress.XtraBars.BarButtonItem();
            this.btnPassiveMission = new DevExpress.XtraBars.BarButtonItem();
            this.btnCallList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnActiveMission,
            this.btnPassiveMission,
            this.btnCallList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1182, 183);
            // 
            // btnActiveMission
            // 
            this.btnActiveMission.Caption = "Aktif Görevler";
            this.btnActiveMission.Id = 1;
            this.btnActiveMission.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveMission.ImageOptions.Image")));
            this.btnActiveMission.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActiveMission.ImageOptions.LargeImage")));
            this.btnActiveMission.Name = "btnActiveMission";
            this.btnActiveMission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActiveMission_ItemClick);
            // 
            // btnPassiveMission
            // 
            this.btnPassiveMission.Caption = "Pasif Görevler";
            this.btnPassiveMission.Id = 2;
            this.btnPassiveMission.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPassiveMission.ImageOptions.Image")));
            this.btnPassiveMission.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPassiveMission.ImageOptions.LargeImage")));
            this.btnPassiveMission.Name = "btnPassiveMission";
            this.btnPassiveMission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPassiveMission_ItemClick);
            // 
            // btnCallList
            // 
            this.btnCallList.Caption = "Çağrı Listesi";
            this.btnCallList.Id = 3;
            this.btnCallList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCallList.ImageOptions.Image")));
            this.btnCallList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCallList.ImageOptions.LargeImage")));
            this.btnCallList.Name = "btnCallList";
            this.btnCallList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCallList_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnActiveMission);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPassiveMission);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCallList);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmPersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmPersonelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelForm";
            this.Load += new System.EventHandler(this.FrmPersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnActiveMission;
        private DevExpress.XtraBars.BarButtonItem btnPassiveMission;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCallList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}