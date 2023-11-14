using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnichok
{
    public delegate void Key(ConsoleKeyInfo key);
    internal class Pochemy
    {
          public int min;
          public int max;
          private int pos;
          private ConsoleKeyInfo key;

          public Pochemy(int Min, int Max)
          {
               min = Min;
               max = Max;
          }
          public int CheckPos()
          {
              pos = min;
              while (true)
              {
                  Console.SetCursorPosition(0, pos);
                  Console.Write("->");
                  Console.SetCursorPosition(0, 0);
                  key = Console.ReadKey();
                  Console.SetCursorPosition(0, pos);
                  Console.Write("  ");
                  if (key.Key == ConsoleKey.UpArrow && pos > min)
                  {
                      pos--;
                  }
                  if (key.Key == ConsoleKey.DownArrow && pos < max)
                  {
                      pos++;
                  }
                  if (key.Key == ConsoleKey.Enter)
                  {
                     return pos;
                  }
                  if (key.Key == ConsoleKey.Escape)
                  {
                     return 0;
                  }
              }
          }
    }
}


