/*
 *  Noah Moorhouse
 *  IT3045
 *  moorhonh@mail.uc.edu
 *  Assignment 05
 *  Due Date: 9/23/21
 *  This class contains my imlementation of the interfaces
 *  Citations: None
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class Noah : Student
    {
        /// <summary>
        /// How i play
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Noah has been playing warframe for at least six hours today.");
        }
        /// <summary>
        /// My study behavior
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Noah has gotten distracted... We will be studying again soon...");
            Thread.Sleep(2000);
            this.Play();


        }
    }
}
