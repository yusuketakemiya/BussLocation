using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HtmlAgilityPack;

namespace BussLocate.Models
{
    public class BussLocation
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public DateTime DateTime { get; private set; }
        public string Text
        {
            get
            {
                return this.From + " >> " + this.To;
            }
        } 

        public string Name { get; private set; }

        public BussLocation(string fromStop, string toStop, DateTime dateTime)
        {
            this.From = fromStop;
            this.To = toStop;
            this.DateTime = dateTime;
        }

        public void Load()
        {
            //Webからデータ取得
            //とりあえず西部バス固定
            var url = "http://html-agility-pack.net/";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var nodes = doc.DocumentNode.Descendants("input")
                .Select(y => y.Descendants()
                .Where(x => x.Attributes["class"].Value == "box"))
                .ToList();

            this.Name = nodes.First().First().Name;

        }
    }
}