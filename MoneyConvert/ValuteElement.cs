using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConvert
{
    class ValuteElement
    {
        public string ID { set; get; }
        public string ValuteName { set; get; }
        public bool IsFirstOperand { set; get; } = false;
    }
}
