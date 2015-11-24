namespace SchoolOrganization
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class School
    {
        private string name;

        private List<ClassOfStudents> classesList;

        public School(string name) 
        {
			this.Name = name;
			this.classesList = new List<ClassOfStudents>();
		}

		public string Name 
        {
			get 
            {
                return this.name;
            }
			private set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the scholl can't be null or empty."); 
                }
                this.name = value;
			}
		}

        public List<ClassOfStudents> ClassesList
        {
            get
            {
                return new List<ClassOfStudents>(this.classesList);
            }
        }

		public void AddClass(ClassOfStudents newClass)
		{
				this.classesList.Add(newClass);
		}

		public void RemoveClass(ClassOfStudents classDeleted)
		{
				this.classesList.Remove(classDeleted);
		}

		public override string ToString()
		{
		StringBuilder infoSchool = new StringBuilder();

		foreach (var classOfStudents in this.ClassesList)
		{
				infoSchool.AppendLine(classOfStudents.ToString());
		}

		return this.Name + ":\n" + infoSchool.ToString();
		}
	}
}
