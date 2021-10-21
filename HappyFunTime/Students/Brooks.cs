/*
 * William Arthur
 * arthurwb@mail.uc.edu
 * IT 3045
 * Assignment 08
 * Due October 21
 * Description: Edit your class to fix the build errors. Do not edit the interface or any other modules.
 * Your Play and Study methods should print friendly messages to the console so we know it’s you. 
 * Citations:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class Brooks : Student
    {
        /// <summary>
        /// Method to print out what Brooks is doing when he is meant playing
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Brooks is hiding under his blanket trying to avoid all his responsibilities.");
        }
        /// <summary>
        /// Method to print out what Brooks is doing when he is meant studying
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Brooks is trying to find out who JSON is");
        }
    }
}
