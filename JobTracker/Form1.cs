using JobTracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartments frm= new Forms.FrmDepartments();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPersonel frm2 = new Forms.FrmPersonel();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void btnPersonelIstatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPersonelStatistic frm3 = new Forms.FrmPersonelStatistic();
            frm3.MdiParent = this;
            frm3.Show();
        }

        Forms.FrmMissionList frm4;
        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {

            
            frm4= new Forms.FrmMissionList();
            frm4.MdiParent = this;
            frm4.Show();
            }
        }

        private void btnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMission fr = new Forms.FrmMission();  
            fr.Show();
        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMissionDetail frm= new Forms.FrmMissionDetail();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Forms.FrmMainForm frm5;
        private void btnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm4.IsDisposed)
            {


                frm5 = new Forms.FrmMainForm();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        Forms.FrmActiveCalls frm;
        private void btnAktif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             //new Forms.FrmActiveCalls();
            if (frm == null || frm4.IsDisposed)
            {
                frm = new Forms.FrmActiveCalls();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
