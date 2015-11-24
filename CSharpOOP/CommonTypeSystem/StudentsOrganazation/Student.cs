namespace StudentsOrganazation
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, 
            string currentSSN, string currentCourse, Specialty currentSpecialty, University currentUniversity,
            Faculty currentFaculty)
        {
            this.FirtsName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = currentSSN;
            this.Course = currentCourse;
            this.Specialty = currentSpecialty;
            this.University = currentUniversity;
            this.Faculty = currentFaculty;
        }

        public Student(string firstName, string middleName, string lastName,
            string currentSSN, string address, string phone, string email, string currentCourse, Specialty currentSpecialty, University currentUniversity,
            Faculty currentFaculty) 
            : this(firstName, middleName, lastName, currentSSN, currentCourse, currentSpecialty,
            currentUniversity, currentFaculty)
        {
            this.PermAddress = address;
            this.MobilePhone = phone;
            this.Email = email;   
        }
        public string FirtsName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
                
        public override bool Equals(object other)
        {
            var currentSudent = other as Student;
            bool result = true;
            if (currentSudent == null ||                
                this.FirtsName != currentSudent.FirtsName ||
                this.MiddleName != currentSudent.MiddleName ||
                this.LastName != currentSudent.LastName ||
                this.SSN != currentSudent.SSN ||
                this.PermAddress != currentSudent.PermAddress ||
                this.MobilePhone != currentSudent.MobilePhone ||
                this.Email != currentSudent.Email ||
                this.Course != currentSudent.Course ||
                this.Specialty != currentSudent.Specialty ||
                this.University != currentSudent.University ||
                this.Faculty != currentSudent.Faculty)
            {
                result = false;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.FirtsName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            var properties = this.GetType().GetProperties();
            foreach (var prop in properties)
            {
                studentInfo.AppendFormat("{0}:{1}\n", prop.Name, prop.GetValue(this));
            }
            return studentInfo.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }


        public object Clone()
        {
            //all properties are value type or string so you may use MemberwiseClone() method
            //var result = this.MemberwiseClone() as Student;
            //or create a new instance of Student
            var result = new Student(this.FirtsName, this.MiddleName, this.LastName, this.SSN,
                this.Course, this.Specialty, this.University, this.Faculty);
            return result;
            
        }

        public int CompareTo(Student other)
        {
            var name = this.FirtsName + " " + this.MiddleName + " " + this.LastName;
            var otherName = other.FirtsName + " " + this.MiddleName + " " + this.LastName;
            //Student name is before otherName in lexicographic order
            if (name.CompareTo(otherName) < 0)
            {                
                return -1;                
            }            
            //Student name is after the otherName in lexicographic order
            else if (name.CompareTo(otherName) > 0)
            {
                return 1;
            }
            //If Student name is equal to otherName you have to compare them by SSN
            return this.SSN.CompareTo(other.SSN);
        }
    }
}
