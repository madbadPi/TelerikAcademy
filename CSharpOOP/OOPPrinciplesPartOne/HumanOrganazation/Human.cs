namespace HumanOrganazation
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Human(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        
    }
}
