namespace HumanOrganazation
{
    using System;
    using System.Collections.Generic;

    public class Student : Human
    {
        private int grade;

        public Student(string newFirstName, string newLastName, int newGrade)
            : base(newFirstName, newLastName)
        {           
            this.Grade = newGrade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Grade can't be negative or zero");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " grade:" + this.Grade.ToString();
        }
    }
}
