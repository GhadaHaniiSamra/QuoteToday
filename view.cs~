
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
using Android.Preferences;
namespace QuoteToday
{
	[Activity(Label = "view",Theme = "@android:style/Theme.DeviceDefault.NoActionBar.Fullscreen")]
	public class view : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.viewquote);
			TextView txt = FindViewById<TextView>(Resource.Id.txtquote);
			TextView txta = FindViewById<TextView>(Resource.Id.txtauthor);
			ISharedPreferences pre = PreferenceManager.GetDefaultSharedPreferences(this);
			txt.Text=	pre.GetString("quote", string.Empty);
			txta.Text=pre.GetString("author", string.Empty);
			// Create your application here
		}
	}
}

