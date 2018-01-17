﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSPM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProjectDetail : ContentPage
	{
		public ProjectDetail ()
		{
			InitializeComponent ();
		}

        
        public async void button_Clicked(object Sender, EventArgs e)
        {
            var page = new LoginScreen();
            NavigationPage.SetHasBackButton(page, false);
            await Navigation.PushAsync(page);


        }

        
    }
}