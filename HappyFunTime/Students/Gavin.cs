/* Gavin Colebank
 * colebagc@mail.uc.edu
 * 10/19/21
 * IT-3045C Contemparary Programming
 * Assignemnt 08
 * Due 10/21/2021
 * -- Fixing errors and implementing play and study methods --
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class Gavin : Student
    {
        /// <summary>
        /// Method "Play" to print out a message about what Gavin is doing.
        /// </summary>
        public override void Play() {
            Console.WriteLine("Gavin is somewhere getting 8 MPG instead of the advertied 35 +");
        }

        /// <summary>
        /// Method "Study" to print out a message about what Gavin is studying.
        /// </summary>
        public override void Study() {
            Console.WriteLine("Gavin is currently studying to figure out how to increase fuel mileage without reducing his heavy foot");
        }
    }
}
