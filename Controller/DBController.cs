using System;
using System.Collections.Generic;
using System.Linq;
using TestSiteApp.Model;

namespace TestSiteApp.Controller
{
    class DBController : IDisposable
    {
        ContextDB DB;
        public List<Site> GetSites { get { return DB.Sites.ToList(); } }

        public DBController()
        {
            DB = new ContextDB();
        }

        public void InsertInto(Site site)
        {
            DB.Sites.Add(site);
            DB.SaveChangesAsync();
        }
        public void Delete(params Site[] sites)
        {
            foreach (var site in sites)
            {
                DB.Sites.Remove(site);
            }
            DB.SaveChangesAsync();
        }
        public void Update<T>(int id, ParametrName parametrName, T parametr)
        {
            switch (parametrName)
            {
                case ParametrName.Name:
                    DB.Sites.FirstOrDefault(s => s.ID == id).Name = parametr.ToString();
                    break;
                case ParametrName.URL:
                    DB.Sites.FirstOrDefault(s => s.ID == id).URL = parametr.ToString();
                    break;
                case ParametrName.TimeInterval:
                    DB.Sites.FirstOrDefault(s => s.ID == id).ms_TimeInterval = Convert.ToInt32(parametr);
                    break;
            }
        }

        public void Dispose()
        {
        }
    }
}
