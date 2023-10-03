using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_testing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int[] line1 = new int[30];
            int[] line2 = new int[30];
            int[] line3 = new int[30];
            Random num = new Random();
            int index, number, index2, index3, score, count2, index4, index5, cursorx2, cursorx3;
            int randomarray, count = 0;
            int cursorx = 1, cursory = 1;
            ConsoleKeyInfo cki;
            score = 0;

            Console.WriteLine();
            Console.WriteLine("                               __      __       .__                             ._.");
            Console.WriteLine("                              /  \\    /  \\ ____ |  |   ____  ____   _____   ____| |");
            Console.WriteLine("                              \\   \\/\\/   // __ \\|  | _/ ___\\/  _ \\ /     \\_/ __ \\ |");
            Console.WriteLine("                               \\        /\\  ___/|  |_\\  \\__(  <_> )  Y Y  \\  ___/\\|");
            Console.WriteLine("                                \\__/\\  /  \\___  >____/\\___  >____/|__|_|  /\\___  >_");
            Console.WriteLine("                                     \\/       \\/          \\/            \\/     \\/\\/");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                      _____    _____           _______   _______          ________  ________");
            Console.WriteLine("                     / __  \\  / __  \\         /  ___  \\ /  ___  \\        |\\_____  \\|\\_____  \\");
            Console.WriteLine("                    |\\/_|\\  \\|\\/_|\\  \\       /__/|_/  //__/|_/  /|       \\|____|\\ /\\|____|\\ /");
            Console.WriteLine("                    \\|/ \\ \\  \\|/ \\ \\  \\      |__|//  / /__|//  / /             \\|\\  \\    \\|\\  \\ ");
            Console.WriteLine("                         \\ \\  \\   \\ \\  \\         /  /_/__  /  /_/__           __\\_\\  \\  __\\_\\  \\");
            Console.WriteLine("                          \\ \\__\\   \\ \\__\\       |\\________\\\\________\\        |\\_______\\|\\_______\\");
            Console.WriteLine("                           \\|__|    \\|__|        \\|_______|\\|_______|        \\|_______|\\|_______|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                             ________                      ");
            Console.WriteLine("                                            /  _____/_____    _____   ____ ");
            Console.WriteLine("                                           /   \\  ___\\__  \\  /     \\_/ __ \\ ");
            Console.WriteLine("                                           \\    \\_\\  \\/ __ \\|  Y Y  \\  ___/");
            Console.WriteLine("                                            \\______  (____  /__|_|  /\\___  >");
            Console.WriteLine("                                                   \\/     \\/      \\/     \\/");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                             ► PRESS ANY KEY TO CONTINUE. ◄");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("╔══════════════════════════════╗");
            Console.Write("║");

            while (count != 30)
            {
                randomarray = num.Next(1, 4);
                index = num.Next(0, 30);
                number = num.Next(1, 4);
                if (randomarray == 1)
                {
                    if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                    {
                        index = num.Next(0, 30);
                        number = num.Next(1, 4);
                        if (line1[index] == 1 || line1[index] == 2 || line1[index] == 3)
                        {
                            while (line1[index] != 0)
                            {
                                index = num.Next(0, 30);
                                number = num.Next(1, 4);
                            }
                        }
                        line1[index] = number;
                        count++;
                    }
                    else
                    {
                        line1[index] = number;
                        count++;
                    }
                }
                if (randomarray == 2)
                {
                    if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                    {
                        index = num.Next(0, 30);
                        number = num.Next(1, 4);
                        if (line2[index] == 1 || line2[index] == 2 || line2[index] == 3)
                        {
                            while (line2[index] != 0)
                            {
                                index = num.Next(0, 30);
                                number = num.Next(1, 4);
                            }
                        }
                        line2[index] = number;
                        count++;
                    }
                    else
                    {
                        line2[index] = number;
                        count++;
                    }
                }
                if (randomarray == 3)
                {
                    if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                    {
                        index = num.Next(0, 30);
                        number = num.Next(1, 4);
                        if (line3[index] == 1 || line3[index] == 2 || line3[index] == 3)
                        {
                            while (line3[index] != 0)
                            {
                                index = num.Next(0, 30);
                                number = num.Next(1, 4);
                            }
                        }
                        line3[index] = number;
                        count++;
                    }
                    else
                    {
                        line3[index] = number;
                        count++;
                    }
                }
            }

            count2 = 0;
            index2 = 0;
            index3 = 1;
            while (index3 != 30)
            {
                if (line1[index2] == line1[index3] && line1[index2] != 0 && line1[index3] != 0)
                {
                    line1[index3] = 0;
                    number = num.Next(1, 4);
                    line1[index3] = number;
                    if (line1[index2] == line1[index3])
                    {
                        while (line1[index2] == line1[index3])
                        {
                            number = num.Next(1, 4);
                            line1[index3] = number;
                        }
                    }
                    index2++;
                    index3++;
                }
                else
                {
                    index2++;
                    index3++;
                }
            }

            count2 = 0;
            index2 = 0;
            index3 = 1;
            while (index3 != 30)
            {
                if (line2[index2] == line2[index3] && line2[index2] != 0 && line2[index3] != 0)
                {
                    line2[index3] = 0;
                    number = num.Next(1, 4);
                    line2[index3] = number;
                    if (line2[index2] == line2[index3])
                    {
                        while (line2[index2] == line2[index3])
                        {
                            number = num.Next(1, 4);
                            line2[index3] = number;
                        }
                    }
                    index2++;
                    index3++;
                }
                else
                {
                    index2++;
                    index3++;
                }

            }

            count2 = 0;
            index2 = 0;
            index3 = 1;
            while (index3 != 30)
            {
                if (line3[index2] == line3[index3] && line3[index2] != 0 && line3[index3] != 0)
                {
                    line3[index3] = 0;
                    number = num.Next(1, 4);
                    line3[index3] = number;
                    if (line3[index2] == line3[index3])
                    {
                        while (line3[index2] == line3[index3])
                        {
                            number = num.Next(1, 4);
                            line3[index3] = number;
                        }
                    }
                    index2++;
                    index3++;
                }
                else
                {
                    index2++;
                    index3++;
                }
            }

            Console.SetCursorPosition(1, 1);
            for (int i = 0; i < line1.Length; i++)
            {
                if (line1[i] > 0)
                {
                    Console.Write(line1[i]);
                }
                else if (line1[i] == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("║ Score: " + score);
            Console.WriteLine();
            Console.Write("║");
            for (int i = 0; i < line2.Length; i++)
            {
                if (line2[i] > 0)
                {
                    Console.Write(line2[i]);
                }
                else if (line2[i] == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("║");
            Console.WriteLine();
            Console.Write("║");
            for (int i = 0; i < line3.Length; i++)
            {
                if (line3[i] > 0)
                {
                    Console.Write(line3[i]);
                }
                else if (line3[i] == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("║");
            Console.WriteLine();
            Console.Write("╚══════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
            Console.SetCursorPosition(1, 1);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    if (cki.Key == ConsoleKey.RightArrow && cursorx <= 30)
                    {
                        cursorx++;
                        if (cursorx > 30)
                        {
                            cursorx--;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    if (cki.Key == ConsoleKey.LeftArrow && cursorx > 0)
                    {
                        cursorx--;
                        if (cursorx < 1)
                        {
                            cursorx++;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    if (cki.Key == ConsoleKey.UpArrow && cursory > 0)
                    {
                        cursory--;
                        if (cursory < 1)
                        {
                            cursory++;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    if (cki.Key == ConsoleKey.DownArrow && cursory < 4)
                    {
                        cursory++;
                        if (cursory > 3)
                        {
                            cursory--;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (cki.Key == ConsoleKey.W && cursory > 2)
                    {
                        int temp_number;
                        cursorx--;
                        cursorx2 = cursorx - 1;
                        if (cursorx2 == -1)
                        {
                            cursorx2 = cursorx2 + 2;
                        }
                        cursorx3 = cursorx + 1;
                        if (cursorx3 == 30)
                        {
                            cursorx3 = cursorx3 - 2;
                        }
                        if (line3[cursorx] != 0 && line2[cursorx] == 0 && line3[cursorx2] == 0 && line3[cursorx3] == 0)
                        {
                            if (cursorx2 == 1)
                            {
                                cursorx2 = cursorx2 - 2;
                            }
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }

                            temp_number = line3[cursorx];
                            line3[cursorx] = 0;
                            cursory--;
                            line2[cursorx] = temp_number;
                            count2 = 0;
                            if (cursorx2 >= 0)
                            {
                                if (line2[cursorx] == line2[cursorx2] && line2[cursorx2] != 0)
                                {
                                    line2[cursorx] = 0;
                                    line2[cursorx2] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line2[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line2[index] = number;
                                                if (line2[index] != line2[index4] && line2[index] != line2[index5])
                                                {
                                                    line2[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line2[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (cursorx3 < 30)
                            {
                                if (line2[cursorx] == line2[cursorx3] && line2[cursorx3] != 0)
                                {
                                    line2[cursorx] = 0;
                                    line2[cursorx3] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line2[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line2[index] = number;
                                                if (line2[index] != line2[index4] && line2[index] != line2[index5])
                                                {
                                                    line2[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line2[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            cursorx++;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════╗");
                            Console.Write("║");
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║ Score: " + score);
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("╚══════════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursorx++;
                        }
                    }
                    else if (cki.Key == ConsoleKey.W && cursory > 1)
                    {
                        int temp_number;
                        cursorx--;
                        cursorx2 = cursorx - 1;
                        if (cursorx2 == -1)
                        {
                            cursorx2 = cursorx2 + 2;
                        }
                        cursorx3 = cursorx + 1;
                        if (cursorx3 == 30)
                        {
                            cursorx3 = cursorx3 - 2;
                        }
                        if (line2[cursorx] != 0 && line1[cursorx] == 0 && line2[cursorx2] == 0 && line2[cursorx3] == 0)
                        {
                            if (cursorx2 == 1)
                            {
                                cursorx2 = cursorx2 - 2;
                            }
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }

                            temp_number = line2[cursorx];
                            line2[cursorx] = 0;
                            cursory--;
                            line1[cursorx] = temp_number;
                            count2 = 0;
                            if (cursorx2 >= 0)
                            {
                                if (line1[cursorx] == line1[cursorx2] && line1[cursorx2] != 0)
                                {
                                    line1[cursorx] = 0;
                                    line1[cursorx2] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line1[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line1[index] = number;
                                                if (line1[index] != line1[index4] && line1[index] != line1[index5])
                                                {
                                                    line1[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line1[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (cursorx3 < 30)
                            {
                                if (line1[cursorx] == line1[cursorx3] && line1[cursorx3] != 0)
                                {
                                    line1[cursorx] = 0;
                                    line1[cursorx3] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line1[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line1[index] = number;
                                                if (line1[index] != line1[index4] && line1[index] != line1[index5])
                                                {
                                                    line1[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line1[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            cursorx++;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════╗");
                            Console.Write("║");
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║ Score: " + score);
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("╚══════════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursorx++;
                        }
                    }
                    else if (cki.Key == ConsoleKey.D && cursorx >= 1 && cursorx < 30)
                    {
                        int temp_number;
                        cursorx--;
                        cursorx3 = cursorx - 1;
                        if (cursorx3 == -1)
                        {
                            cursorx3 = cursorx3 + 2;
                        }
                        if (line1[cursorx] != 0 && cursory == 1 && line1[cursorx3] == 0)
                        {
                            if (cursorx3 == 1)
                            {
                                cursorx3 = cursorx3 - 2;
                            }
                            cursorx++;
                            if (line1[cursorx] == 0)
                            {
                                cursorx--;
                                temp_number = line1[cursorx];

                                line1[cursorx] = 0;
                                cursorx++;
                                while (line1[cursorx] == 0)
                                {
                                    cursorx++;
                                    if (cursorx == 30)
                                    {
                                        break;
                                    }
                                }

                                cursorx--;
                                line1[cursorx] = temp_number;
                                cursorx2 = cursorx + 1;
                                count2 = 0;
                                if (cursorx2 < 30)
                                {
                                    if (line1[cursorx] == line1[cursorx2])
                                    {
                                        line1[cursorx] = 0;
                                        line1[cursorx2] = 0;
                                        score = score + 10;
                                        while (count2 != 2)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            index4 = index - 1;
                                            index5 = index + 1;

                                            if (line1[index] == 0)
                                            {
                                                if (index4 >= 0 && index5 <= 29)
                                                {
                                                    line1[index] = number;
                                                    if (line1[index] != line1[index4] && line1[index] != line1[index5])
                                                    {
                                                        line1[index] = number;
                                                        count2++;
                                                    }
                                                    else
                                                    {
                                                        line1[index] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                cursorx++;
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════╗");
                                Console.Write("║");
                                for (int i = 0; i < line1.Length; i++)
                                {
                                    if (line1[i] > 0)
                                    {
                                        Console.Write(line1[i]);
                                    }
                                    else if (line1[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║ Score: " + score);
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line2.Length; i++)
                                {
                                    if (line2[i] > 0)
                                    {
                                        Console.Write(line2[i]);
                                    }
                                    else if (line2[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line3.Length; i++)
                                {
                                    if (line3[i] > 0)
                                    {
                                        Console.Write(line3[i]);
                                    }
                                    else if (line3[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("╚══════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                                Console.SetCursorPosition(cursorx, cursory);
                                cursorx--;
                            }
                            else
                            {
                                cursorx--;
                                Console.SetCursorPosition(cursorx, cursory);
                            }
                        }
                        if (line2[cursorx] != 0 && cursory == 2 && line2[cursorx3] == 0)
                        {
                            if (cursorx3 == 1)
                            {
                                cursorx3 = cursorx3 - 2;
                            }
                            cursorx++;
                            if (line2[cursorx] == 0)
                            {
                                cursorx--;
                                temp_number = line2[cursorx];
                                line2[cursorx] = 0;
                                cursorx++;
                                while (line2[cursorx] == 0)
                                {
                                    cursorx++;
                                    if (cursorx == 30)
                                    {
                                        break;
                                    }
                                }

                                cursorx--;
                                line2[cursorx] = temp_number;
                                cursorx2 = cursorx + 1;
                                count2 = 0;
                                if (cursorx2 < 30)
                                {
                                    if (line2[cursorx] == line2[cursorx2])
                                    {
                                        line2[cursorx] = 0;
                                        line2[cursorx2] = 0;
                                        score = score + 10;
                                        while (count2 != 2)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            index4 = index - 1;
                                            index5 = index + 1;

                                            if (line2[index] == 0)
                                            {
                                                if (index4 >= 0 && index5 <= 29)
                                                {
                                                    line2[index] = number;
                                                    if (line2[index] != line2[index4] && line2[index] != line2[index5])
                                                    {
                                                        line2[index] = number;
                                                        count2++;
                                                    }
                                                    else
                                                    {
                                                        line2[index] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                cursorx++;
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════╗");
                                Console.Write("║");
                                for (int i = 0; i < line1.Length; i++)
                                {
                                    if (line1[i] > 0)
                                    {
                                        Console.Write(line1[i]);
                                    }
                                    else if (line1[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║ Score: " + score);
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line2.Length; i++)
                                {
                                    if (line2[i] > 0)
                                    {
                                        Console.Write(line2[i]);
                                    }
                                    else if (line2[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line3.Length; i++)
                                {
                                    if (line3[i] > 0)
                                    {
                                        Console.Write(line3[i]);
                                    }
                                    else if (line3[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("╚══════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                                Console.SetCursorPosition(cursorx, cursory);
                                cursorx--;
                            }
                            else
                            {
                                cursorx--;
                                Console.SetCursorPosition(cursorx, cursory);

                            }
                        }
                        if (line3[cursorx] != 0 && cursory == 3 && line3[cursorx3] == 0)
                        {
                            if (cursorx3 == 1)
                            {
                                cursorx3 = cursorx3 - 2;
                            }
                            cursorx++;
                            if (line3[cursorx] == 0)
                            {
                                cursorx--;
                                temp_number = line3[cursorx];
                                line3[cursorx] = 0;
                                cursorx++;
                                while (line3[cursorx] == 0)
                                {
                                    cursorx++;
                                    if (cursorx == 30)
                                    {
                                        break;
                                    }
                                }

                                cursorx--;
                                line3[cursorx] = temp_number;
                                cursorx2 = cursorx + 1;
                                count2 = 0;
                                if (cursorx2 < 30)
                                {
                                    if (line3[cursorx] == line3[cursorx2])
                                    {
                                        line3[cursorx] = 0;
                                        line3[cursorx2] = 0;
                                        score = score + 10;
                                        while (count2 != 2)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            index4 = index - 1;
                                            index5 = index + 1;

                                            if (line3[index] == 0)
                                            {
                                                if (index4 >= 0 && index5 <= 29)
                                                {
                                                    line3[index] = number;
                                                    if (line3[index] != line3[index4] && line3[index] != line3[index5])
                                                    {
                                                        line3[index] = number;
                                                        count2++;
                                                    }
                                                    else
                                                    {
                                                        line3[index] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                cursorx++;
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════╗");
                                Console.Write("║");
                                for (int i = 0; i < line1.Length; i++)
                                {
                                    if (line1[i] > 0)
                                    {
                                        Console.Write(line1[i]);
                                    }
                                    else if (line1[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║ Score: " + score);
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line2.Length; i++)
                                {
                                    if (line2[i] > 0)
                                    {
                                        Console.Write(line2[i]);
                                    }
                                    else if (line2[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line3.Length; i++)
                                {
                                    if (line3[i] > 0)
                                    {
                                        Console.Write(line3[i]);
                                    }
                                    else if (line3[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("╚══════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                                Console.SetCursorPosition(cursorx, cursory);
                                cursorx--;
                            }
                            else
                            {
                                cursorx--;
                                Console.SetCursorPosition(cursorx, cursory);
                            }
                        }
                        cursorx++;
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (cki.Key == ConsoleKey.A && cursorx < 31 && cursorx >= 2)
                    {
                        int temp_number;
                        cursorx--;
                        cursorx3 = cursorx + 1;
                        if (cursorx3 == 30)
                        {
                            cursorx3 = cursorx3 - 2;
                        }
                        if (line1[cursorx] != 0 && cursory == 1 && line1[cursorx3] == 0)
                        {
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }
                            cursorx--;
                            if (line1[cursorx] == 0)
                            {
                                cursorx++;
                                temp_number = line1[cursorx];
                                line1[cursorx] = 0;
                                cursorx--;
                                while (line1[cursorx] == 0)
                                {
                                    cursorx--;
                                    if (cursorx == -1)
                                    {
                                        break;
                                    }
                                }

                                cursorx++;
                                line1[cursorx] = temp_number;
                                cursorx2 = cursorx - 1;
                                count2 = 0;
                                if (cursorx2 > -1)
                                {
                                    if (line1[cursorx] == line1[cursorx2])
                                    {
                                        line1[cursorx] = 0;
                                        line1[cursorx2] = 0;
                                        score = score + 10;
                                        while (count2 != 2)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            index4 = index - 1;
                                            index5 = index + 1;

                                            if (line1[index] == 0)
                                            {
                                                if (index4 >= 0 && index5 <= 29)
                                                {
                                                    line1[index] = number;
                                                    if (line1[index] != line1[index4] && line1[index] != line1[index5])
                                                    {
                                                        line1[index] = number;
                                                        count2++;
                                                    }
                                                    else
                                                    {
                                                        line1[index] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                cursorx++;
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════╗");
                                Console.Write("║");
                                for (int i = 0; i < line1.Length; i++)
                                {
                                    if (line1[i] > 0)
                                    {
                                        Console.Write(line1[i]);
                                    }
                                    else if (line1[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║ Score: " + score);
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line2.Length; i++)
                                {
                                    if (line2[i] > 0)
                                    {
                                        Console.Write(line2[i]);
                                    }
                                    else if (line2[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line3.Length; i++)
                                {
                                    if (line3[i] > 0)
                                    {
                                        Console.Write(line3[i]);
                                    }
                                    else if (line3[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("╚══════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                                Console.SetCursorPosition(cursorx, cursory);
                                cursorx--;
                            }
                            else
                            {
                                cursorx++;
                                Console.SetCursorPosition(cursorx, cursory);
                            }
                        }
                        else if (line2[cursorx] != 0 && cursory == 2 && line2[cursorx3] == 0)
                        {
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }
                            cursorx--;
                            if (line2[cursorx] == 0)
                            {
                                cursorx++;
                                temp_number = line2[cursorx];
                                line2[cursorx] = 0;
                                cursorx--;
                                while (line2[cursorx] == 0)
                                {
                                    cursorx--;
                                    if (cursorx == -1)
                                    {
                                        break;
                                    }
                                }

                                cursorx++;
                                line2[cursorx] = temp_number;
                                cursorx2 = cursorx - 1;
                                count2 = 0;
                                if (cursorx2 > -1)
                                {
                                    if (line2[cursorx] == line2[cursorx2])
                                    {
                                        line2[cursorx] = 0;
                                        line2[cursorx2] = 0;
                                        score = score + 10;
                                        while (count2 != 2)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            index4 = index - 1;
                                            index5 = index + 1;

                                            if (line2[index] == 0)
                                            {
                                                if (index4 >= 0 && index5 <= 29)
                                                {
                                                    line2[index] = number;
                                                    if (line2[index] != line2[index4] && line2[index] != line2[index5])
                                                    {
                                                        line2[index] = number;
                                                        count2++;
                                                    }
                                                    else
                                                    {
                                                        line2[index] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                cursorx++;
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════╗");
                                Console.Write("║");
                                for (int i = 0; i < line1.Length; i++)
                                {
                                    if (line1[i] > 0)
                                    {
                                        Console.Write(line1[i]);
                                    }
                                    else if (line1[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║ Score: " + score);
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line2.Length; i++)
                                {
                                    if (line2[i] > 0)
                                    {
                                        Console.Write(line2[i]);
                                    }
                                    else if (line2[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line3.Length; i++)
                                {
                                    if (line3[i] > 0)
                                    {
                                        Console.Write(line3[i]);
                                    }
                                    else if (line3[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("╚══════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                                Console.SetCursorPosition(cursorx, cursory);
                                cursorx--;
                            }
                            else
                            {
                                cursorx++;
                                Console.SetCursorPosition(cursorx, cursory);
                            }
                        }
                        else if (line3[cursorx] != 0 && cursory == 3 && line3[cursorx3] == 0)
                        {
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }
                            cursorx--;
                            if (line3[cursorx] == 0)
                            {
                                cursorx++;
                                temp_number = line3[cursorx];
                                line3[cursorx] = 0;
                                cursorx--;
                                while (line3[cursorx] == 0)
                                {
                                    cursorx--;
                                    if (cursorx == -1)
                                    {
                                        break;
                                    }
                                }

                                cursorx++;
                                line3[cursorx] = temp_number;
                                cursorx2 = cursorx - 1;
                                count2 = 0;
                                if (cursorx2 > -1)
                                {
                                    if (line3[cursorx] == line3[cursorx2])
                                    {
                                        line3[cursorx] = 0;
                                        line3[cursorx2] = 0;
                                        score = score + 10;
                                        while (count2 != 2)
                                        {
                                            index = num.Next(0, 30);
                                            number = num.Next(1, 4);
                                            index4 = index - 1;
                                            index5 = index + 1;

                                            if (line3[index] == 0)
                                            {
                                                if (index4 >= 0 && index5 <= 29)
                                                {
                                                    line3[index] = number;
                                                    if (line3[index] != line3[index4] && line3[index] != line3[index5])
                                                    {
                                                        line3[index] = number;
                                                        count2++;
                                                    }
                                                    else
                                                    {
                                                        line3[index] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                cursorx++;
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════╗");
                                Console.Write("║");
                                for (int i = 0; i < line1.Length; i++)
                                {
                                    if (line1[i] > 0)
                                    {
                                        Console.Write(line1[i]);
                                    }
                                    else if (line1[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║ Score: " + score);
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line2.Length; i++)
                                {
                                    if (line2[i] > 0)
                                    {
                                        Console.Write(line2[i]);
                                    }
                                    else if (line2[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("║");
                                for (int i = 0; i < line3.Length; i++)
                                {
                                    if (line3[i] > 0)
                                    {
                                        Console.Write(line3[i]);
                                    }
                                    else if (line3[i] == 0)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("║");
                                Console.WriteLine();
                                Console.Write("╚══════════════════════════════╝");
                                Console.WriteLine();
                                Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                                Console.SetCursorPosition(cursorx, cursory);
                                cursorx--;
                            }
                            else
                            {
                                cursorx++;
                                Console.SetCursorPosition(cursorx, cursory);
                            }
                        }
                        cursorx++;
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (cki.Key == ConsoleKey.S && cursory < 2)
                    {
                        int temp_number;
                        cursorx--;
                        cursorx2 = cursorx - 1;
                        if (cursorx2 == -1)
                        {
                            cursorx2 = cursorx2 + 2;
                        }
                        cursorx3 = cursorx + 1;
                        if (cursorx3 == 30)
                        {
                            cursorx3 = cursorx3 - 2;
                        }
                        if (line1[cursorx] != 0 && line2[cursorx] == 0 && line1[cursorx2] == 0 && line1[cursorx3] == 0)
                        {
                            if (cursorx2 == 1)
                            {
                                cursorx2 = cursorx2 - 2;
                            }
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }

                            temp_number = line1[cursorx];
                            line1[cursorx] = 0;
                            cursory++;
                            line2[cursorx] = temp_number;
                            count2 = 0;
                            if (cursorx2 >= 0)
                            {
                                if (line2[cursorx] == line2[cursorx2] && line2[cursorx2] != 0)
                                {
                                    line2[cursorx] = 0;
                                    line2[cursorx2] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line2[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line2[index] = number;
                                                if (line2[index] != line2[index4] && line2[index] != line2[index5])
                                                {
                                                    line2[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line2[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (cursorx3 < 30)
                            {
                                if (line2[cursorx] == line2[cursorx3] && line2[cursorx3] != 0)
                                {
                                    line2[cursorx] = 0;
                                    line2[cursorx3] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line2[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line2[index] = number;
                                                if (line2[index] != line2[index4] && line2[index] != line2[index5])
                                                {
                                                    line2[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line2[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            cursorx++;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════╗");
                            Console.Write("║");
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║ Score: " + score);
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("╚══════════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursorx++;
                        }
                    }
                    else if (cki.Key == ConsoleKey.S && cursory < 3)
                    {
                        int temp_number;
                        cursorx--;
                        cursorx2 = cursorx - 1;
                        if (cursorx2 == -1)
                        {
                            cursorx2 = cursorx2 + 2;
                        }
                        cursorx3 = cursorx + 1;
                        if (cursorx3 == 30)
                        {
                            cursorx3 = cursorx3 - 2;
                        }
                        if (line2[cursorx] != 0 && line3[cursorx] == 0 && line2[cursorx2] == 0 && line2[cursorx3] == 0)
                        {
                            if (cursorx2 == 1)
                            {
                                cursorx2 = cursorx2 - 2;
                            }
                            if (cursorx3 == 28)
                            {
                                cursorx3 = cursorx3 + 2;
                            }

                            temp_number = line2[cursorx];
                            line2[cursorx] = 0;
                            cursory++;
                            line3[cursorx] = temp_number;
                            count2 = 0;
                            if (cursorx2 >= 0)
                            {
                                if (line3[cursorx] == line3[cursorx2] && line3[cursorx2] != 0)
                                {
                                    line3[cursorx] = 0;
                                    line3[cursorx2] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line3[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line3[index] = number;
                                                if (line3[index] != line3[index4] && line3[index] != line3[index5])
                                                {
                                                    line3[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line3[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (cursorx3 < 30)
                            {
                                if (line3[cursorx] == line3[cursorx3] && line3[cursorx3] != 0)
                                {
                                    line3[cursorx] = 0;
                                    line3[cursorx3] = 0;
                                    score = score + 10;
                                    while (count2 != 2)
                                    {
                                        index = num.Next(0, 30);
                                        number = num.Next(1, 4);
                                        index4 = index - 1;
                                        index5 = index + 1;

                                        if (line3[index] == 0)
                                        {
                                            if (index4 >= 0 && index5 <= 29)
                                            {
                                                line3[index] = number;
                                                if (line3[index] != line3[index4] && line3[index] != line3[index5])
                                                {
                                                    line3[index] = number;
                                                    count2++;
                                                }
                                                else
                                                {
                                                    line3[index] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            cursorx++;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════╗");
                            Console.Write("║");
                            for (int i = 0; i < line1.Length; i++)
                            {
                                if (line1[i] > 0)
                                {
                                    Console.Write(line1[i]);
                                }
                                else if (line1[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║ Score: " + score);
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line2.Length; i++)
                            {
                                if (line2[i] > 0)
                                {
                                    Console.Write(line2[i]);
                                }
                                else if (line2[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("║");
                            for (int i = 0; i < line3.Length; i++)
                            {
                                if (line3[i] > 0)
                                {
                                    Console.Write(line3[i]);
                                }
                                else if (line3[i] == 0)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.Write("║");
                            Console.WriteLine();
                            Console.Write("╚══════════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("► PRESS ESCAPE BUTTON TO EXIT. ◄");
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursorx++;
                        }
                    }
                }
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                    ___________.__                   __                _____                         ");
            Console.WriteLine("                    \\__    ___/|  |__ _____    ____ |  | __  ______  _/ ____\\___________             ");
            Console.WriteLine("                      |    |   |  |  \\\\__  \\  /    \\|  |/ / /  ___/  \\   __\\/  _ \\_  __ \\            ");
            Console.WriteLine("                      |    |   |   Y  \\/ __ \\|   |  \\    <  \\___ \\    |  | (  <_> )  | \\/            ");
            Console.WriteLine("                      |____|   |___|  (____  /___|  /__|_ \\/____  >   |__|  \\____/|__|");
            Console.WriteLine("                                    \\/     \\/     \\/     \\/     \\/                    ");
            Console.WriteLine("                                              .__                .__                            __   ");
            Console.WriteLine("                                       ______ |  | _____  ___.__.|__| ____    ____          /\\  \\ \\");
            Console.WriteLine("                                       \\____ \\|  | \\__  \\<   |  ||  |/    \\  / ___\\         \\/   \\ \\ ");
            Console.WriteLine("                                       |  |_> >  |__/ __ \\\\___  ||  |   |  \\/ /_/  >        /\\   / / ");
            Console.WriteLine("                                       |   __/|____(____  / ____||__|___|  /\\___  /         \\/  /_/  ");
            Console.WriteLine("                                       |__|             \\/\\/             \\//_____/                   ");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1100);
        }
    }
}
