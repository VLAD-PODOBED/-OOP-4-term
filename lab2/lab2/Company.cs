using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab2
{
    public class Company
    {
        public Company(string company, decimal exp, string post)
        {
            this.company = company;
            this.exp = exp;
            this.post = post;
        }
        public Company()
        {
            this.company = "";
            this.exp = 0;
            this.post = "";
        }
        public string company;
        public string post;
        public decimal exp;
        public override string ToString()
        {
            return ($"Компания:{company}\n Должность:{post}\n Стаж:{exp}\n");
        }
    }
}
