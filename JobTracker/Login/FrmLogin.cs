using DevExpress.XtraEditors;
using JobTracker.Entity;
using JobTracker.PersonelMissionForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelMissionForms.FrmPersonelForm fr = new PersonelMissionForms.FrmPersonelForm();
            fr.Show();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        private void button2_Click_1(object sender, EventArgs e)
        {
            var adminValue = _db.Admin.Where(x => x.User == txtUser.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (adminValue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");

            }
        }
        public string mail;
        private void button1_Click_1(object sender, EventArgs e)
        {
            var personel = _db.Personel.Where(x => x.Mail == txtUser.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (personel !=null)
            {
                PersonelMissionForms.FrmPersonelForm fr = new PersonelMissionForms.FrmPersonelForm();
                fr.mail = txtUser.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
