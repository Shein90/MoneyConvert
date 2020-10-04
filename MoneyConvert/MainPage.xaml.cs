using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MoneyConvert
{
    public sealed partial class MainPage : Page
    {
        // для сохранения введенного пользовательского значения
        public static string UserValue { set; get; } = "";

        public MainPage()
        {
            this.InitializeComponent();
        }

        // Обработчики выбора валюты отправляют соответствующее сообщение классу MoneyChoice 
        private void HyperlinkButton_Click_FirstVal(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MoneyChoice), "FirstVal");
        }

        private void HyperlinkButton_Click_SecondVal(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MoneyChoice), "SecondVal");
        }

        // Обработчик запуска расчётов
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FirstValue.Text))
                    throw new Exception("Вы не ввели значение!");
                if (!double.TryParse(FirstValue.Text, out double val))
                    throw new Exception("Это не число!");
                if (Fvalute.Text == "-" || Svalute.Text == "-")
                    throw new Exception("Вы не выбрали валюту!");
                    
                CostCalculation cost = new CostCalculation();
                Result.Text = cost.Calculate(Convert.ToDouble(FirstValue.Text), Fvalute.Text, Svalute.Text);
                Error.Text = "Готово!";
            }
            catch (Exception ex)
            {
                Error.Text = ex.Message;
                Result.Text = "";
            }

        }
    }
}
