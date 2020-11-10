using System;
using System.Text.Encodings;
using System.Collections.Generic;
using System.Text;
using System.Text.Unicode;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Threading;

namespace FunctionsMethods
{
    class Program
    {
        int height = 20;
        int width = 30;

        int[] X = new int[50];
        int[] Y = new int[50];

        int fruitX;
        int fruitY;

        int parts = 3;

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'W';

        Random rnd = new Random();

        Program()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            fruitX = rnd.Next(2, (width - 2));
            fruitY = rnd.Next(2, (height - 2));
        }
        public void TextBoard()
        {
            Console.Clear();
            for(int i = 1; i < (width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i < (width + 2); i++)
            {
                Console.SetCursorPosition(i, (height+2));
                Console.Write("-");
            }
            for (int i = 1; i < (height + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 1; i < (height + 1); i++)
            {
                Console.SetCursorPosition((width+2), i);
                Console.Write("|");
            }
        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }
        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("T");
        }

        public void Logic()
        {
            if(X[0] == fruitX)
            {
                if(Y[0] == fruitY)
                {
                    parts++;
                    fruitX = rnd.Next(2, (width-2));
                    fruitY = rnd.Next(2, (height - 2));
                }
            }
            for(int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'd':
                    X[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;
            }
            for(int i = 0; i <= (parts - 1); i++)
            {
                WritePoint(X[i], Y[i]);
                WritePoint(fruitX, fruitY);

            }
            Thread.Sleep(100);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            beginning:
            char uInput; 
            UsefullTools.Velkomst();
            UsefullTools.Linje();


            Console.Write("Ønsker du at spille?\ny/n? ");
            uInput = Convert.ToChar(Console.ReadLine());

            if(uInput == 'y')
            {
                Console.Clear();
                UsefullTools.Bane();
                Program snake = new Program();
                while (true)
                {
                    snake.TextBoard();
                    snake.Input();
                    snake.Logic();
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Tak for denne gang");
                Environment.Exit(0);
                Console.ReadKey();
                //goto beginning;
            }

            
        }
    }
}
