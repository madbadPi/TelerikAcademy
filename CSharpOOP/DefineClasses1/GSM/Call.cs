namespace GSM
{
    using System;
    using System.Collections.Generic;
    
    public class Call
    {
        private string dialedNumber = null;
        public DateTime Date { get;  private set; }
        public string Time { get; private set; }        
        public uint CallDuration { get; set; } // in seconds
        public string Id { get; private set; }

        public Call(string currDialedNum,uint currDuration)
        {
            DateTime date = DateTime.Now;
            string time = date.Hour + ":" + date.Minute + ":" + date.Second;

            this.Date = date.Date;
            this.Time = time;
            this.CallDuration = currDuration;
            this.DialedNumber = currDialedNum;
            this.Id = this.Date + this.Time + this.DialedNumber;
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }

            private set
            {
                if (value != null)
                {
                    this.dialedNumber = value;
                }
                else
                {
                    throw new ArgumentNullException("Dialed number can't be null");
                }
            }
        }

        public override string ToString()
        {
            return this.DialedNumber + " " + this.Date.ToShortDateString() + " " + this.Time + " call duration:" + this.CallDuration;
        }
    }
}
