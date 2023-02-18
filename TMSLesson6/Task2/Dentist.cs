using System;

namespace TMSLesson6
{
    public class Dentist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Лечит дантист");
        }
    }
}
