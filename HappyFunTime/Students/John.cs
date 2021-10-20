using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class John : Student
    {
        public override void Play()
        {
            Console.WriteLine("I play Dota 2 often");
        }

        public override void Study()
        {
            Console.WriteLine("I study the proof that Godzilla is real");
        }
    }
}
