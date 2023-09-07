using DevExpress.XtraEditors;
using JobTracker.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker.PersonelMissionForms
{
    public partial class FrmCallDetailsEntered : Form
    {
        public FrmCallDetailsEntered()
        {
            InitializeComponent();
        }
        public int id;
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCallDetailsEntered_Load(object sender, EventArgs e)
        {
            txtCallId2.Enabled = false;
            txtCallId2.Text =id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txtTarih.Text = tarih;
            txtSaat.Text = saat;
        }
        DbJobTrackingEntities1 _db=new DbJobTrackingEntities1();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            CallDetails t = new CallDetails();
            t.Call=int.Parse(txtCallId2.Text);
            t.Saat = txtSaat.Text;
            t.Date =DateTime.Parse( txtTarih.Text);
            t.Description = txtAciklama.Text;
            _db.CallDetails.Add(t);
            _db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Kaydedildi.");
            this.Close();
        }
    }
}
