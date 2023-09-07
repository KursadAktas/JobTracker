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
    public partial class FrmCallList : Form
    {
        public FrmCallList()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities1 _db = new DbJobTrackingEntities1();
        public string mail2;
        private void FrmCallList_Load(object sender, EventArgs e)
        {
            var personelId = _db.Personel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
            gridControl1.DataSource = (from x in _db.Call select new
            {
                x.Companies.Name,
                x.Companies.Phone,
                x.Companies.Mail,
                x.Description,
                x.Situation,
                x.PersonelID,
                x.ID
            }).Where(y=>y.Situation==true && y.PersonelID ==personelId).ToList();
            gridView1.Columns["Situation"].Visible = false;
            gridView1.Columns["PersonelID"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCallDetailsEntered fr = new FrmCallDetailsEntered();
            fr.id =int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
