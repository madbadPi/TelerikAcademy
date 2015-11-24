namespace StudentsQuery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtMethod
    {
        public static IEnumerable<Student> StGroup2Ext(this IEnumerable<Student> stdArray)
        {
            var query =
                from student in stdArray
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            return query;
        }

        public static void StTwoTimesMarksTwoExt(this IEnumerable<Student> stdArray)
        {
            int wantedMark = 2;
            int containsExactly = 2;
            var query = stdArray
                .Where(st => st.ContainsMark(wantedMark) == containsExactly)
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
    }
}
