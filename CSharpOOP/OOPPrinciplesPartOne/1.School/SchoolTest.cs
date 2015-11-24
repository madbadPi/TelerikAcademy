namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;

    public class SchoolTest
    {
        static void Main()
        {
            School newSchool = new School("SMG");
            //Console.WriteLine(newSchool.Name);

            List<Student> newStudentsList = new List<Student>
            {
                new Student("Ivo Ivanov", 1),
                new Student("Lina Nikolova", 2),
                new Student("Miglena Ivanov", 3),
            };           

            List<Teacher> newTeachersList = new List<Teacher>
            {
                new Teacher("Ivan Mishov"),
                new Teacher("Pesho Pesho")
            };

            ClassOfStudents classA = new ClassOfStudents("Class A", newTeachersList, newStudentsList);
            //Console.WriteLine(classA);

            newSchool.AddClass(classA);
            //Console.WriteLine(newSchool);

            newSchool.RemoveClass(classA);
            //Console.WriteLine(newSchool);

            classA.MakeComment = "Bla bla";
            //Console.WriteLine(classA.MakeComment);

            Student newStudent = new Student("Ani", 4);
            classA.AddStudent(newStudent);

            //Console.WriteLine(classA);

            classA.RemoveStudent(newStudent);
            //Console.WriteLine(classA);

            //Console.WriteLine(newStudent);

            newStudent.MakeComment = "AlA bala";
            //Console.WriteLine(newStudent.MakeComment);

            Discipline newDiscipline = new Discipline("Math", 3, 5);
            Teacher newTeacher = new Teacher("Ivan Dragnev");
            newTeacher.AddDiscipline(newDiscipline);
            //Console.WriteLine(newTeacher);

            newTeacher.RemoveDiscipline(newDiscipline);
            //Console.WriteLine(newTeacher);

            Student studentIvo = new Student("Ivo", 12);
            Console.WriteLine(studentIvo.Name);
        }
    }
}
