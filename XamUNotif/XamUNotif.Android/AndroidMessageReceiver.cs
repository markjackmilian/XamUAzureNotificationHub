﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamUNotif;
<<<<<<< HEAD

namespace XamUNotif.Droid
{
=======
using Xamarin.Forms;
using XamUNotif.Droid;

[assembly: Dependency(typeof(AndroidMessageReceiver))]
namespace XamUNotif.Droid
{
	
>>>>>>> refs/heads/test-android
	public class AndroidMessageReceiver : IMessageReceiver
	{
		public event EventHandler<string> MessageReceived;
	}
}