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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        void Personel()
        {
            var value = from x in _db.Personel
                        select new
                        {
                            x.ID,
                            x.Name,
                            x.LastName,
                            x.Mail,
                            x.Delete,
                           Departman = x.Departments.Name // departman adlarını getirdim
                        };
            gridControl1.DataSource = value.Where(x=>x.Delete == true).ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
          Personel();
            var departments =( from x in _db.Departments select new
            {
                x.ID,
                x.Name,

            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID"; // görünecek olan bilginin ID si seçildi 
            lookUpEdit1.Properties.DisplayMember = "Name"; // görünecek olan bilgi seçildi.
             lookUpEdit1.Properties.DataSource = departments;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Personel();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel t = new Personel();
            t.Name =txtAd.Text;
            t.LastName = txtSoyad.Text;
            t.Mail = txtMail.Text;
            t.Image = txtImage.Text;
            t.Department=int.Parse(lookUpEdit1.EditValue.ToString()); // departmanları seçiyoruz
            XtraMessageBox.Show("Yeni Personel kaydı yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _db.Personel.Add(t);
            _db.SaveChanges();
            Personel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtId.Text);
            var value = _db.Personel.Find(x);
            value.Delete = false;
            _db.SaveChanges();
            XtraMessageBox.Show("Personel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Personel();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            //txtImage.Text = gridView1.GetFocusedRowCellValue("Image").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var value = _db.Personel.Find(x);
            value.Name=txtAd.Text;
            value.LastName=txtSoyad.Text;
            value.Mail=txtMail.Text;
            value.Image=txtImage.Text;
            value.Department =int.Parse(lookUpEdit1.EditValue.ToString());
            _db.SaveChanges();
            XtraMessageBox.Show("Güncelleme işlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);

            Personel();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
