namespace StudentsQuery
{
    using System;
    using System.Collections.Generic;

    public class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return this.DepartmentName + " " + this.GroupNumber;
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public Group Group { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " FN:" + this.FN + " tel:" + this.Tel
                + " email:" + this.Email + " Group number:" + this.GroupNumber;
        }

        public int ContainsMark(int wantedMark)
        {
            int counter = 0;
            foreach (var mark in this.Marks)
            {
                if (mark == wantedMark)
                {
                    counter++;
                }
            }
            return counter;
        }

        public string GetMarks()
        {
            return string.Join(", ", this.Marks);
        }
    }
}
