using Android.App;
using Android.Widget;
using Android.OS;
using BussLocate.Activityes;

namespace BussLocate
{
    [Activity(Label = "BussLocate", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.LocationActiveButton).Click += (s, e) =>
            {
                StartActivity(typeof(LocationActivity));
            };
        }
    }
}

