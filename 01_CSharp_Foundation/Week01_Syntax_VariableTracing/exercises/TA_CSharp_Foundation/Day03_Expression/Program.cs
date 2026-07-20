namespace Day03_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("第一题==========");
            int a = 7;
            int b = 3;

            int c = a + b * 2;
            //c = 6+7 = 13
            a += c / 4;
            //a = a + c / 4 = a + 3 = 10 
            b = a % 4 + b;
            // b = 5

            Console.WriteLine($"{a},{b},{c}");
            Console.WriteLine("第二题==========");

            int x = 4;
            int y = x++ + 3;
            //y = 8
            int z = ++x + y--;
            //z = 12
            x += z % 4;
            //x = 4

            Console.WriteLine($"x={x},y={y},z={z}");
            Console.WriteLine("第三题==========");

            int textureCount = 17;
            int batchSize = 4;

            int fullBatches = textureCount / batchSize;
            //fullBatches = 17/4 = 4
            int remainder = textureCount % batchSize;
            //reaminder = 17 % 4 = 1
            textureCount -= fullBatches * 2;
            //textureCount = textureCount - fullBatches * 2
            //             = 17 - 4 * 2 
            //             = 9

            Console.WriteLine(
                $"Textures:{textureCount}, Batches:{batchSize},Reamaining:{remainder}"
                );
            Console.WriteLine("第四题==========");
            int warningCount = 0;
            int size = 2048;

            bool firstCheck = size > 1024 && warningCount++ == 0;
            //fales
            //应该是ture
            bool secondCheck = size < 4096 || ++warningCount > 10;
            //ture
            bool thirdCheck = !firstCheck || warningCount++ > 0;
            //ture

            Console.WriteLine(
                $"{firstCheck}|{secondCheck}|{thirdCheck}|{warningCount}"
            );

            Console.WriteLine("第五题==========");
            int r = 5;
            int g = 8;
            int q = 2;

            int total = (r += 3) + (g -= 2) * q;
            // 8+6*2 =20
            q += total % 5;
            //b=2
            r = g++ + --q;
            //r 8+1=9

            Console.WriteLine($"R:{r} G:{g} Q:{q} Total:{total}");



            #endregion

            Console.WriteLine("");
            Console.WriteLine("======今日作业==========");
            Console.WriteLine("");

            int 玩家攻击力 = 37;
            int 武器加成 = 11;
            int 连击倍率 = 3;
            int 敌人防御力 = 14;
            int 护甲穿透 = 5;
            int 玩家当前体力 = 23;
            int 本次攻击体力消耗 = 7;
            int 敌人当前生命值 = 96;

            int 基础攻击力 = 玩家攻击力 + 武器加成;
            int 连击伤害 = 基础攻击力 *= 连击倍率;
            int 实际总伤害 = (基础攻击力 + 连击伤害) - (敌人防御力 - 护甲穿透);
            int 敌人剩余血量 = 敌人当前生命值 - 实际总伤害;
            int 玩家剩余血量 = 玩家当前体力 - 本次攻击体力消耗;
            bool 获胜 = 敌人剩余血量 <= 0 && 玩家剩余血量 >= 0;
            bool 是否能再次攻击 = 玩家剩余血量 > 本次攻击体力消耗;


            Console.WriteLine(
                $"【原始数据】玩家攻击力：{玩家攻击力}，武器加成：{武器加成}，连击倍率：{连击倍率}"
            );

            Console.WriteLine(
                $"【原始数据】敌人生命值：{敌人当前生命值}，敌人防御力：{敌人防御力}，护甲穿透：{护甲穿透}"
            );

            Console.WriteLine(
                $"【原始数据】玩家当前体力：{玩家当前体力}，本次攻击体力消耗：{本次攻击体力消耗}"
            );

            Console.WriteLine($"【中间结果】基础攻击力：{基础攻击力}");

            Console.WriteLine(
                $"【中间结果】连击伤害：{连击伤害}"
            );

            Console.WriteLine(
                $"【中间结果】实际总伤害：{实际总伤害}，敌人剩余血量：{敌人剩余血量}"
            );

            Console.WriteLine($"【中间结果】玩家剩余体力：{玩家剩余血量}");

            Console.WriteLine($"【最终状态】敌人是否被击败：{获胜}");

            Console.WriteLine($"【最终状态】玩家是否能再次攻击：{是否能再次攻击}");



        }
    }
}
