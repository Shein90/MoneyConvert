using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        ObservableCollection<ValuteElement> Elements { set; get; }

        // Для информации о вызывающем элем. упр-я  
        private string HyperLinkInfo { set; get; }

        // Для связи с блоками отображения валют на главном экране
        public static string FirstValutInfo { set; get; } = "-";
        public static string SecondValutInfo { set; get; } = "-";

        public MoneyChoice()
        {
            this.InitializeComponent();

            Elements = new ObservableCollection<ValuteElement>
            {
                new ValuteElement {ID = "PLN", ValuteName = "Польский злотый"},
                new ValuteElement {ID = "CZK", ValuteName = "Чешская крона"},
                new ValuteElement {ID = "EUR", ValuteName = "Евро"},
                new ValuteElement {ID = "USD", ValuteName = "Доллар США"}
            };

        }

        // Обработчик выбора элемента
        private void ValuteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ValuteElement valute = ValuteList.SelectedItem as ValuteElement;

           if (HyperLinkInfo == "FirstVal")
            {
                FirstValutInfo = valute.ID;
            }
            else
            {
                SecondValutInfo = valute.ID;
            }
        }

        // Получаем информацию о вызывающем
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HyperLinkInfo = e.Parameter.ToString();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
