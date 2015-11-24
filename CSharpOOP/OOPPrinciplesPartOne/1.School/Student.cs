namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;

    public class Student : Person
    {
        private int classNum;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNum = classNumber;
        }

        public int ClassNum 
        {
            get 
            {
                return this.classNum;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The unique class identifier can't be less than 0");
                }
                this.classNum = value;
            }
        }

        public override string ToString()
        {
            return base.Name + " ID: " + this.ClassNum;
        }
         
    }
}
