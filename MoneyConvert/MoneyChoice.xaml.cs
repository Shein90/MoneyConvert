using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
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
                new ValuteElement {ID = "USD", ValuteName = "Доллар США"},
                new ValuteElement {ID = "DKK", ValuteName = "Датская крона"},
                new ValuteElement {ID = "CAD", ValuteName = "Канадский доллар"},
                new ValuteElement {ID = "JPY", ValuteName = "Японский иен"},
                new ValuteElement {ID = "SEK", ValuteName = "Шведская крона"},
                new ValuteElement {ID = "NOK", ValuteName = "Норвежская крона"},
                new ValuteElement {ID = "RUB", ValuteName = "Российский рубль"}
            };
        }

        // Обработчик выбора элемента
        private void ValuteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ValuteElement valute = ValuteList.SelectedItem as ValuteElement;

           if (HyperLinkInfo == "FirstVal")
            {
                FirstValutInfo = valute.ID;
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                SecondValutInfo = valute.ID;
                Frame.Navigate(typeof(MainPage));
            }
        }

        // Получаем информацию о вызывающем контролере
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HyperLinkInfo = e.Parameter.ToString();
        }
    }
}
