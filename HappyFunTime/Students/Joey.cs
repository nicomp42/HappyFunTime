/* Joseph Tankersley tankerjh@mail.uc.edu
 * Contemporary Programming Fall 2021
 * Assignment 08
 * 21 October 2021
 * Joey class which inherits from Student
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    /// <summary>
    /// Joey class implements the Play and Study interfaces inherited from Student
    /// </summary>
    class Joey: Student
    {
        /// <summary>
        /// 'Play' behavior for Joey
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Joey is playing guitar");
        }
        /// <summary>
        /// 'Study' behavior for Joey
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Joey is studying soldering techniques");
        }
    }
}
