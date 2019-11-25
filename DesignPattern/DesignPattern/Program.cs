using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;

namespace DesignPattern
{
    class Program
    {
        public static void TestStrategyPattern()
        {
            //Implement stratedy with different and use it with context
            ParserContext context = new ParserContext(new TextParser());
            Console.WriteLine(context.Work());
            context = new ParserContext(new ExcelParser());
            Console.WriteLine(context.Work());
        }
        static void Main(string[] args)
        {
            TestStrategyPattern();
        }
    }
}
