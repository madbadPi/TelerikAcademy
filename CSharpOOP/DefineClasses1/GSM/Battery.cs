using System;
namespace GSM
{
    public class Battery //?
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {
            this.Model = null;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
            //this.BatteryType = BatteryType.LiIon;
        }

        public Battery(string currentModel) : this()
        {
            this.Model = currentModel;                     
        }

        public Battery(string currentModel, int currHoursIdel,int currHoursTalk, BatteryType currBatteryType) : this(currentModel)
        {            
            this.HoursIdle = currHoursIdel;
            this.HoursTalk = currHoursTalk;
            this.BatteryType = currBatteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }

        }

        public int HoursIdle
        {
            get 
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle can't be negative");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk can't be negative");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            return this.Model + " " + this.batteryType + " " + "Hours talk " + this.hoursTalk;
        }
    }
}
