using Android.App;
using Android.Widget;
using Android.OS;

namespace LEDMATRIXCONTROLLER
{
	[Activity (Label = "LED-MATRIX-CONTROLLER", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
        Android.App.ProgressDialog progress;

        protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.connect_button);
			
			button.Click += delegate {

                progress = new Android.App.ProgressDialog(this);
                progress.Indeterminate = true;
                progress.SetProgressStyle(Android.App.ProgressDialogStyle.Horizontal);
                progress.SetMessage("Connecting");
                progress.SetCancelable(true);
                progress.Show();
            };
		}
	}
}


