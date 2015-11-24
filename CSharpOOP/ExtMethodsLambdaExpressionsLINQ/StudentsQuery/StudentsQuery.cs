namespace StudentsQuery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StQuery
    {
        public static IEnumerable<Student> StOnlyGroup2(IEnumerable<Student> stdArray)
        {
            var query =
                from student in stdArray
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            return query;
        }

        public static void Print<T>(IEnumerable<T> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<Student> ExtractStEmailAbv(IEnumerable<Student> stdArray)
        {
            var query =
                from student in stdArray
                where student.Email.Split('@')[1] == "abv.bg"
                select student;
            return query;
        }

        private static IEnumerable<Student> ExtractStTelInSofia(IEnumerable<Student> stdArray)
        {
            var query =
                from student in stdArray
                where (student.Tel.Substring(4, 1) == "2" && student.Tel.Substring(5).Length == 7)
                select student;
            return query;
        }

        public static void ExtractStMarkSix(IEnumerable<Student> students)
        {
            int wantedMark = 6;
            var query = students
                .Where(st => st.Marks.Contains(wantedMark))
                .Select(st =>
                    new
                    {
                        FullName = st.FirstName + " " + st.LastName,
                        Marks = st.GetMarks()
                    });
            foreach (var st in query)
            {
                Console.WriteLine("{0} - {1}", st.FullName, st.Marks);
            }
        }

        public static IEnumerable<Student> StEnrolledYear2006(IEnumerable<Student> students)
        {
            var query = students
                .Where(st => (st.FN.Substring(5, 2) == "06"));
            return query;
        }

        public static IEnumerable<Student> StFromMathDep(IEnumerable<Student> stArray, List<Group> depArray)
        {
            var query = from st in stArray
                        join d in depArray on st.GroupNumber equals d.GroupNumber
                        select st;
            return query;
        } 

        public static void Main()
        {
            //List of sample students
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Ani",
                    LastName = "Androva",
              //position 01234567
                    FN = "00000061",
                    Tel = "+35929112233",
                    Email = @"ani.ani@abv.bg",
                    Marks = new List<int> {5, 2, 6, 3 },                    
                    GroupNumber = 1                    
                },

                new Student
                {
                    FirstName = "Krasi",
                    LastName = "Petkov",
                    FN = "00000062",
                    Tel = "+35954112000",
                    Email = @"krasi.petkov@abv.bg",
                    Marks = new List<int> {6, 6, 6, 6 },
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Bobi",
                    LastName = "Turboto",
                    FN = "00000073",
                    Tel = "+35928112236",
                    Email = @"bobi.turboto@mail.bg",
                    Marks = new List<int> {2, 2, 4, 3 },
                    GroupNumber = 1
                },

                new Student
                {
                    FirstName = "Gosho",
                    LastName = "Ivanov",
                    FN = "00000074",
                    Tel = "+35928112235",
                    Email = @"gosho.ivanov@mail.bg",
                    Marks = new List<int> {6, 6, 6, 3 },
                    GroupNumber = 4
                },

                new Student
                {
                    FirstName = "Petar",
                    LastName = "Petrov",
                    FN = "00000075",
                    Tel = "+359888112222",
                    Email = @"petar.petrov@mail.bg",
                    Marks = new List<int> {4, 2, 6, 3 },
                    GroupNumber = 3
                },

                new Student
                {
                    FirstName = "Kolio",
                    LastName = "Nikolov",
                    FN = "00000076",
                    Tel = "+359888112237",
                    Email = @"kolio.nikolov@abv.bg",
                    Marks = new List<int> {5, 5, 6, 5 },
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Anna",
                    LastName = "Ivanova",
                    FN = "00000077",
                    Tel = "+359888112201",
                    Email = @"anna.ivanoca@mail.bg",
                    Marks = new List<int> {5, 4, 4, 4 },
                    GroupNumber = 2
                }
            };
            //using LINQ query
            //Select only the students that are from group number 2. 
            //Use LINQ query. Order the students by FirstName
            var selsectStOnlyGroup2 = StOnlyGroup2(students);
            Print(selsectStOnlyGroup2);
            Console.WriteLine(new string('-', 70));
            //using LINQ query with extension method
            var selsectStOnlyGroup2Ext = ExtMethod.StGroup2Ext(students);
            Print(selsectStOnlyGroup2);
            //extract all students that have e-mail in abv.bg, use string methods and LINQ
            var studentEmailAbv = ExtractStEmailAbv(students);
            Print(studentEmailAbv);
            //Extract all students with phones in Sofia. Use LINQ
            var studentTelInSofia = ExtractStTelInSofia(students);
            Print(studentTelInSofia);
            //Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ
            ExtractStMarkSix(students);
            //Extract students with exactly two marks "2". Use extension methods.
            ExtMethod.StTwoTimesMarksTwoExt(students);
            //Extract all Marks of the students that enrolled in 2006.
            //The students from 2006 have 06 as their 5-th and 6-th digit in the FN.
            var selectStEnrolled2006 = StEnrolledYear2006(students);
            //Print(selectStEnrolled2006);
            //Create a class Group with properties GroupNumber and DepartmentName. 
            //Introduce a property Group in the Student class. 
            //Extract all students from "Mathematics" department. Use the Join operator
            var departments = new List<Group>
            {
                new Group
                {
                    GroupNumber = 1,
                    DepartmentName = "Mathematics"
                },

                new Group
                {
                    GroupNumber = 2,
                    DepartmentName = "Mathematics"
                },
            };
            var ExtractAllStFromMathDep = StFromMathDep(students, departments);
            Print(ExtractAllStFromMathDep);

        }            
    }
}
