namespace TimerUsingEvents
{
    using System;
    using System.Threading;
       
    public class Timer
    {
        public delegate void TimerEventHandler(Timer sender, EventArgs e);
        public event TimerEventHandler TimerTickChanged;
        public EventArgs e = null;
        //the publisher raises event
        public virtual void RaiseTheEvent()
        {
            while (true)
	        {
	            Thread.Sleep(200);
                TimerEventHandler newTick = TimerTickChanged;
                if (newTick != null)
                {
                    newTick(this, e);
                }
	        }
        }

    }
   
    public class Subscibers
    {
        //this method subscribe for the event
        public void Subscribe(Timer t)
        {
            t.TimerTickChanged += new Timer.TimerEventHandler(HeardIt);
        }
        //this method print "Heard it" when the event has been raised
        private void HeardIt(Timer t, EventArgs e)
        {
            Console.WriteLine("Heard it");
        }
    }

    public class Test
    {
        static void Main()
        {
            Timer t = new Timer();
            Subscibers s = new Subscibers();
            s.Subscribe(t);
            t.RaiseTheEvent();
        }
    }

}