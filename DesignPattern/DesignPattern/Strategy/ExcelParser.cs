using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class ExcelParser:IStrategy
    {
        public string Work()
        {
            return "Parser excel";
        }
    }
}
