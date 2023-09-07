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
    public partial class FrmMissionList : Form
    {
        public FrmMissionList()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        private void gridControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmMissionList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in _db.Missions
                                       select new
                                       {

                                           x.Description
                                       }).ToList();
            lblAktifGorev.Text = _db.Missions.Where(x => x.Stituation == true).Count().ToString();
            lblPasifGorev.Text = _db.Missions.Where(x => x.Stituation == false).Count().ToString();
            lblToplamDepartman.Text = _db.Departments.Count().ToString();
            

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblPasifGorev.Text));
            //chartControl1.Series["Series 1"].Points.AddPoint("Yazılım", 34);
            //chartControl1.Series["Series 1"].Points.AddPoint("Muhasebe", 15);
            //chartControl1.Series["Series 1"].Points.AddPoint("İdari işler", 38);
            //chartControl1.Series["Series 1"].Points.AddPoint("Müdür", 21);
            //chartControl1.Series["Series 1"].Points.AddPoint("Müdür Yardımcısı", 33);
          
        }
    }
}
