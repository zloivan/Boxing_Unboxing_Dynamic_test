using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing_Dynamic_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1,1);
            Console.WriteLine(p);

            p.Change(2,2);
            Console.WriteLine(p);
            Object o = p;
            Console.WriteLine(p+" "+o);
            ((Point)o).Change(5, 5);///это указатель на обьект p по этому когда я пытаюсь поменять 
                                    ///поля в о, я пытаюсь изменить указатель но не меняю сам обьект
                                    
            Console.WriteLine(p+" "+o);

            Console.WriteLine
                (
                Environment.NewLine
                +"----------Second Part of a Programm-------------"
                +Environment.NewLine
                );
            dynamic value;
            for (int demo = 0; demo < 2; demo++)
            {
                value = (demo == 0) ? (dynamic)5 : (dynamic)"A";
                value = value + value;
                M(value);
            }

        }
        public static void M(int n)
        {
            Console.WriteLine("M(int): "+n);
        }
        public static void M(string s)
        {
            Console.WriteLine("M(string): " + s);
        }
    }
    
    internal struct Point
    {
        private int m_x,m_y;
        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        public void Change(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        public override string ToString()
        {
            return String.Format("({0},{1})",m_x.ToString(),m_y.ToString());
        }
    }
}
