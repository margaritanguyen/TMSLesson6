using System;

namespace TMSLesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadKey();
        }
    }
}