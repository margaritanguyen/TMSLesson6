using System;

namespace TMSLesson6
{
    public class Surgeon : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Лечит хирург");
        }
    }
}
