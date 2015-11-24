namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private const decimal fixedPriceCalls = 0.37m; //fixed price per minute 

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private Battery battery = new Battery();
        private Display display = new Display();

        private readonly List<Call> callHistory = new List<Call>();
             
        private static Battery iPhone4SBatt = new Battery("Z500", 300, 7, BatteryType.LiIon);
        private static Display iPhone4SDisplay = new Display(4.0m, 16000000);

        private static readonly GSM iPhone4S = new GSM("IPhone4S", "Apple", 675.00m, null, iPhone4SBatt, iPhone4SDisplay);

        public GSM(string currModel, string currManufacturer)
        {
            this.Model = currModel;
            this.Manufacturer = currManufacturer;
            this.Price = 0.0m;
            this.Owner = null;
        }

        public GSM(string currModel, string currManufacturer, decimal currPrice, string currOwner) 
            : this(currModel, currManufacturer)
        {
            this.Price = currPrice;
            this.Owner = currOwner;
        }
        
        public GSM(string currModel, string currManufacturer, decimal currPrice, string currOwner, Battery currBattery = null, Display currDisplay = null) 
            : this(currModel, currManufacturer, currPrice, currOwner)
        {
            this.battery = currBattery;
            this.display = currDisplay;
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can't be negative");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }            
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
        
        public void AddCallsINHistory(Call addNewCall)
        {            
            this.callHistory.Add(addNewCall);
        }

        public void DeleteCallsHistory(string id)
        {
            int index = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (id == this.callHistory[i].Id)
                {
                    index = i;
                }
            }
            this.CallHistory.RemoveAt(index);           
        }

        public void ClearCallsHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal ClacPriceofCalls(Call currentCall)
        {
            return Math.Round(currentCall.CallDuration * (fixedPriceCalls/60), 2);
        }

        public void PrintAllInfoGSM()
        {
            Console.WriteLine("GSM information:\n");
            Console.WriteLine("model:{0}\nmanufacturer:{1}\n", this.Model, this.manufacturer);            
            Console.WriteLine("battery model:{0}\nbattery type:{1}\nhours idle:{2}\nhours talk:{3}", battery.Model, battery.BatteryType, battery.HoursIdle, battery.HoursTalk);
            Console.WriteLine("display size:{0} inch\nnumber of display colors:{1}\n", display.Size, display.NumColors);
            Console.WriteLine("price:{0} BGN\nowner:{1}\n", this.price, this.owner);
        }

        public override string ToString()
        {
            return this.Manufacturer + " " + this.model + " " + this.price + "BGN";
        }

        public void PrintCallHistory()
        {
            if (this.callHistory.Count == 0)
            {
                Console.WriteLine("No history available");
            }
            else
            {
                foreach (var call in this.callHistory)
                {
                    Console.WriteLine(call);
                }
            }
        }
    }
}