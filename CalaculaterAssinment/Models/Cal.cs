using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalaculaterAssinment.Models
{
    public class Cal
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        


        public int Addition()
        {
            return Num1 + Num2;
        }

        public int Subtraction() {
            return Num1 - Num2;
        }
        public int Multiplication()
        {
            return Num1 * Num2;
        }
    }
}