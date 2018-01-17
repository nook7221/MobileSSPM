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
	public partial class InProcessProjectScreen : ContentPage
	{
        private Task Navigtion;

        public InProcessProjectScreen ()
		{
			InitializeComponent ();
            var addproject = new List<Addprojet>
            {
                new Addprojet
                {
                    id = 1,
                    Name = "หน้าแรก",
                    Detail = "OneProject"
                },
                   new Addprojet
                {
                    id = 2,
                    Name = "SeccondProject",
                    Detail = "TwoProject"
                },
                new Addprojet
                {
                    id = 3,
                    Name = "ThirdProject",
                    Detail = "ThreeProject"
                },
            };

            ProjectLists.ItemsSource = addproject;
            
        }
        private async void ProjectLists_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var addproject = e.Item as Addprojet;
            var page = new Dummy();
            NavigationPage.SetHasBackButton(page, false);
            await Navigation.PushAsync(page);
        }

        public async void ProjetLists_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dummy());
           /* await  DisplayAlert("Project Tapped",
                                   "Project : " + Addprojet.Name,
                                   "OK");*/
           }
    }

}