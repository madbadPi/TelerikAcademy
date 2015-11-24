namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : Comment
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get
            {                
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name can not be empty.");
                }

                this.name = value;
            }
        }       

        public override string ToString()
        {
            return this.Name;
        }
    }
}
