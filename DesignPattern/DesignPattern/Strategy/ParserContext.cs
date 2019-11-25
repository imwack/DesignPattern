using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class ParserContext
    {
        private IStrategy strategy;

        public string Work()
        {
            return strategy.Work();
        }

        public ParserContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }


    }
}
