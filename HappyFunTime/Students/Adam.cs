using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class Adam : Student
    {
        /// <summary>
        /// Implements the inherited member of Student.Study()
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Adam is studying how to code in Kotlin.");
        }
        /// <summary>
        /// Implements the inherited member of Student.Play()
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Adam is watching The Office on his Xbox instead of playing Modern Warfare");
        }
    }
}
