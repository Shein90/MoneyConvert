using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MoneyConvert
{
    public sealed partial class MainPage : Page
    {
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

            //    LoadBar.IsActive = true;
                CostCalculation cost = new CostCalculation();
                Result.Text = cost.Calculate(Convert.ToDouble(FirstValue.Text), Fvalute.Text, Svalute.Text);
            }
            // Проверить на наличие ошибок!
            catch (Exception ex)
            {
                Error.Text = ex.Message;
            }

        }
    }
}
