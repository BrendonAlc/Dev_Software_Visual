using System;
using Aula_04;

namespace Aula_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario("brendon", "123456");
            Usuario q = new Usuario("luciana", "789456");
            //Console.WriteLine($"{u.GetUsername()},{u.GetHash()}");
            //Console.WriteLine("{0},{1}", u.GetUsername,u.GetHash);
            //Console.WriteLine(u.Serialize());
            UserBase myBase = new UserBase("userbase.txt");
            myBase.AddUser(u);
            myBase.AddUser(q);
            myBase.Save();
        }
    }
}
