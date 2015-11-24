namespace StudentsOrganazation
{
    using System;

    public class StudentTest
    {
        static void Main()
        {
            Student firstStudent = new Student("Vasil", "Ivanov", "Ivanov", "987-64-4320", "OOP", Specialty.Software_Engineering, 
                University.SU_St_Kliment_Ohridski, Faculty.Faculty_of_Mathematics_and_Informatics);
            Student secondStudent = new Student("Ivan", "Ivanov", "Petrov", "988-64-4320", "C# Part1", Specialty.Software_Engineering,
                University.SU_St_Kliment_Ohridski, Faculty.Faculty_of_Mathematics_and_Informatics);
            Student thirdStudent = new Student("Vasil", "Ivanov", "Ivanov", "987-64-4320", "OOP", Specialty.Software_Engineering,
                University.SU_St_Kliment_Ohridski, Faculty.Faculty_of_Mathematics_and_Informatics);
            //Console.WriteLine(firstStudent.GetHashCode());
            //Console.WriteLine(secondStudent.GetHashCode());
            
            //Console.WriteLine(firstStudent.Equals(secondStudent));
            //Console.WriteLine(firstStudent.Equals(thirdStudent));

            //Console.WriteLine(firstStudent == secondStudent);
            //Console.WriteLine(firstStudent != thirdStudent);

            //Console.WriteLine(firstStudent);
            //Console.WriteLine(secondStudent);
            //Console.WriteLine(thirdStudent);

            //Student cloneFirstStudent = firstStudent.Clone() as Student;
            //cloneFirstStudent.FirtsName = "Petur";
            //cloneFirstStudent.University = University.Technical_University_of_Sofia;
            //Console.WriteLine(firstStudent);
            //Console.WriteLine(cloneFirstStudent);

            if (firstStudent.CompareTo(thirdStudent) < 0 )
            {
                Console.WriteLine("{0}\nis before student: \n\n{1}", firstStudent, thirdStudent);
            }

            else if (firstStudent.CompareTo(thirdStudent) > 0)
            {
                Console.WriteLine("{0}\nis after student: \n\n{1}", firstStudent, thirdStudent);
            }

            else if (firstStudent.CompareTo(thirdStudent) == 0)
            {
                Console.WriteLine("{0}\nis equal to student: \n\n{1}", firstStudent, thirdStudent);
            }
        }
    }
}
