using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx.Entities {
    internal class Worker {

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Worker() { }
        public Worker(string name, int hours, double valuePerHour) {

            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;

        }
        public virtual double Payment() { 

            return Hours * ValuePerHour;

        }

    }
}
