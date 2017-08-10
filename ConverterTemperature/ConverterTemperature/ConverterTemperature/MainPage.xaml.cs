using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConverterTemperature
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            converterButton.Clicked += ConverterButton_Clicked;
        }

        private void ConverterButton_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(centigradeEntry.Text))
            {
                DisplayAlert("Error", "¡You must enter a value in  Centigrade grades!", "Accept");
                return;
            }

            double centigrade = 0;

            if(!double.TryParse(centigradeEntry.Text,out centigrade))

            {
                DisplayAlert("Error", "¡You must enter a value numeric in  Centigrade grades!", "Accept");
                centigradeEntry.Text = null;
                return;
            }

            var fahrenheit = (centigrade*1.8)+32;
            fahrenheitEntry.Text= fahrenheit.ToString();
        }
    }
}
