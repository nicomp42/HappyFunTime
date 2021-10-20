using System;

/**
 * Drew Buchwald
 * buchwasa@mail.uc.edu
 * buchwasa_Assignment08
 * Course: IT3045 Fall 2021
 * Due Date: 10/21/2021
 * Description: Implements the "Drew" child class of Student
 */
namespace HappyFunTime.Students
{
    class Drew : Student
    {

        /// <summary>
        /// Prints out what Drew is currently playing
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Drew is playing various games on Xbox");
        }

        /// <summary>
        /// Prints out what Drew is currently studing
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Drew is studying Rust");
        }
    }
}
