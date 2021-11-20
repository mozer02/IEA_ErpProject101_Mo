using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solid prensiplerinden 4. su olan Interface Segragation prensibini kullandik.

            //Single Responsibility: Siniflarimizin iyi tanimlanmis tek bir sorumlulugu olmali.
            //Open / Closed : Siniflarin degisiklige kapali ancak yeni davranislarin eklenmesine acik olmali.
            //Liskov Substitution : Kodumuzda herhangi bir degisiklik yapmaya gerek kalmadan turetilmis siniflarin (sub class) turedikleri ata sinifin(base class) yerine kullanabilmeliyiz.
            //Interface Segregation : Genel kullanim amacli tek bir kontrat yerine daha ozellesmis birdan cok kontrat olusturmayi tercih etmeliyiz.
            //Dependency Inversion: Katmanli mimarilerde ust seviye moduller alt seviyedeki modullere dogrudan bagimli olmamalidir.
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Warker : IWorker, IEat, ISalary

    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
