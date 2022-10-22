using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;








    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }
    }







namespace NAprac6
{
    class Programm
    {

        static void Main()
        {

            {
                // Все целые числа от A до B (A <= B), оканчивающиеся на цифру X

                Console.Write("Введите число X = ");
                int X = int.Parse(Console.ReadLine());
                Console.Write("Введите начальный диапазон = ");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Введите конечный диапазон = ");
                int B = int.Parse(Console.ReadLine());
                while (A % 10 != X)
                {
                    A++;
                }
                while (B % 10 != X)
                {
                    B--;
                }
                int i;
                Console.WriteLine();
                Console.WriteLine("For: ");
                for (i = A; i <= B; i += 10)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("While: ");
            }
        }
    }
}





    



   







