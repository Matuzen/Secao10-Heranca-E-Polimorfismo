using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmployee.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AddditionalCharge { get; set; }
        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double addditionalCharge ) 
            : base (name, hours, valuePerHour)
        {
            AddditionalCharge = addditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddditionalCharge ;
        }

    }
}
