using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            sql sql = new sql();
            sql.Add();
            sql.Deleted();

            mySql mySql = new mySql();
            mySql.Add();
            mySql.Deleted();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }

        public virtual void Deleted()
        {
            Console.WriteLine("Deleted by Default");
        }
    }

    class sql:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }

    class mySql:Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by mySql Code");
            //base.Deleted();
        }
    }
}
