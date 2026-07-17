namespace Day02_PlayerBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "Knight";
            int hp = 100;
            int attack = 20;
            int defense = 8;
            int gold = 50;
            int exp = 0;

            hp -= 25;
            Console.WriteLine(hp);

            gold += 80;
            Console.WriteLine(gold);

            attack += 5;
            hp += 30;
            exp += 100;

            Console.WriteLine("攻击力：" + attack);
            Console.WriteLine("血量：" + hp);
            Console.WriteLine("经验：" + exp);

            int potion = 3;

            potion--;
            hp += 40;

            Console.WriteLine("剩余血瓶：" + potion);
            Console.WriteLine("剩余血量：" + hp);
        }
    }
}
