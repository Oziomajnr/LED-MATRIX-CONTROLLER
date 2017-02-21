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
    [Activity(Label = "SettingsActivity", MainLauncher = true, Icon = "@mipmap/icon")]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Settings);

            //DatePicker date_picker = FindViewById<DatePicker>(Resource.Id.date_picker);
            //date_picker.SpinnersShown = true;
            //date_picker.CalendarViewShown = false;

           

        }
    }
}