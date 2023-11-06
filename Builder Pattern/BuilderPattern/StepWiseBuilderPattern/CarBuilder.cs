using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.StepWiseBuilderPattern
{
    public class CarBuilder
    {
        public class Builder : ICarNameBuilder, ICarWheelBuilder
        {
            protected Car car = new Car();
            public ICarWheelBuilder AddName(string name)
            {
                car.Name = name;
                return this;
            }

            public Car AddWheels(int size)
            {
                car.WheelSize = size;
                return car;
            }
        }

        public ICarNameBuilder Build()
        {
            return new Builder();
        }
    }
}
