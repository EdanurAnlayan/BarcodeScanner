using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace BarcodeScanner
{
    public partial class MainPage : ContentPage
    {
        ZXingScannerPage scanpage;
        public MainPage()
        {
            InitializeComponent();
        }
        private async void scannerButton_Clicked(object sender, EventArgs e)
        {
            scanpage = new ZXingScannerPage();
            scanpage.OnScanResult += (result) =>
            {
                scanpage.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    DisplayAlert("Scanned Barkod", result.Text, "Ok");
                });
            };
            await Navigation.PushModalAsync(scanpage);
        }
    }
}
