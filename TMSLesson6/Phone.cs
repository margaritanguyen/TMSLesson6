using System;

namespace TMSLesson6
{
    public class Phone
    {
        public long number;
        public int weight;
        public string model;

        public Phone() { }
        
        public Phone(long numberInit, int weightInit, string modelInit) 
        { 
            number = numberInit;
            weight = weightInit;
            model = modelInit;
        }

        public Phone(long numberInit, string modelInit)
        {
            number = numberInit;
            model = modelInit;
        }

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"Звонит {callerName}");
        }

        public long GetNumber()
        { 
            return number; 
        }
    }
}
