using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;

namespace KHCARDFLIP
{
    public partial class Kelson_sCardFlip : ContentPage
    {
        public Kelson_sCardFlip()
        {
            InitializeComponent();
        }

        void ButtonFlipCard_Clicked(System.Object sender, System.EventArgs e)
        {
            Button selectedButton = (Button)sender;
            if (selectedButton.Text == "Show Card Face")
            {
                ButtonFlipCard.Text = "Show Card Back";
                AceFrontCardImage.IsVisible = true;
                AceBackCardImage.IsVisible = false;
            } else
            {
                ButtonFlipCard.Text = "Show Card Face";
                AceBackCardImage.IsVisible = true;
                AceFrontCardImage.IsVisible = false;
            }
        }
    }
}
