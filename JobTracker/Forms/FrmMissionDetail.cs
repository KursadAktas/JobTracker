using JobTracker.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker.Forms
{
    public partial class FrmMissionDetail : Form
    {
        public FrmMissionDetail()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        private void FrmMissionDetail_Load(object sender, EventArgs e)
        {
            _db.MissionDetails.Load();
            bindingSource1.DataSource = _db.MissionDetails.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            _db.SaveChanges();
        }
    }
}
