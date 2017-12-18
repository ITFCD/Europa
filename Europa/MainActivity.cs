using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Europa
{
    [Activity(Label = "Europa", MainLauncher = true)]
    public class MainActivity : Activity
    {
        DateTime startDate = new DateTime(2018, 1, 16);
        DateTime today = DateTime.Now;
        private int calc()
        {
            return (startDate - today).Days;
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

