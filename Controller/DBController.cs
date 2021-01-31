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
            if(GetSites.Count == 0)
            {
                TestValues();
            }
        }
        public void InsertInto(Site site)
        {
            DB.Sites.Add(site);
            DB.SaveChanges();
        }
        public void Delete(int idSites)
        {
            var site = DB.Sites.FirstOrDefault(s => s.ID == idSites);
            DB.Sites.Remove(site);
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
                    DB.Sites.FirstOrDefault(s => s.ID == id).ms_TimeInterval = Convert.ToInt32(parametr.ToString());
                    break;
            }
            DB.SaveChanges();
        }
        public void Dispose()
        {
        }
        private void TestValues()
        {
            List<Site> sites = new List<Site>()
            {
                new Site()
                {
                    Name="Яндекс",
                    URL="yandex.ru",
                    ms_TimeInterval=500
                },
                new Site()
                {
                    Name="Ян",
                    URL="yan123.ru",
                    ms_TimeInterval=500
                },
                new Site()
                {
                    Name="Google",
                    URL="www.google.ru",
                    ms_TimeInterval=1000
                },
                new Site()
                {
                    Name="Googleion",
                    URL="Googlion1.ru",
                    ms_TimeInterval=500
                },
                new Site()
                {
                    Name="Habr",
                    URL="habr.com",
                    ms_TimeInterval=500
                }
            };

            using (var db = new ContextDB())
            {
                db.Sites.AddRange(sites);
                db.SaveChanges();
            }
        }
    }
}
