using System;

namespace TMSLesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Phone phoneFirst = new Phone();
            Phone phoneSecond = new Phone(375333242345, "Apple");
            Phone phoneThird = new Phone(375291787876, 194, "Samsung");

            Console.WriteLine($"Phone1. Номер: {phoneFirst.number}; вес: {phoneFirst.weight}; модель: {phoneFirst.model}");
            Console.WriteLine($"Phone2. Номер: {phoneSecond.number}; вес: {phoneSecond.weight}; модель: {phoneSecond.model}");
            Console.WriteLine($"Phone3. Номер: {phoneThird.number}; вес: {phoneThird.weight}; модель: {phoneThird.model}");
            Console.WriteLine();

            phoneFirst.ReceiveCall("Валера");
            phoneSecond.ReceiveCall("Алешка");
            phoneThird.ReceiveCall("Олег");
            Console.WriteLine();

            var numberOfPhoneFirst = phoneFirst.GetNumber();
            var numberOfPhoneSecond = phoneSecond.GetNumber();
            var numberOfPhoneThird = phoneThird.GetNumber();
            Console.WriteLine($"Phone1. Номер: {numberOfPhoneFirst:+### (##) ###-##-##}");
            Console.WriteLine($"Phone2. Номер: {numberOfPhoneSecond:+### (##) ###-##-##}");
            Console.WriteLine($"Phone3. Номер: {numberOfPhoneThird:+### (##) ###-##-##}");
            Console.WriteLine();

            phoneThird.ReceiveCall("Иванушка", 375447623452);
            Console.WriteLine();

            phoneFirst.SendMessage(new long[] { 375291415161, 375447878787, 375335678765, 375291213232 });
            Console.ReadLine();

            //task2
            Patient patientOne = new Patient(1);
            patientOne.SelectDoctor();

            Patient patientTwo = new Patient(2);
            patientTwo.SelectDoctor();

            Patient patientThree = new Patient(3);
            patientThree.SelectDoctor();
            Console.ReadLine();

            //task3
            CreditCard cardOne = new CreditCard("1314241425616USD2516", 4564.76);
            CreditCard cardTwo = new CreditCard("7835261425616USD2516", 123.60);
            CreditCard cardThree = new CreditCard("1387162925616USD2523", 78232.00);

            cardOne.ShowCurrentState();
            cardOne.Plus(231.12);
            cardOne.ShowCurrentState();
            Console.WriteLine();

            cardTwo.ShowCurrentState();
            cardTwo.Plus(1000.00);
            cardTwo.ShowCurrentState();
            Console.WriteLine();

            cardThree.ShowCurrentState();
            cardThree.Minus(8230.01);
            cardThree.ShowCurrentState();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}