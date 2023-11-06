using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.StepWiseBuilderPattern
{
    public interface ICarWheelBuilder
    {
        public Car AddWheels(int size); 
    }
}
