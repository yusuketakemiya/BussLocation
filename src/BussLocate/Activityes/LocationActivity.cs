﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BussLocate.Activityes
{
    [Activity(Label = "LocationActivity")]
    public class LocationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Location);
            FindViewById<Button>(Resource.Id.ReturnMainButton).Click += (s, e) =>
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}