/*
 * Logan Farwick
 * farwicls@mail.uc.edu
 * Course/Term: IT3045C Fall 2022 
 * Assignment: 08
 * Due Date: 10/21/2021
 * Description: Clone, fork, edit, push, and create a pull request for the 'Logan' class as assigned from GitHub
 * Citations: https://stackoverflow.com/questions/1916918/c-sharp-class-does-not-implement-inherited-abstract-member
 * Anything else: N/A
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    class Logan : Student
    {
        /// <summary>
        /// Play method to show that Logan is gaming
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Logan is currently playing on his PS5.");
        }
        /// <summary>
        /// Study method to show that Logan is studious
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Logan is currently studying for his Contemporary Programming quiz next week.");
        }
    }
}
