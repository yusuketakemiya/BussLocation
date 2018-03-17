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
using BussLocate.Models;

namespace BussLocate
{
    public class Manager
    {
        public static List<BussLocation> Locations { get; set; }
        public static void Load()
        {
            Manager.Locations = new List<BussLocation>();
            Manager.Locations.Add(new BussLocation("土支田一丁目", "光が丘駅", DateTime.Now));
        }

        public static void Add(BussLocation location)
        {
            Manager.Locations.Add(location);
        }
    }
}