using DevExpress.XtraEditors;
using Intercom.Core;
using JobTracker.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace JobTracker.Forms
{
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }

        private void Departman_Click(object sender, EventArgs e)
        {

        }
        DbJobTrackingEntities1 db = new DbJobTrackingEntities1();

        void List()
        {
      
            var value = (from x in db.Departments select new 
            {
                x.ID,
                x.Name
            }).ToList();
            gridControl1.DataSource = value;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            Departments t = new Departments();
            t.Name = txtAd.Text;
            db.Departments.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text); // txt(id) den gelen değer x e atandı
            var value = db.Departments.Find(x);
            db.Departments.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //imleç bir sekmeden diğerine geçtiğinde input içerisine bilgiler doluyor.
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text); // txt(id) den gelen değer x e atandı
            var value = db.Departments.Find(x);
            value.Name = txtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            List();
        }

        private void FrmDepartments_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
