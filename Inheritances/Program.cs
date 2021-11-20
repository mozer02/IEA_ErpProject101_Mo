using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances //Miras
{
    class Program
    {
        static void Main(string[] args)
        {
            Players ply = new Players();
            Coach coach = new Coach();
            Person person = new Person();
                
            //Her bir class ayri ayri implamente edilebilir.
            //Her bir sadece 1 kere miras alabilir.
            //Interface ler 1 den fazla olabilir ancak miras islemi bir kere tanimlanir.

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string Surname { get; set; }

    }

    class Person2
    {
        
    }

    class Players:Person
    {
        public string Position { get; set; }

    }

    class Coach:Players
    {
        public string CoachPosition { get; set; }

    }
}
