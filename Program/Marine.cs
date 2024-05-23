using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Marine : Unit
    {
        private int steamPack;

        public Marine() {
            health = 40;
            attack = 5;
            defense = 0;

            steamPack = 5;

            Console.WriteLine("Create Marine");
        }

        new public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }

        override public void Show()
        {
            Console.WriteLine("Marine health 변수의 값 : " + health);
            Console.WriteLine("Marine attack 변수의 값 : " + attack);
            Console.WriteLine("Marine defense 변수의 값 : " + defense);
            Console.WriteLine();
        }
    }
}
