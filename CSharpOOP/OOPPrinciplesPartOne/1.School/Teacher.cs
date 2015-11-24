namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {
        private List<Discipline> disciplineList;

        public Teacher(string name) : base(name)
        {
            disciplineList = new List<Discipline>();
        }

        public List<Discipline> DisciplineList
        {
            get 
            {
                return new List<Discipline>(this.disciplineList);
            }
        }

        public void AddDiscipline(Discipline newDiscipline)
        {
            this.disciplineList.Add(newDiscipline);
        }

        public void RemoveDiscipline(Discipline disciplineDeleted)
        {
            this.disciplineList.Remove(disciplineDeleted);
        }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();
            teacherInfo.Append(base.Name);
            teacherInfo.Append(" Disciplines:");
            foreach (var course in this.DisciplineList)
            {
                teacherInfo.AppendFormat("\n{0}", course);
            }

            return teacherInfo.ToString();
        }
        
    }
}
