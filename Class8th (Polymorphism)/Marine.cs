namespace Class8th__Polymorphism_
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
