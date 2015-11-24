namespace HumanOrganazation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HumanTest
    {
        //sort workers list by money per hour in descending using OrderBy() extension method
        public static IEnumerable<Worker> SortDescendingByMoney(IEnumerable<Worker> listOfWorkers)
        {
            int workDaysPerWeek = 5;
            var query = listOfWorkers.OrderByDescending(w => w.MoneyPerHour(workDaysPerWeek));
            return query;
        }

        //print result
        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        //sort students list by grade in ascending order using LINQ
        public static IEnumerable<Student> SortAscendingByGrade(List<Student> listOfStudents)
        {
            var query =
                from student in listOfStudents
                orderby student.Grade ascending
                select student;
            return query;
        }

        //Merge lists and sort them by first name and last name
        public static IEnumerable<Human> MergeLists(IEnumerable<Human> sortStudentsByGradeAscending, IEnumerable<Human> sortWorkersByMoneyDescending)
        {
            //var concatanatedList = sortStudentsByGradeAscending.Cast<Human>()
            //                        .Concat(sortWorkersByMoneyDescending.Cast<Human>())
            //                        .OrderBy(h => h.FirstName)
            //                        .ThenBy(h => h.LastName)
            //                        .ToList();

            var concatanatedList = sortStudentsByGradeAscending.Concat(sortWorkersByMoneyDescending)
                                    .OrderBy(h => h.FirstName)
                                    .ThenBy(h => h.LastName)
                                    .ToList();
            return concatanatedList;
        }

        static void Main()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Ivo", "Kolev", 5),
                new Student("Ivan", "Nikolov", 6),
                new Student("Ani", "Milanova", 2),
                new Student("Krasimir", "Kirilov", 4),
                new Student("Petur", "Petrov", 4),
                new Student("Bobi", "Ivanov", 4),
                new Student("Nedialko", "Nikolov", 3),
                new Student("Mariq", "Veselova", 4),
                new Student("Miglena", "Stefanova", 6),
                new Student("Nikifor", "Nikiforov", 5),
            };

            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker("Ivo", "Nikolov", 250.0m,8),
                new Worker("Ivan", "Nikolov", 350.0m,8),
                new Worker("Ani", "Angelova", 450.0m,8),
                new Worker("Krasimir", "Kirilov", 250.0m,8),
                new Worker("Petur", "Petrov", 350.0m,8),
                new Worker("Bobi", "Kolev", 550.0m,10),
                new Worker("Nedialko", "Nikolov", 250.0m,8),
                new Worker("Mariq", "Stefanova", 276.0m,8),
                new Worker("Miglena", "Petrova", 250.0m,8),
                new Worker("Nikifor", "Nikiforov", 689.0m,8),
            };

            var sortStudentsByGradeAscending = SortAscendingByGrade(listOfStudents);
            var sortWorkersByMoneyDescending = SortDescendingByMoney(listOfWorkers);
            //Console.WriteLine("Sorted list of students by grade in ascending order");
            //Print(sortStudentsByGradeAscending);
            //Console.WriteLine();
            //Console.WriteLine("Sorted list of workers by money per hour in descending order");
            //Print(sortWorkersByMoneyDescending);
            var mergeTwoListsAndSortByName = MergeLists(sortStudentsByGradeAscending, sortWorkersByMoneyDescending);
            Print(mergeTwoListsAndSortByName);
        }        
    }
}
