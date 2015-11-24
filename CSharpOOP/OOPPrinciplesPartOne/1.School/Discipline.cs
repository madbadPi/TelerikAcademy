namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;

    public class Discipline : Comment
    {
        public Discipline(string name, int numLectures, int numExercises)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Course title can not be empty."); 
            }

            if (numLectures < 0 || numExercises < 0)
            {
                throw new ArgumentOutOfRangeException("The number of lectures or exercises can not be less than 0.");
            }
            this.Name = name;
            this.NumberOfLectures = numLectures;
            this.NumberOfExercises = numExercises;

        }
        
        public string Name { get; private set; }
 
        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }


        public override string ToString()
        {
            return this.Name + ", " + this.NumberOfLectures + " lectures, " + this.NumberOfExercises + " exercises";
        }     
    }
}
