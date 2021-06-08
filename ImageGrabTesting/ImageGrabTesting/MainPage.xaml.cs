using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;

namespace ImageGrabTesting
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
            
            var byteArray = await new WebClient().DownloadDataTaskAsync("http://10.0.2.2:1234/BaconBurger.jpg");

            resultImage.Source = ImageSource.FromStream(() => new MemoryStream(byteArray));
        }


    }
}
