using System;
using System.Windows.Forms;
using TestSiteApp.Controller;
using TestSiteApp.Model;

namespace TestSiteApp
{
    public partial class SiteManitor : Form
    {
        AppController AppController;
        public SiteManitor()
        {
            InitializeComponent();
            AppController = new AppController();
            DGViewUpdate.DataSource = AppController.Sites;
            DGViewResult.DataSource = AppController.Sites;
            LoadData();
            AppController.AddResultColumn(ref DGViewResult);
        }       
        private void butSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBController())
            {
                Site site = AppController.Sites.Find(s => s.ID.ToString() == cBoxID.Text);
                if (site.Name != tBoxName.Text)
                    db.Update(Convert.ToInt32(cBoxID.Text), ParametrName.Name, tBoxName.Text);
                if (site.URL != tBoxUrl.Text)
                    db.Update(Convert.ToInt32(cBoxID.Text), ParametrName.URL, tBoxUrl.Text);
                if (site.ms_TimeInterval.ToString() != tBoxInterval.Text)
                    db.Update(Convert.ToInt32(cBoxID.Text), ParametrName.TimeInterval, tBoxInterval.Text);
            }

            LoadData();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            Site site = new Model.Site()
            {
                Name = tBoxName.Text,
                URL = tBoxUrl.Text,
                ms_TimeInterval = Convert.ToInt32(tBoxInterval.Text)
            };
            AppController.AddSite(site);

            using (var db = new DBController())
            {
                for (int i = 0; i < DGViewUpdate.Rows.Count - 1; i++)
                {
                    db.InsertInto(site);
                }
            }
            LoadData();
        }
        private void butDel_Click(object sender, EventArgs e)
        {
            using (var db = new DBController())
            {
                db.Delete(Convert.ToInt32(cBoxID.Text));
            }
            LoadData();
        }
        private void LoadData()
        {
            AppController.LoadDB();
            DGViewResult.DataSource = AppController.Sites;
            DGViewUpdate.DataSource = AppController.Sites;
        }
        private void _Selected(object sender, EventArgs e)
        {
            rButAdd.Checked = true;
            cBoxID.Items.Clear();
            foreach (var site in AppController.Sites)
            {
                cBoxID.Items.Add(site.ID);
            }
        }
        private void rButAddChecked(object sender, EventArgs e)
        {
            butAdd.Enabled = true;
            butDel.Enabled = false;
            butSave.Enabled = false;
            cBoxID.Enabled = false;
            cBoxID.Text = "";
            tBoxInterval.Enabled = true;
            tBoxInterval.Text = "";
            tBoxName.Enabled = true;
            tBoxName.Text = "";
            tBoxUrl.Enabled = true;
            tBoxUrl.Text = "";
        }
        private void rButUpdateChecked(object sender, EventArgs e)
        {
            butAdd.Enabled = false;
            butDel.Enabled = false;
            butSave.Enabled = true;
            cBoxID.Enabled = true;
            cBoxID.Text = "";
            tBoxInterval.Enabled = true;
            tBoxInterval.Text = "";
            tBoxName.Enabled = true;
            tBoxName.Text = "";
            tBoxUrl.Enabled = true;
            tBoxUrl.Text = "";
        }
        private void rButDelChecked(object sender, EventArgs e)
        {
            butAdd.Enabled = false;
            butDel.Enabled = true;
            butSave.Enabled = false;
            cBoxID.Enabled = true;
            cBoxID.Text = "";
            tBoxInterval.Enabled = false;
            tBoxInterval.Text = "";
            tBoxName.Enabled = false;
            tBoxName.Text = "";
            tBoxUrl.Enabled = false;
            tBoxUrl.Text = "";
        }
        private void cBoxChangedText(object sender, EventArgs e)
        {
            var index = cBoxID.Text;
            foreach (DataGridViewRow row in DGViewUpdate.Rows)
            {
                if(row.Cells[0].Value.ToString() == index)
                {
                    tBoxName.Text = row.Cells[1].Value.ToString();
                    tBoxUrl.Text = row.Cells[2].Value.ToString();
                    tBoxInterval.Text = row.Cells[3].Value.ToString();
                }
            }
        }
        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            AppController.Dispose();
            Application.Exit();
        }
    }
}
