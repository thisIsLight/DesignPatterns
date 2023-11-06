using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.StepWiseBuilderPattern
{
    public interface ICarNameBuilder
    {
        public ICarWheelBuilder AddName(string name);
    }
}
