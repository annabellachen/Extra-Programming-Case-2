using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPlayer = Convert.ToInt32(Console.ReadLine());
            int[] player = new int[NumberOfPlayer];
            bool check=false;
            for (int i = 0; i < NumberOfPlayer;i++ )
            {
                player[i] = 1;
            }
            
            do{
                Console.WriteLine("\t\tREPORT\n");
                Console.WriteLine("PLAYER".PadLeft(11,' ')+"\t  LOCATION");
                Console.WriteLine("\n");
                for (int j = 0; j < NumberOfPlayer; j++)
                {
                    
                    Console.WriteLine("\t{0}\t\t{1}",j+1,player[j]);
                }
                    

                player=Game(player);
                for (int i = 0; i < NumberOfPlayer; i++)
                {
                    if(player[i]>=100)
                    {
                        Console.WriteLine("Finish by "+(i+1));
                        check=true;
                    }                    
                }
            }while(check==false);
            
            
            //while (true)
            //{
            //    for (int i = 0; i < NumberOfPlayer; i++)
            //    { 
                    
            //    }
            //}

        }
        static int[] Game(int[] player)
        {
            int num=player.Length;
            Random ran = new Random();
            int dice;
            //int[] result = new int[num];
            int[,] ladder = new int[8,2] { { 1, 8 }, { 4, 14 }, { 9, 31 }, { 21, 42 }, { 28, 84 }, { 51, 67 }, { 71, 91 }, { 80, 100 } };
            int[,] snake = new int[8, 2] { { 7, 17 }, { 19, 62 }, { 24, 87 }, { 34, 54 }, { 60, 64 }, { 73, 93 }, { 75, 95 }, { 79, 98 } };
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Press to continue: Player "+(i+1));
                Console.ReadLine();
                dice=Dice(ran);
                player[i] = player[i] + dice;
                for(int j=0;j<8;j++)
                {
                    if (player[i] == ladder[j, 0])
                        player[i] = ladder[j, 1];
                    else if (player[i] == snake[j, 0])
                        player[i] = snake[j, 1];
                }               
            }
                return player;
        }
        static int Dice(Random ran)//never put statement for random in the loop, or the same result will show up again.
        {
            int n=ran.Next(1,7);
            return n;
        }
    }
}
