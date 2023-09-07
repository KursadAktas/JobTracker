using DevExpress.XtraGrid;
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
    public partial class FrmPassiveMissions : Form
    {
        public FrmPassiveMissions()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        public string mail2;
        private void FrmPassiveMissions_Load(object sender, EventArgs e)
        {
            var personelId = _db.Personel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
            var value = (from x in _db.Missions
                         select new
                         {
                             x.ID,
                             x.Description,
                             x.Tarih,
                             x.Assignor,
                             x.Stituation
                         }).Where(x => x.Assignor == personelId && x.Stituation == false).ToList();

            gridControl1.DataSource = value;
            gridView1.Columns["Assignor"].Visible = false;
            gridView1.Columns["Stituation"].Visible = false;

        }
    }
}
