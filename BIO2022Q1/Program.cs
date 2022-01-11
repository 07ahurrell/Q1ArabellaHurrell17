using System;
using System.Text.RegularExpressions;

namespace BIO2022Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bella Hurrell, 17 , Brighton College");
            string input = Console.ReadLine();
            char[] edit = input.ToCharArray();
            int[] f = new int[10];
            for(int i =0; i<edit.Length; i++)
            {
                f[i] = identify1(edit[i]);
            }
            int[] g = new int[10];
            f = comp(f, g);
            char[] b = new char[10];
            
            for(int i =0; i<f.Length; i++)
            {
                if(f[i] <= 26)
                {
                    
                    b[i] = revert(f[i]);
                    
                }
                else if(f[i]> 26)
                {
                    f[i] = f[i] - 26;
                    
                    b[i] = revert(f[i]);
                    
                }
            }
            
            string s = ""+ edit[0];
            foreach(char c in b)
            {
                s = s + c;
            }
            s = Regex.Replace(s, @"\s+", "");
            s = s.Remove(s.Length - 1, 1);
            Console.WriteLine(s);


            
        
        }
        public static int[] comp1d(int[] a, int[] d)
        {
            for (int i = 1; i < a.Length; i++)
            {
                d[i] = a[i] + a[i - 1];

            }
            //for(int j = 0; j<a.Length; j++)
            //{
            //    Console.WriteLine(d[j]);
            //}
            return d;
        }
        public static int[] comp(int[] a, int[] d)
        {
            for(int i = 1; i<a.Length; i++)
            {
                d[i] = a[i] - a[i-1] ;
                
            }
            //for(int j = 0; j<a.Length; j++)
            //{
            //    Console.WriteLine(d[j]);
            //}
            return d;
        }
        public static char revert(int a)
        {
            if (a < 0)
            {
                a = 26 + a;
            }
            if(a == 1)
            {
                return 'A';
            }
            
            else if(a == 2)
            {
                return 'B';
            }
            else if (a == 3)
            {
                return 'C';
            }
            else if (a == 4)
            {
                return 'D';
            }
            else if (a == 5)
            {
                return 'E';
            }
            else if (a == 6)
            {
                return 'F';
            }
            else if (a == 7)
            {
                return 'G';
            }
            else if (a == 8)
            {
                return 'H';
            }
            else if (a == 9)
            {
                return 'I';
            }
            else if (a == 10)
            {
                return 'J';
            }
            else if (a == 11)
            {
                return 'K';
            }
            else if (a == 12)
            {
                return 'L';
            }
            else if (a == 13)
            {
                return 'M';
            }
            else if (a == 14)
            {
                return 'N';
            }
            else if (a == 15)
            {
                return 'O';
            }
            else if (a == 16)
            {
                return 'P';
            }
            else if (a == 17)
            {
                return 'Q';
            }
            else if (a == 18)
            {
                return 'R';
            }
            else if (a == 19)
            {
                return 'S';
            }
            else if (a == 20)
            {
                return 'T';

            }
            else if (a == 21)
            {
                return 'U';
            }
            else if (a == 22)
            {
                return 'V';
            }
            else if (a == 23)
            {
                return 'W';
            }
            else if (a == 24)
            {
                return 'X';
            }
            else if (a == 25)
            {
                return 'Y';
            }
            else if (a == 26)
            {
                return 'Z';
            }
            else
            {
                return ' ';
            }

        }
        public static int identify1(char a)
        {
            if(a == 'A')
            {
                return 1;
            }
            else if (a == 'B')
            {
                return 2;
            }
            else if (a == 'C')
            {
                return 3;
            }
            else if (a == 'D')
            {
                return 4;
            }
            else if (a == 'E')
            {
                return 5;
            }
            else if (a == 'F')
            {
                return 6;
            }
            else if (a == 'G')
            {
                return 7;
            }
            else if (a == 'H')
            {
                return 8;
            }
            else if (a == 'I')
            {
                return 9;
            }
            else if (a == 'J')
            {
                return 10;
            }
            else if (a == 'K')
            {
                return 11;
            }
            else if (a == 'L')
            {
                return 12;
            }
            else if (a == 'M')
            {
                return 13;
            }
            else if (a == 'N')
            {
                return 14;
            }
            else if (a == 'O')
            {
                return 15;
            }
            else if (a == 'P')
            {
                return 16;

            }
            else if (a == 'Q')
            {
                return 17;
            }
            else if (a == 'R')
            {
                return 18;
            }
            else if (a == 'S')
            {
                return 19;
            }
            else if (a == 'T')
            {
                return 20;
            }
            else if (a == 'U')
            {
                return 21;
            }
            else if (a == 'V')
            {
                return 22;
            }
            else if (a == 'W')
            {
                return 23;
            }
            else if (a == 'X')
            {
                return 24;
            }
            else if (a == 'Y')
            {
                return 25;
            }
            else if (a == 'Z')
            {
                return 26;
            }
            else
            {
                return 0;
            }
        }
    }
}
