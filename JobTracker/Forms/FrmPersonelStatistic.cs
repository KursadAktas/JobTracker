using DevExpress.Data.WcfLinq.Helpers;
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
    public partial class FrmPersonelStatistic : Form
    {
        public FrmPersonelStatistic()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        private void FrmPersonelStatistic_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = _db.Departments.Count().ToString();
            lblToplamFirma.Text = _db.Companies.Count().ToString(); 
            lblToplamPersonel.Text=_db.Personel.Count().ToString();
            lblAktifIs.Text=_db.Missions.Count(x=>x.Stituation == true).ToString();
            lblPasifIs.Text=_db.Missions.Count(x=>x.Stituation == false).ToString();
            lblSonGorev.Text= _db.Missions.OrderByDescending(x=>x.ID).Select(x=>x.Description).FirstOrDefault();
            lblSehir.Text = _db.Companies.Select(x=> x.City).Distinct().Count().ToString(); // distinct aynı değerleri tek sayıyor
            lblSektor.Text = _db.Companies.Select(x=>x.Sektor).Distinct().Count().ToString();
            DateTime today = DateTime.Today;
            lblBugunkuGorev.Text = _db.Missions.Count(x=>x.Tarih == today).ToString();
           var value = _db.Missions.GroupBy(x=>x.Responsible).OrderByDescending(z=>z.Count()).Select(y=>y.Key).FirstOrDefault();
            lblAyinPers.Text = _db.Personel.Where(x=>x.ID == value).Select(y=>y.Name +" "+ y.LastName).FirstOrDefault().ToString();

            lblAyinDepartmani.Text= _db.Departments.Where(x=>x.ID == _db.Personel.Where(t=>t.ID == value).Select(z=>z.Department).FirstOrDefault()).Select(y=>y.Name).FirstOrDefault().ToString();

            lblSon.Text = _db.Missions.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
        }

    }
}
