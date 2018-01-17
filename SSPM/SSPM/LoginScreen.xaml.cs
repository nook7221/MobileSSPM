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
	public partial class LoginScreen : ContentPage
	{
		public LoginScreen ()
		{
			InitializeComponent ();
		}
        public async void button_Clicked(object Sender, EventArgs e)
        {
            string username = Mainuser.Text;
            string pass = Mainpassword.Text;

            var action = await DisplayAlert("Notification", "คุณต้องการเข้าสู่ระบบใช่หรือไม่", "YES", "NO");
            if (action)
            {
                if (username == "qwer" && pass == "qwer")
                {
                    var page = new TabbedPage
                    {
                        BackgroundColor = Color.FromHex("#F5F3F6"),
                        Children =
                        {
                            new InProcessProjectScreen(),
                            new SuccessProjectScreen(),
                            new EtcProject()
                        }

                    };


                    NavigationPage.SetHasBackButton(page, false);
                    await Navigation.PushAsync(page);
                }
                else
                {
                    await DisplayAlert("Notification", "เข้าสู่ระบบล้มเหลว! Username หรือ Password ผิด", "Cancle");
                }

            }
            else
            {
                return;
            }
        }

    }
    }
