namespace HumanOrganazation
{
    using System;
    using System.Collections.Generic;

    public class Worker : Human
    {
        private decimal weekSalay;

        private int workHoursPerDay;

        public Worker(string workerFirstName, string workerLastname, decimal workerWeekSalay, int workerWorkHoursPerDay)
            : base(workerFirstName, workerLastname)
        {
            this.WeekSalary = workerWeekSalay;
            this.workHoursPerDay = workerWorkHoursPerDay;
        }

        public decimal WeekSalary 
        { 
            get
            {
                return this.weekSalay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The week salary can't be negative");
                }
                this.weekSalay = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day can't be negative or more than 12 hours");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(int workDaysPerWeek)
        {
            return this.WeekSalary / (this.WorkHoursPerDay * workDaysPerWeek);
        }

        public override string ToString()
        {
            return base.ToString() + 
            " week salary: " + this.WeekSalary + " BGN, "+ "worker hours per day: " + this.WorkHoursPerDay;
        }
    }
}
