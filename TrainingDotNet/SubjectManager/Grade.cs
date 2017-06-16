using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectManager
{
    public class Grade
    {

        private double value;
        private double percent;

        public Grade(double value, double porcent)
        {
            this.value = value;
            this.percent = porcent;
        }

        public double Value { get => value; set => this.value = value; }
        public double Porcent { get => percent; set => percent = value; }
    }
}
