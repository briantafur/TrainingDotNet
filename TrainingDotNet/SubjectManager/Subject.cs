using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectManager
{
    public class Subject
    {

        private short code;
        private String name;
        LinkedList<Grade> grades;

        public Subject(short code, String name)
        {
            this.code = code;
            this.name = name;
            grades = new LinkedList<Grade>();
        }

        public double calculateFinal()
        {
            double final = 0;
            foreach (Grade item in grades)
            {
                final += (item.Value * (item.Porcent / 100));
            }
            return final;
        }

        public short Code { get => code; set => code = value; }
        public String Name { get => name; set => name = value; }
        internal LinkedList<Grade> Grades { get => grades; set => grades = value; }
    }
}
