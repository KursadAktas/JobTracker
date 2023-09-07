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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        
        
        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in _db.Missions select new
            {
               
                x.Description,
              AdSoyad =  x.Personel.Name + " "+ x.Personel.LastName,
              x.Stituation

            }).Where(y=> y.Stituation == true).ToList();
            gridView1.Columns["Stituation"].Visible = false;

            //bugün yapılan görevlerin detayları
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = ( from x in _db.MissionDetails select new
            {
               Mission = x.Missions.Description,
                x.Description,
                x.Date
            }).Where(y=>y.Date == today).ToList();

            //Aktil Çağrı Listesi
            gridControl3.DataSource = (from x in _db.Call select new
            {
                x.Companies.Name,
                x.Subject,
                x.Description,
                x.Situation
            }).Where(x => x.Situation == true).ToList();
            gridView3.Columns["Situation"].Visible=false;

            //Fihrist

            gridControl5.DataSource = (from x in _db.Companies select new
            {
                x.Name,
                x.Phone,
                x.Mail
            }).ToList();

            //Grafik

            int aktif_cagri = _db.Call.Where(x => x.Situation == true).Count();
            int pasif_cagri = _db.Call.Where(x => x.Situation == false).Count();



            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktif_cagri);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasif_cagri);
        }
    }
}
