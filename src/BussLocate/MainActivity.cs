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
            Manager.Load();

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            foreach (var location in Manager.Locations)
            {
                // ボタンの設定
                Button button = new Button(this);
                button.Text = location.Text;
                button.Click += (s, e) =>
                {
                    StartActivity(typeof(LocationActivity));
                };
                layout.addView(button);
            }

            //FindViewById<Button>(Resource.Id.LocationActiveButton).Click += (s, e) =>
            //{
            //    StartActivity(typeof(LocationActivity));
            //};
            FindViewById<Button>(Resource.Id.LocationAddButton).Click += (s, e) =>
            {
                //Manager.Add();
            };
        }
    }
}

