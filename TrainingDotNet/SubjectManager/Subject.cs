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
        private short name;
        private byte gradeHW1;
        private byte gradeHW2;
        private byte gradeHW3;
        private byte gradeP1;
        private byte gradeP2;
        private byte gradeP3;

        public Subject(short code, short name, byte gradeHW1, byte gradeHW2, byte gradeHW3, byte gradeP1, byte gradeP2, byte gradeP3)
        {
            this.code = code;
            this.name = name;
            this.gradeHW1 = gradeHW1;
            this.gradeHW2 = gradeHW2;
            this.gradeHW3 = gradeHW3;
            this.gradeP1 = gradeP1;
            this.gradeP2 = gradeP2;
            this.gradeP3 = gradeP3;
        }

        public short Code { get => code; set => code = value; }
        public short Name { get => name; set => name = value; }
        public byte GradeHW1 { get => gradeHW1; set => gradeHW1 = value; }
        public byte GradeHW2 { get => gradeHW2; set => gradeHW2 = value; }
        public byte GradeHW3 { get => gradeHW3; set => gradeHW3 = value; }
        public byte GradeP1 { get => gradeP1; set => gradeP1 = value; }
        public byte GradeP2 { get => gradeP2; set => gradeP2 = value; }
        public byte GradeP3 { get => gradeP3; set => gradeP3 = value; }
    }
}
