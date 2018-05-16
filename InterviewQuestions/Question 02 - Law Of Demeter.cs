﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Add code into the GetEngineManufacturer method so that it gets the name of a car's engine. In this example please ADHERE to demeters law.
    /// It is expected that the car class will have to have an engine property added to it.
    /// </summary>
    public class Question2
    {
        public string GetEngineManufacturer()
        {
            var car = new Car();
            return car.GetEngineManufacturer();
        }

        private class Car
        {
            private Engine _engine;

            public string GetEngineManufacturer()
            {
                return _engine.Manufacturer;
            }
        }

        private class Engine
        {
            public string Make { get; set; }

            public string Manufacturer { get; set; }
        }
    }
}
