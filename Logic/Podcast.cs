using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Timers;

namespace Logic
{
    public class Podcast
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public int Interval { get; set; }
        List<Podcast> pods = new List<Podcast>();
        Feed feed = new Feed();

        public void PodInfo(string name, string url, string category, int interval)
        {
            AddPod pod = new AddPod();
            System.Timers.Timer timer = new System.Timers.Timer(interval);
            timer.Elapsed += (timerSender, timerEvent) => UpdaterRemove(timerSender, timerEvent, name, url, category, interval);
            timer.Stop();
            var poddis = new Podcast()
            {
                Name = name,
                Url = url,
                Category = category,
                Interval = interval,
            };
            pod.AddNewPod(name, category, url, interval);
            pods.Add(poddis);
            timer.Start();
        }

        public async void UpdaterRemove(object source, ElapsedEventArgs e, string name, string url, string category, int interval)
        {
            feed.Remove(category, name);
            await UpdaterAdd(name, url, category, interval);
        }

        public Task UpdaterAdd(string name, string url, string category, int interval)
        {
            return Task.Factory.StartNew(() =>
            {
                PodInfo(name, url, category, interval);
            });


        }

        public string getPodUrl(string name)
        {
            var query = from q in pods
                        where q.Name == name
                        select q.Url;

            string qstring = query.Single().ToString();
            return qstring;
        }
    }
}

