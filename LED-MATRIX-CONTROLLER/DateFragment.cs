using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace LEDMATRIXCONTROLLER
{
    public class DateFragment : Fragment , DatePickerDialog.IOnDateSetListener
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.Settings, container, false);
            view.FindViewById<ImageButton>(Resource.Id.btn_select_date).Click += delegate
            {
                var dialog = new DatePickerDialogFragment(Activity, DateTime.Now, this);
                dialog.Show(FragmentManager, null);
            };
            return view;
        }

        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            var date = new DateTime(year, monthOfYear + 1, dayOfMonth);
            View.FindViewById<TextView>(Resource.Id.edit_text_date).Text =  date.ToString("yyyy/MM/dd");
        }
    }
}