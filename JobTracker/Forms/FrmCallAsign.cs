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
    public partial class FrmCallAsign : Form
    {
        public FrmCallAsign()
        {
            InitializeComponent();
        }
        public int id;
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        private void FrmCallAsign_Load(object sender, EventArgs e)
        {
            var value2 = (from x in _db.Personel
                         select new
                         {
                             x.ID,
                             AdSoyad = x.Name + " " + x.LastName, //ananymous type
                         }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = value2;

            txtCagriId.Text = id.ToString();
            var value = _db.Call.Find(id);
            txtAciklama.Text = value.Description;
            txtTarih.Text = value.Date.ToString();

            txtKonu.Text = value.Subject;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var value = _db.Call.Find(id);
            value.Subject = txtKonu.Text;
            value.Date = Convert.ToDateTime(txtTarih.Text);
            value.Description= txtAciklama.Text;
            value.PersonelID =int.Parse(lookUpEdit1.EditValue.ToString());
            _db.SaveChanges();
            this.Close();
        }
    }
}
