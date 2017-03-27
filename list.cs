
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
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using Android.Preferences;
namespace QuoteToday
{
	[Activity(Label = "list",MainLauncher=true,Theme="@android:style/Theme.DeviceDefault.NoActionBar.Fullscreen" )]
	public class list : Activity
	{
			
		public static MobileServiceClient MobileService =
			new MobileServiceClient(
				"http://qoutes.azurewebsites.net"
			);
		protected override async void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.listquotes);
			ListView list = FindViewById<ListView>(Resource.Id.listView1);

			List<quotes>qu=	await MobileService.GetTable<quotes>().ToListAsync();

		//	var t = MobileService.GetTable<quotes>();
			//quotes q = new quotes();
		
		//	q.quote = "\"Be yourself; everyone else is already taken.\"";
		//	q.author = "Oscar Wilde";
		//	await t.InsertAsync(q);
	
		

			ArrayAdapter<quotes> ad = new ArrayAdapter<quotes>(this, Android.Resource.Layout.SimpleListItem1,qu );
			list.Adapter = ad;
			list.ItemClick += (sender, e) => 
			{
				PreferenceManager.GetDefaultSharedPreferences(this).Edit().PutString("quote", qu[e.Position].quote).Apply();
				PreferenceManager.GetDefaultSharedPreferences(this).Edit().PutString("author",qu[e.Position].author).Apply();
				StartActivity(typeof(view));
			};


		}
	}
	class quotes
	{
		public string Id { get; set; }

		public string quote { get; set; }
		public string author { get; set; }
		 public override string ToString()
		{
			return quote.Substring(1,20)+"...";
		}
	
	}
}

