using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MoneyConvert
{
    public sealed partial class LoadPage : Page
    {
        public LoadPage()
        {
            this.InitializeComponent();
            Thread.Sleep(500);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }



    }
}
