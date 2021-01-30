using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using TestSiteApp.Model;

namespace TestSiteApp.Controller
{
    delegate void TestPing(List<Tuple<Site,bool>> result);
    class ThreadController:IDisposable
    {
        public event TestPing UpdateDGV;
        private List<Site> Sites;
        List<Tuple<Site, bool>> results;
        public void Run(List<Site> sites)
        {
            Sites = sites;
            results = new List<Tuple<Site, bool>>();
            Thread thread = new Thread(StartThreads);
            thread.Start();
        }
        private void StartThreads()
        {
            foreach (var site in Sites)
            {
                WaitCallback callback = new WaitCallback(Pinging);
                ThreadPool.QueueUserWorkItem(callback, site);
            }
        }
        private void Pinging(object obj)
        {
            while(true)
                GetPing(obj);
        }
        private void GetPing(object obj)
        {
            Site site = (Site)obj;
            bool PingStatys = false;
            try
            {
                Ping ping = new Ping();
                PingReply Statys = ping.Send(site.URL);

                PingStatys = (Statys.Status == IPStatus.Success);
            }
            catch { }
            GetResult(new Tuple<Site, bool>(site, PingStatys));
            Thread.Sleep(site.ms_TimeInterval);
        }
        private void GetResult(Tuple<Site,bool> result)
        {
            if(results.Count>=0)
            {
                int id = results.FindIndex(res => res.Item1.ID == result.Item1.ID);
                if(id>=0)
                    results[id] = result;
                else
                    results.Add(result);

                UpdateDGV(results);
                return;
            }
            results.Add(result);
            UpdateDGV(results);
        }
        public void Dispose()
        {
        }
    }
}
