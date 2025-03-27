using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    internal class Student : Person
    {
        protected string code;

        public string Code { get { return code; }  }

        public Student(string name, int age, string code) : base(name,age)
        {
            this.code = code;
        }

        public override string ShowInfo()
        {
            return $"Hay una persona con nombre {name}, edad {age} y code {code}";
        }

    }
}
