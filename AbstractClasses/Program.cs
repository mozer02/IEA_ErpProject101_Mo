using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new MsSql();
            database.Add();
            database.Deleted();
            Database database2 = new Oracle();
            database2.Add();
            database2.Deleted();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        //Abstract classlar ile hem tamamlanmis hemde tamamlanmamis metodlar tanimlayabiliriz.
        //Abstract class lar birer inheritance dir. Bu yuzden her class icin bir kez kullanilir sinrasinda interface lerimiz var ise ekleyebiliriz. Abstract class lar new keywordu alamazlar.
        public void Add() // Tamamlanmis metod
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Deleted(); //Tamamlanmamis metod
    }

    class MsSql:Database
    {
        //Abstract dedigimiz sey ici dolu olmaya virtual metoddur.
        public override void Deleted()
        {
            Console.WriteLine("Deleted by MsSql");
        }
    }

    class Oracle : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
