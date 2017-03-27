using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.Threading;
using Android.Net;

namespace QuoteToday
{
	[Activity(Label = "Quote Today", Icon = "@mipmap/quotes",Theme="@android:style/Theme.DeviceDefault.NoActionBar.Fullscreen")]
	public class MainActivity : Activity
	{
		int count = 1;
		Timer t;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			bool f1 = true;
			t=new Timer(delegate {
				
			
			Thread.Sleep(2000);
				ConnectivityManager connectivityManager = (ConnectivityManager)GetSystemService(ConnectivityService);
				NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
				bool isOnline = (activeConnection != null) && activeConnection.IsConnected;
				if (isOnline){
					StartActivity(typeof(list));
					t.Dispose();
				}else if(f1)
				{
					Toast.MakeText(this, "Check your internet connection", ToastLength.Short).Show();
					f1 = !f1;
				}
			});
			t.Change(200, 200);
			    
			// Get our button from the layout resource,
			// and attach an event to it


		}
	}
}


