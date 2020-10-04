using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.RegularExpressions;
using Windows.Devices.Usb;

namespace MoneyConvert
{
    //Класс принимает данные из обработчика событий, парсит информацию с сайта и возращает результат 
    class CostCalculation
    {
        //сумма введеная пользователем и данные о расчитываемых валютах
        private double sum;
        public string firstValute = "AUD";
        private string secondValute;

        public CostCalculation(double sum, string firstValute, string secondValute)
        {
            this.sum = sum;
            this.firstValute = firstValute;
            this.secondValute = secondValute;
        }

        public string Calculate()
        {
            
            var webClient = new System.Net.WebClient();
            string json = webClient.DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");
            JObject o = JObject.Parse(json);

            var value = (string)o["Valute"][firstValute]["Value"];
            
            string a = "Result";
            return a;
        }


    }
}
