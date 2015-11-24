namespace SchoolOrganization
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ClassOfStudents : Comment
    {        
        private List<Teacher> teachersList;

        private List<Student> studentsList;

        private string id;

        public ClassOfStudents(string textID, List<Teacher> teachers, List<Student> students)
        {
            this.ID = textID;
            this.teachersList = new List<Teacher>(teachers);
            this.studentsList = new List<Student>(students);
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class Text Identifier can not be null or empty!");
                }
                this.id = value;
            }
        }

        public List<Teacher> TeachersList
        {
            get
            {
                return new List<Teacher>(this.teachersList);
            }
        }

        public List<Student> StudentsList
        {
            get
            {
                return new List<Student>(this.studentsList);
            }
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.teachersList.Add(newTeacher);
        }

        public void AddStudent(Student newStudent)
        {
            this.studentsList.Add(newStudent);
        }

        public void RemoveTeacher(Teacher teacherDeleted)
        {
            this.teachersList.Remove(teacherDeleted);
        }

        public void RemoveStudent(Student studentDeleted)
        {
            this.studentsList.Remove(studentDeleted);
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(this.ID);
            info.Append("Teachers list:\n");
            foreach (var teacher in this.TeachersList)
            {
                info.AppendLine(teacher.ToString());
            }
            info.Append("Students list:\n");
            foreach (var student in this.StudentsList)
            {
                info.AppendLine(student.ToString());
            }
            
            return info.ToString();    
        
        }
        
    }
}
