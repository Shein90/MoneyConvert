﻿using Newtonsoft.Json.Linq;
using System.Net;

namespace MoneyConvert
{
    //Класс принимает данные из обработчика событий, парсит информацию с сайта и возращает результат 
    class CostCalculation
    {
        //сумма введеная пользователем и данные о расчитываемых валютах

        private double firstCost;
        private double secondCost;

        string json;
        JObject o;

        public CostCalculation()
        {
            var webClient = new WebClient();
            json = webClient.DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");
            o = JObject.Parse(json);
        }

        // расчёт стоимости из одной валюты в другую через получаемую стоимость валют в рублях в рублях.
        public string Calculate(double sum, string firstValute, string secondValute)
        {
            // определяем коэфициент с учетом наминала валюты
            firstCost =  (double)o["Valute"][firstValute]["Value"]  / (double)o["Valute"][firstValute]["Nominal"];
            secondCost = (double)o["Valute"][secondValute]["Value"] / (double)o["Valute"][secondValute]["Nominal"];

            return (firstCost / secondCost * sum).ToString("{0:f4}");
        }


    }
}
