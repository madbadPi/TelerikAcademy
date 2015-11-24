namespace StudentsGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StGroupQuery
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student
                {
                    FullName = "Gesha Lilov",
                    GroupName = "StarWars"
                },

                new Student
                {
                    FullName = "Ani Ivanova",
                    GroupName = "Galaxy"
                },
 
                new Student
                {
                    FullName = "Pesho Kirilov",
                    GroupName = "Galaxy"
                },

                new Student
                {
                    FullName = "Iva Terzieva",
                    GroupName = "StarWars"
                },

                new Student
                {
                    FullName = "Misho Kostov",
                    GroupName = "Galaxy"
                },
                
                new Student
                {
                    FullName = "Ala Bala",
                    GroupName = "Galaxy"
                }
            };
            //18.Extracts all students grouped by GroupName 
            //and then prints them to the console. Use LINQ.
            GroupStByGroupNameLINQ(students);
            //19.Rewrite the previous using extension methods
            GroupStByGroupNameExt(students);
        }

        public static void GroupStByGroupNameLINQ(IEnumerable<Student> stArray)
        {
            var studentsGrouped =
                from student in stArray                 
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            Console.WriteLine("All students grouped by group name:");
            foreach (var currentGroup in studentsGrouped)
            {
                Console.WriteLine();
                foreach (var student in currentGroup)
                {

                    Console.WriteLine(student.FullName);
                }
            }
        }

        public static void GroupStByGroupNameExt(IEnumerable<Student> stArray)
        {
            var studentsGrouped = stArray
                .GroupBy(st => st.GroupName)
                .OrderBy(st => st.Key);
            Console.WriteLine("All students grouped by group name:");
            foreach (var currentGroup in studentsGrouped)
            {                
                Console.WriteLine();
                foreach (var student in currentGroup)
                {
                    
                    Console.WriteLine(student.FullName);
                }                
            }
        }
    }
}
