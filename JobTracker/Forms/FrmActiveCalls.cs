using DevExpress.Utils.Extensions;
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
    public partial class FrmActiveCalls : Form
    {
        public FrmActiveCalls()
        {
            InitializeComponent();
        }

        private void FrmActiveCalls_Load(object sender, EventArgs e)
        {
            DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
            var value = (from x in _db.Call select new
            {
                x.ID,
                x.Companies.Name,
                x.Companies.Phone,
                x.Subject,
                x.Description,
               isim =  x.Personel.Name,
                x.Situation
            }).Where(y=>y.Situation == true).ToList();
            gridControl1.DataSource = value;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCallAsign fr = new FrmCallAsign();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
