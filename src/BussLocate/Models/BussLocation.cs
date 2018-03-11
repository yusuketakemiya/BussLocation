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

namespace BussLocate.Models
{
    public class BussLocation
    {
        public string From { get; private set; }
        public string To { get; private set; }

        public BussLocation(string fromStop, string toStop)
        {
            this.From = fromStop;
            this.To = toStop;
        }

        public void Load()
        {
            //Webからデータ取得
            //とりあえず西部バス固定

        }
    }
}