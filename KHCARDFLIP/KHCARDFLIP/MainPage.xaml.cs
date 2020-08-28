using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KHCARDFLIP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ClickToGoToPageTwoButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Kelson_sCardFlip());
        }
    }
}
