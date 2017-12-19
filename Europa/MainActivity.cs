using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Europa
{
    [Activity(Label = "Europa", MainLauncher = true)]
    public class MainActivity : Activity
    {
        DateTime MStart = new DateTime(2018, 1, 16);
        DateTime CDStop = new DateTime(2017, 12, 23);
        DateTime today = DateTime.Now;
        TextView CDown;
        TextView MScount;
        private int MScalc()
        {
            int result = (today - MStart).Days;
            if (result < 0)
            {
                result--;
            }
            else if (result > 0)
            {
                result++;
            }
            return result;
        }
        private int CDcalc()
        {
            int result = (today - CDStop).Days + 1;
            if (result < 0)
            {
                result--;
            }
            else if (result > 0)
            {
                result++;
            }
            return result;
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            MScount = FindViewById<TextView>(Resource.Id.MScount);
            CDown = FindViewById<TextView>(Resource.Id.CDown);
            MScount.Text = MScalc().ToString();
            CDown.Text = CDcalc().ToString();
        }
    }
}

