using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConvert
{
    //Класс принимает данные из обработчика событий, парсит информацию с сайта и возращает результат 
    class CostCalculation
    {
        //сумма введеная пользователем и данные о расчитываемых валютах
        private double sum;
        private string firstValute;
        private string secondValute;

        public CostCalculation(double sum, string firstValute, string secondValute)
        {
            this.sum = sum;
            this.firstValute = firstValute;
            this.secondValute = secondValute;
        }

        public string Calculate()
        {
            string a = "Hello123";
            return a;
        }


    }
}
