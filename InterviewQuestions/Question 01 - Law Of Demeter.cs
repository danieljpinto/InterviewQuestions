using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Add code into the GetEngineManufacturer method so that it gets the name of a car's engine. In this example please BREAK demeters law.
    /// It is expected that the car class will have to have an engine property added to it.
    /// </summary>
    public class Question1
    {
        public string GetEngineManufacturer()
        {
            var car = new Car();
            return car.Engine.Manufacturer;
        }

        private class Car
        {
            public Engine Engine { get; set; }
        }

        private class Engine
        {
            public string Make { get; set; }

            public string Manufacturer { get; set; }
        }
    }
}
