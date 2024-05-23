﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Barracks
    {
        private int count = 0;
        public void Create()
        {
            while (count < 5)
            {
                int select=Convert.ToInt32(Console.ReadLine());
                Unit unit = null;
                switch(select)
                {
                    case 0:
                        unit = new Marine();
                        unit.Show();
                        break;

                    case 1:
                        unit = new Firebet();
                        unit.Show();
                        break;

                    case 2:
                        unit = new Ghost();
                        unit.Show();
                        break;

                    default:
                        continue;
                }
                unit.Show();
                count++;
                Console.WriteLine("count의 값 : " + count);
            }
        }
    }
}
