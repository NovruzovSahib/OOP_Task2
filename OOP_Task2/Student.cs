using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    internal class Student
    {
        string name ;
        string surname;
        byte age;
        string schoolName;
        string profession;
        short score;
        string nationality;
        bool isAcademy;
        readonly bool isHighEducation = true;
        char classNumber;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public byte Age { get { return age; } set { age = value; } }
        public string SchoolName { get { return schoolName; } set { schoolName = value; } }
        public string Profession { get { return profession; } set { profession = value; } }
        public short Score { get { return score; } set { score = value; } }
        public string Nationality { get { return nationality; } set { nationality = value; } }
        public bool IsAcademy { get { return isAcademy; } set { isAcademy = value; } }
        public bool IsHighEducation { get { return isHighEducation; } }
        public char ClassNumber { get { return classNumber; } set { classNumber = value; } }


        public void GetStudent()
        {
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
            this.schoolName = SchoolName;
            this.profession = Profession;
            this.score = Score;
            this.nationality = Nationality;
            this.isAcademy = IsAcademy;
            this.classNumber = ClassNumber;

            Console.WriteLine($"Student Name is:John\nStudent Surname is:Carry\nStudent Age is:22\nStudent SchoolName is:Signature School\nStudent Profession is:IT\nStudent Score is:22\nStudent Nationality is:US\nStudent IsAcademy:true\nStudent IsHighEducation is:{this.IsHighEducation}\nStudent ClassNumber is:A");

        }
    }
}
