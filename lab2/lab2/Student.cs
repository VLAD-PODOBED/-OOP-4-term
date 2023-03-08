using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab2
{
    [Serializable]
    [XmlRoot(Namespace = "STUDENTS")]
    [XmlType("student")]
    public class Student
    {
        public Student(string FN, string AGE, string PRF, string BDAY, string CRS, string GRP, decimal AVG, string SEX, Adress ADRS, Company COM)
        {
            FullName = FN;
            Age = AGE;
            Profession = PRF;
            Birthday = BDAY;
            Course = CRS;
            Group = GRP;
            AverageGrade = AVG;
            Sex = SEX;
            adress = ADRS;
            company = COM;
        }
        public Student()
        {
            FullName = "";
            Age = "";
            Profession = "";
            Birthday = "";
            Course = "";
            Group = "";
            AverageGrade = 0;
            Sex = "";
            adress = new Adress();
            company = new Company();
        }

        [XmlElement(ElementName = "name")]
        public string FullName;
        [XmlElement(ElementName = "age")]
        public string Age;
        [XmlElement(ElementName = "prof")]
        public string Profession;
        [XmlElement(ElementName = "birthday")]
        public string Birthday;
        [XmlElement(ElementName = "course")]
        public string Course;
        [XmlElement(ElementName = "group")]
        public string Group;
        [XmlElement(ElementName = "avgG")]
        public decimal AverageGrade;
        [XmlElement(ElementName = "sex")]
        public string Sex;
        [XmlElement(ElementName = "adress")]
        public Adress adress;
        [XmlElement(ElementName = "company")]
        public Company company;
    }
}