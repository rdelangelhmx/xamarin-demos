#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfProgressBar
{
	public partial class App : Application
	{
        [Preserve(AllMembers = true)]
        public App ()
		{
			InitializeComponent();

            var page = SampleBrowser.Core.SampleBrowser.GetMainPage("SfProgressBar", "SampleBrowser.SfProgressBar");
            MainPage = page;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
