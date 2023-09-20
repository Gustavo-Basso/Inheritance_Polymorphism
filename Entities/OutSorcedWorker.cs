using System;
using System.Text.RegularExpressions;

namespace InheritanceEx.Entities {
    internal class OutSorcedWorker : Worker{
    
    
        public double Additional {get;set;}
        
        public OutSorcedWorker(string name, int hour, double valuePerHour, double additional)
            :base(name, hour, valuePerHour ) { 
            
            Additional = additional;
        }
        
        
        public override double Payment() {
            
            return base.Payment() + Additional * 1.1;
        }


    }
}
