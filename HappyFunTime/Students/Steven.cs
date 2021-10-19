/* Steven HAtton
 * colebagc@mail.uc.edu
 * Assigment 08
 * This class the derived class. It inherits from Student. 
 * Due Date: 10/21/2021
 * Citations: None
 * Anything Else: Hope is sucker works
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class Steven : Student
    {
        /// <summary>
        /// Method "Play" to print out a message about what Steven is doing.
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Steven is playing Halo on Xbox.");
        }

        /// <summary>
        /// Method "Study" to print out a message about what Steven is studying.
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Steven is studying how to have an EMT license and how to work in IT.");
        }
    }
}
