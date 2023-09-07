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

namespace JobTracker.Forms
{
    public partial class FrmMission : Form
    {
        public FrmMission()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Missions t = new Missions();
            t.Description = txtAciklama.Text;
            t.Stituation = true;
           t.Responsible =int.Parse( lookUpEdit1.EditValue.ToString());
           t.Tarih = DateTime.Parse(txtTarih.Text);
            t.Assignor = int.Parse(txtGorevVeren.Text);
            _db.Missions.Add(t);
            _db.SaveChanges();
            XtraMessageBox.Show("Görev Kaydedildi","Bilgi" ,MessageBoxButtons.OK, MessageBoxIcon.Information );
            this.Close();
        }

        private void FrmMission_Load(object sender, EventArgs e)
        {
            var value = (from x in _db.Personel
                         select new
                         {
                             x.ID,
                             AdSoyad = x.Name + " " + x.LastName, //ananymous type
                         }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = value;
        }
    }
}
