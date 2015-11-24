namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LINQqueries
    {
        public static IEnumerable<Student> StFirstNameBfrLast(IEnumerable<Student> stArray)
        {
            var query =
                from student in stArray
                where String.Compare(student.FirstName, student.LastName) < 0
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

        private static IEnumerable<Student> AgeBetweenBoundaries(IEnumerable<Student> stArray, int lowerLimit, int upperLimit)
        {
            var query = stArray.Where(st => st.Age >= lowerLimit && st.Age <= upperLimit)
                .Select(st => new Student
                {
                    FirstName = st.FirstName,
                    LastName = st.LastName,
                    Age = st.Age
                });
            return query;
        }

        private static IEnumerable<Student> SortStudentsLambda(IEnumerable<Student> stArray)
        {
            var query = stArray.OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);
            return query;
        }

        private static IEnumerable<Student> SortStudentsLINQ(IEnumerable<Student> stArray)
        {
            var query =
                from student in stArray
                orderby student.FirstName descending,
                        student.LastName descending
                select student;
            return query;
        }

        private static IEnumerable<int> SortNumDivisibleBy(IEnumerable<int> arrayNums, int firstNum, int secondNum)
        {
            var query = arrayNums.Where(num => num % firstNum == 0 && num % secondNum == 0);
            return query;
        }


        private static IEnumerable<int> SortNumDivBy21(IEnumerable<int> arrayNums, int firstNum, int secondNum)
        {
            var query =
                from num in arrayNums
                where num % firstNum == 0 && num % secondNum == 0
                select num;
            return query;
        }  

        public static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student
                {               
                    FirstName = "Ani",
                    LastName = "Ani",   
                    Age = 16
                },
                new Student
                {
                    FirstName = "Anni",
                    LastName = "Borisova",
                    Age = 18
                },
                new Student
                {
                    FirstName = "Boris",
                    LastName = "Ivanov",
                    Age = 24
                },
                new Student
                {
                    FirstName = "Martin",
                    LastName = "Angelov",
                    Age = 20
                },
                new Student
                {
                    FirstName = "Martin",
                    LastName = "Nikolov",
                    Age = 80
                },
                new Student
                {
                    FirstName = "Nikolai",
                    LastName = "Nikolov",
                    Age = 33
                },
            };
            //LINQ query that finds all students whose first name is before its 
            //last name alphabetically
            var firstNameBeforeLastQuery = StFirstNameBfrLast(students);
            //Print(firstNameBeforeLastQuery);

            //a LINQ query that finds the first name and 
            //last name of all students with age between 18 and 24
            const int LowerLimit = 18;
            const int UpperLimit = 24;
            var ageQuery = AgeBetweenBoundaries(students, LowerLimit, UpperLimit);
            //Print(ageQuery);

            //sort the students by first name and last name in descending order 
            //using extension methods OrderBy() and ThenBy() with lambda expressions
            var sortStudentFirstAndLastNameDesc = SortStudentsLambda(students);
            Print(sortStudentFirstAndLastNameDesc);

            //sort the students by first name and last name in descending order 
            //using LINQ
            var sortStudentFirstAndLastNameDescLINQ = SortStudentsLINQ(students);
            Print(sortStudentFirstAndLastNameDescLINQ);

            //select and print form given array of all numbers that are divisible by 7 and 3
            //use the built-in extension methods and lambda expressions
            List<int> intArray = new List<int> { 12, 0, -1, 7, 3, 21, 49 };
            var sortNumDivBy21 = SortNumDivisibleBy(intArray, 7, 3);
            Print(sortNumDivBy21);

            //select and print form given array of all numbers that are divisible by 7 and 3
            //use LINQ
            var sortNumDiv = SortNumDivBy21(intArray, 7, 3);
            Print(sortNumDiv);
        }
    }
}
