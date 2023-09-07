using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JobTracker.PersonelMissionForms
{
    public partial class FrmPersonelForm : Form
    {
        public FrmPersonelForm()
        {
            InitializeComponent();
        }
        public string mail;

        private void btnActiveMission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelMissionForms.FrmActiveMissions frm = new PersonelMissionForms.FrmActiveMissions();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void btnPassiveMission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelMissionForms.FrmPassiveMissions frm = new PersonelMissionForms.FrmPassiveMissions();
            frm.MdiParent = this;
            frm.mail2=mail;
            frm.Show();
        }

        private void btnCallList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            PersonelMissionForms.FrmCallList frm = new PersonelMissionForms.FrmCallList();
            frm.MdiParent = this;
            frm.mail2= mail;
            frm.Show();
        }

        private void FrmPersonelForm_Load(object sender, EventArgs e)
        {
            //this.Text = mail.ToString();
            this.Text = "Personel Paneli";
        }
    }
}
