using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Views.Animations;

namespace LEDMATRIXCONTROLLER
{
	[Activity (Label = "LED-MATRIX-CONTROLLER", MainLauncher = true, Icon = "@mipmap/icon",ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{
        Android.App.ProgressDialog progress;

        protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
            ImageButton img_btn_refresh = FindViewById<ImageButton>(Resource.Id.img_btn_refresh);
            var rotateAboutCenterAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.rotate_center);

            img_btn_refresh.Click += delegate
            {

                img_btn_refresh.StartAnimation(rotateAboutCenterAnimation);
                
            };
            // Get our button from the layout resource
            // and attach an event to it
            Button button = FindViewById<Button> (Resource.Id.connect_button);
           
			    button.Click += delegate {

                progress = new Android.App.ProgressDialog(this);
                progress.Indeterminate = true;
                progress.SetProgressStyle(ProgressDialogStyle.Spinner);
                progress.SetMessage("Connecting");
                progress.SetCancelable(true);
                progress.SetTitle("Bleutooth");
                progress.Show();
            };
		}
       
    }
}


