using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSiteApp.Model;

namespace TestSiteApp.Controller
{
    public class AppController
    {
        public List<Task> Tasks { get; set; }
        List<Site> Sites;
        public AppController()
        {
            using (var db = new DBController())
            {
                Sites = db.GetSites;
            }

            foreach (var site in Sites)
            {
                StartThread(site);
            }
        }

        public void AddResultColumn(ref DataGridView view)
        {
            DataGridViewColumn boolColumn = new DataGridViewCheckBoxColumn();
            boolColumn.HeaderText = "Result";
            boolColumn.Name = "Result";

            view.Columns.Add(boolColumn);
        }
        private void StartThread(Site site)
        {
            Task<Tuple<Site,bool>> task = new Task<Tuple<Site, bool>>(() =>
            {
                Thread.Sleep(site.ms_TimeInterval);
                return new Tuple<Site, bool>(site, testSite(site.URL));
            });
            task.Start();
            Tasks.Add(task);
        }
        private bool testSite(string url)
        {
            Uri uri = new Uri(url);
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
