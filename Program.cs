using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gameapp
{
    class printmaze
    {

        public void maze()
        {

            Console.WriteLine("           _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _      ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("          |                                                                                                                                                  |    ");
            Console.WriteLine("           _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _      ");



        }
    }


    class player
    {

        public int px;
        public int py;

        public player(int Px, int Py)
        {

            px = Px;
            py = Py;
        }
        public void printplayer()
        {

            Console.SetCursorPosition(px, py);
            Console.Write('P');

        }
        public void eraseplayer()
        {

            Console.SetCursorPosition(px, py);
            Console.Write(' ');

        }




        public void moveplayer()
        {
            eraseplayer();
            if (px <= 60)
            {
                px += 1;

            }
            if (px == 61)
            {
                px = 12;
            }
            printplayer();

        }
    }
    class enemy
    {
        public int ex;
        public int ey;

        public enemy(int Ex, int Ey)
        {


            ex = Ex;
            ey = Ey;
        }

        public void printenemy()
        {

            Console.SetCursorPosition(ex, ey);
            Console.Write('E');

        }

        public void eraseenemy()
        {

            Console.SetCursorPosition(ex, ey);
            Console.Write(' ');

        }



        public void moveenemy()
        {
            eraseenemy();
            if (ex > 15)
            {
                ex -= 3;

            }
            else
            {
                ex = 15;
            }
            printenemy();

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.CursorVisible = false;



            printmaze g = new printmaze();
            player p = new player(12, 10);
            enemy e = new enemy(105, 20);


            g.maze();
            p.printplayer();
            e.printenemy();

            while (true)
            {
                p.moveplayer();
                e.moveenemy();
                Thread.Sleep(500);
            }




        }
    }
}


