using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestSiteApp.Model;

namespace TestSiteApp.Controller
{
    public class AppController:IDisposable
    {
        public List<Site> Sites { get; private set; }
        int CountSite { get { return Sites.Count; } }
        DataGridView DGV;
        ThreadController threadController;
        public AppController()
        {
            LoadDB();
            threadController = new ThreadController();
            threadController.Run(Sites);

            threadController.UpdateDGV+=new TestPing(Tick);
        }
        public void LoadDB()
        {
            using (var db = new DBController())
            {
                Sites = db.GetSites;
            }
        }
        public void AddResultColumn(ref DataGridView view)
        {
            DGV = view;
            DataGridViewColumn boolColumn = new DataGridViewCheckBoxColumn();
            boolColumn.HeaderText = "Result";
            boolColumn.Name = "Result";

            view.Columns.Add(boolColumn);
        }
        public void Tick(List<Tuple<Site, bool>> results)
        {
            try
            {
                if (results != null)
                {
                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        foreach (var result in results)
                        {
                            if (result != null)
                            {
                                if (row.Cells[0].Value.ToString() == result.Item1.ID.ToString())
                                {
                                    row.Cells["Result"].Value = result.Item2;
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }
        public void Dispose()
        {
            threadController.Dispose();
        }
    }
}
