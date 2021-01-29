using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSiteApp.Controller;

namespace TestSiteApp
{
    public partial class SiteManitor : Form
    {
        AppController AppController;
        public SiteManitor()
        {
            InitializeComponent();
            AppController = new AppController();
            AppController.AddResultColumn(ref DGViewResult);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
        }
    }
}
