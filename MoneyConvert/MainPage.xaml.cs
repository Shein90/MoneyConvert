﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using System.Threading;
using System.Timers;
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
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click_FirstVal(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MoneyChoice), "FirstVal");
        }

        private void HyperlinkButton_Click_SecondVal(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MoneyChoice), "SecondVal");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadBar.IsActive = true;
            //вызывает метод
            if (!string.IsNullOrEmpty(FirstValue.Text))
            {
                CostCalculation cost = new CostCalculation(Convert.ToDouble(FirstValue.Text), Fvalute.Text, Svalute.Text);
                Result.Text = cost.Calculate();
            }
        }
    }
}
