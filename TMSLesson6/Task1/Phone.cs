using System;

namespace TMSLesson6
{
    public class Phone
    {
        public long number;
        public int weight;
        public string model;

        public Phone() { }

        public Phone(long numberInit, string modelInit)
        {
            number = numberInit;
            model = modelInit;
        }

        public Phone(long numberInit, int weightInit, string modelInit) : this(numberInit, modelInit)    
        { 
            weight = weightInit;
        }

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"Звонит {callerName}");
        }

        public void ReceiveCall(string callerName, long callerNumber)
        {
            Console.WriteLine($"Звонит {callerName}; Номер: {callerNumber:+### (##) ###-##-##}");
        }

        public void SendMessage(long[] numbers)
        {
            Console.WriteLine("Номера телефонов: ");

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:+### (##) ###-##-##}");
            }
        }

        public long GetNumber()
        { 
            return number; 
        }
    }
}
