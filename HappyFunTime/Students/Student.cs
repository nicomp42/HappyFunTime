using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFunTime.Students
{
    abstract class Student : IPlay, IStudy
    {
        public abstract void Play();
        public abstract void Study();
    }
}
