namespace Day04_MethodScopeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //static int AddCharge(int energy, int bonus)
            //{
            //    energy += bonus;
            //    return energy;
            //}

            //int energy = 20;
            //int nextEnergy = AddCharge(energy, 5);

            //Console.WriteLine($"{energy},{nextEnergy}");

            //static int Evaluate(int value)
            //{
            //    value *= 2;
            //    value += 3;
            //    return value;
            //}

            //int a = 4;
            //int b = Evaluate(a + 1);
            //a += b % 4;

            //Console.WriteLine($"{a},{b}");

            //static int Trim(int value)
            //{
            //    value -= 2;
            //    return value;
            //}

            //static int Score(int x, int y)
            //{
            //    int result = Trim(x) + Trim(y);
            //    return result;
            //}

            //int x = 8;
            //int y = 5;
            //int result = Score(Trim(x), y);

            //Console.WriteLine($"{x},{y},{result}");


            //static int ConvertSize(int size)
            //{
            //    int level = size / 4;
            //    level = 19 / 4 = 5
            //    return level + size % 4;
            //    5 + 3 = 8
            //}

            //int size = 19;
            //int level = ConvertSize(size);
            //level = 8

            //{
            //    int extra = ConvertSize(level);
            //    Console.WriteLine($"{size},{level},{extra}");
            //}

            //Console.WriteLine(level);
            #endregion

            Console.WriteLine("今日作业========================");

            RunExerciseA();

        }

            static int CalculateEnergyCost(int baseCost, int extraCost)
            {
                int finallyCost = baseCost + extraCost;

                return finallyCost;
            }

        static bool CanUseSkill(int currentEnergy, int energyCost)
        {
            if (currentEnergy < energyCost)
            {
                return false;
            }

            else 
            {
                return true; 
            }
        }

            static void RunExerciseA()
            {
                string PlayerName = "若见花";
                int Playerattack = 35;
                int Playerenergy = 70;
                int erenergy = Playerenergy;

                string monsterName = "石头人";
                int Monsterlife = 120;
                int Monsterdefanse = 18;

                string SkillName1 = "Arc Slash";
                int SkillPower1 = 30;
                int EnergyConsumption1 = 20;
                bool criticalHit1 = false;
                int skill1ExtraCost1 = 0;
                int skill1FinalCost = CalculateEnergyCost(EnergyConsumption1, skill1ExtraCost1);

                string SkillName2 = "Burst Edge";
                int SkillPower2 = 45;
                int EnergyConsumption2 = 25;
                bool criticalHit2 = true;
                int skillExtraCost2 = 10;
                int skill2FinalCost = CalculateEnergyCost(EnergyConsumption2, skillExtraCost2);

                Console.WriteLine("玩家：" + PlayerName);
                Console.WriteLine("攻击力：" + Playerattack);
                Console.WriteLine("当前能量：" + Playerenergy);
                Console.WriteLine("敌人：" + monsterName);
                Console.WriteLine("防御力：" + Monsterdefanse);
                Console.WriteLine("当前生命：" + Monsterlife);

                bool canUseSkill = CanUseSkill(Playerenergy, skill1FinalCost);
                Console.WriteLine("第一技能是否能释放：" + canUseSkill);

                if (canUseSkill == true) 
                {
                    erenergy = erenergy - skill1FinalCost;
                    Console.WriteLine("技能释放成功");
                }
                else 
                {
                Console.WriteLine("技能释放失败");
                }

            }
        }
    }
