namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class GSMTestAndCallsTest
    {
        static void Main()
        {
            const int TestLenOfArray = 10; //max length of test array
            List<GSM> testGSMArray = new List<GSM>(); // declare test array of instances of the GSM class
            Battery newBattery = new Battery("C6603", 530, 11, BatteryType.LiIon);  // create instance of Battery class
            Display newDisplay = new Display(5, 16000000);        // create instance of Display class   
            
            //initialize testGSMArray
            for (int i = 0; i < TestLenOfArray; i++)
            {
                GSM gsm = new GSM("Xperia Z", "Sony", 680.00m, "Pesho", newBattery, newDisplay);
                testGSMArray.Add(gsm);
            }

            testGSMArray[0].Owner = "Gogo";
            //test throw exception
            //testGSMArray[0].Price = -1000;
            
            //test throw exception
            //newBattery.HoursTalk = -1;

            //test GSM
            for (int i = 0; i < TestLenOfArray; i++)
            {
                Console.WriteLine("_________________________________________");
                testGSMArray[i].PrintAllInfoGSM();
                Console.WriteLine("_________________________________________");
            }
            GSM newGsm = new GSM("Xperia Z", "Sony", 680.00m, "Tosho", newBattery, newDisplay);
            Console.WriteLine(newGsm.IPhone4S);  //TODO method for printing static property       
            //test calls

            Call firstCall = new Call("+359888445522", 300);
            Call secondCall = new Call("+359888445521", 800);
            Call thirdCall = new Call("+359888445523", 700);

            Console.WriteLine("Calls History:");
            testGSMArray[0].AddCallsINHistory(firstCall);            
            Console.Write("Price:{0} BGN ", testGSMArray[0].ClacPriceofCalls(firstCall));
            Console.WriteLine(testGSMArray[0].CallHistory[0].ToString());

            testGSMArray[0].AddCallsINHistory(secondCall);
            Console.Write("Price:{0} BGN ", testGSMArray[0].ClacPriceofCalls(secondCall));
            Console.WriteLine(testGSMArray[0].CallHistory[1].ToString());

            testGSMArray[0].AddCallsINHistory(thirdCall);
            Console.Write("Price:{0} BGN ", testGSMArray[0].ClacPriceofCalls(thirdCall));
            Console.WriteLine(testGSMArray[0].CallHistory[2].ToString());
            

            decimal totalBill = 0.0m;
            for (int i = 0; i < testGSMArray[0].CallHistory.Count; i++)
            {
                
                totalBill += testGSMArray[0].ClacPriceofCalls(testGSMArray[0].CallHistory[i]);
            }
            Console.WriteLine("Total Bill:{0}", totalBill);

            uint maxDuration = 0;
            string maxDurCallId = String.Empty;

            //TODO method for calc total price
            for (int i = 0; i < testGSMArray[0].CallHistory.Count-1; i++)
            {
                if(testGSMArray[0].CallHistory[i].CallDuration > maxDuration)
                {
                    maxDuration = testGSMArray[0].CallHistory[i].CallDuration;
                    maxDurCallId = testGSMArray[0].CallHistory[i].Id;
                }
            }

            Console.WriteLine("_____________");
            testGSMArray[0].DeleteCallsHistory(maxDurCallId);            
            testGSMArray[0].PrintCallHistory();
            totalBill = 0.0m;
            for (int i = 0; i < testGSMArray[0].CallHistory.Count; i++)
            {
                
                totalBill += testGSMArray[0].ClacPriceofCalls(testGSMArray[0].CallHistory[i]);
            }
            Console.WriteLine("Total bill without longest call:{0}", totalBill);

            Console.WriteLine("_____________");

            testGSMArray[0].ClearCallsHistory();
            testGSMArray[0].PrintCallHistory();            
        }
    }
}
