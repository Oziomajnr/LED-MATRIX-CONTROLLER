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
using Square.TimesSquare;

namespace LEDMATRIXCONTROLLER
{
    [Activity(Label = "SettingsActivity", MainLauncher = false, Icon = "@mipmap/icon")]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var fragTx = FragmentManager.BeginTransaction();
            var frag = new DateFragment();
            fragTx.Add(Resource.Id.relativeLayout1, frag);
            fragTx.Commit();
            // Create your application here
            SetContentView(Resource.Layout.Settings);
            
            //DatePicker date_picker = FindViewById<DatePicker>(Resource.Id.date_picker);
            //date_picker.SpinnersShown = true;
            //date_picker.CalendarViewShown = false;



        }
    }
}