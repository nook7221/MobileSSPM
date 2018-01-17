using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSPM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SuccessProjectScreen : ContentPage
	{
		public SuccessProjectScreen ()
		{
			InitializeComponent ();
            var ssproject = new List<string>();
            ssproject.Add("Project1");
            ssproject.Add("Project2");
            ssproject.Add("Project3");
            ssproject.Add("Project4");
            ssproject.Add("Project5");
            ssproject.Add("Project6");

            Successproject.ItemsSource = ssproject;
            
        }
        
	}
}