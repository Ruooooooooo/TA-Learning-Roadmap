namespace 练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playName = "Artist";
            int level = 1;
            int hp = 100;
            int attack = 18;
            float moveSpeed = 4.5f;
            bool isAlive = true;
            int exp = 80;

            Console.WriteLine("================");
            Console.WriteLine("Player Status");
            Console.WriteLine("================");
            Console.WriteLine("");
            Console.WriteLine("Name:" + playName);
            Console.WriteLine("Level:" + level);
            Console.WriteLine("HP:" + hp);
            Console.WriteLine("Attack:" + attack);
            Console.WriteLine("Move Speed:" + moveSpeed);
            Console.WriteLine("Alive:" + isAlive);
            Console.WriteLine("Current EXP:" + exp);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("升级========================================");
            Console.WriteLine("");
            Console.WriteLine("Level:" + (level + 1));
            Console.WriteLine("HP:" + (hp + 20));
            Console.WriteLine("Attack:" + (attack + 5));
            Console.WriteLine("Move Speed:" + (moveSpeed + 0.5f));
            Console.WriteLine("Current EXP:" + (exp += 30));

        }
    }
}
