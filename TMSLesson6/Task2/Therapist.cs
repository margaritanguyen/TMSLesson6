using System;

namespace TMSLesson6
{
    public class Therapist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Лечит терапевт");
        }
    }
}
