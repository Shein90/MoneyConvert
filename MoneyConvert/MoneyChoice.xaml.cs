using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class MoneyChoice : Page
    {
        public MoneyChoice()
        {
            this.InitializeComponent();
            
        }

        private void MoneyCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //обработчик выбора элемента
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Frame.CanGoBack)
            {
                // Frame.GoBack();
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
