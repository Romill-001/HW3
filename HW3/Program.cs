using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public enum weekend
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }
    public enum Cards
    {
        шестёрка, семёрка, восьмёрка, девятка, десятка, валет, дама, король, туз
    }
    internal class Program
    {
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("введите ширину");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите длину");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("введите диаметр");
            int d = int.Parse(Console.ReadLine());
            if (a >= d + 1 && b >= d + 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("Task 2");
            Console.WriteLine("Введите значение n; 1<=n<=9");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i * n);
            }
            Console.WriteLine("Task 3");
            Console.WriteLine("Введите число");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine( t % 15 == 0 ? "BangBoom" : t % 3 == 0 ? "Bang" : t % 5 == 0 ? "Boom" : "Мимо");
            Console.WriteLine("Task 4");
            Console.WriteLine("Введите строку");
            int counter = 0;
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    counter++;
                }
            }
            string outer = counter == input.Length ? "true" : "false";
            Console.WriteLine(outer);
            Console.WriteLine("Task 5");
            Console.WriteLine("Введите число");
            int sheepcount = int.Parse(Console.ReadLine());
            for (int sheep = 1; sheep <= sheepcount; sheep++)
            {
                Console.Write(sheep + " овца ... ");
            }
            //Console.WriteLine("Task 6");
            //int[] arr6 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, -14 };
            //int summ = 0;
            //int amount = 0;
            //try
            //{
            //    for (int i = 0; i < arr6.Length; i++)
            //    {
            //        summ += arr6[i];
            //        amount++;
            //    }
            //}
            //catch (IndexOutOfRangeException e) when 
            //{
            //    throw new ArgumentOutOfRangeException(
            //"нельзя считать отрицательный элемент", e);
            //}
            //finally
            //{
            //    Console.WriteLine("WORK IS DONE!");
            //}
            
            Console.WriteLine("Task 7");
            Console.WriteLine("введите номер карты");
            try
            {
                byte card = byte.Parse(Console.ReadLine());
                switch (card)
                {
                    case 6:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(0));
                        
                        break;
                    case 7:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(1));
                         
                        break;
                    case 8:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(2));
                         
                        break;
                    case 9:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(3));
                         
                        break;
                    case 10:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(4));
                         
                        break;
                    case 11:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(5));
                         
                        break;
                    case 12:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(7));
                         
                        break;
                    case 13:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(8));
                              
                        break;
                    case 14:
                        Console.WriteLine((Cards)Enum.GetValues(typeof(Cards)).GetValue(9));
                         
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            finally
            {
                Console.WriteLine("done!");
            }

            Console.WriteLine("Task 8");
            int toysCounter = 0;
            string[] bag = {"barbie doll" , "car" , "hello kitty" , "toy train" , "teddy bear" , "barbie doll" , "hello kitty" , "truck"};
            foreach (string toy in bag)
            {
                if (toy == "barbie doll" || toy == "hello kitty")
                {
                    toysCounter++;
                }
            }
            Console.WriteLine(" количество кукол " + toysCounter);
            Console.WriteLine("Task 9");
            Console.WriteLine("введите номер днz");
            byte day = byte.Parse(Console.ReadLine());
            //Console.WriteLine((weekend)day); более лёгкое решение :(
            switch (day)
            {
                case 1:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(0));
                    break;
                case 2:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(1));
                    break;
                case 3:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(2));
                    break;
                case 4:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(3));
                    break;
                case 5:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(4));
                    break;
                case 6:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(5));
                    break;
                case 7:
                    Console.WriteLine((weekend)Enum.GetValues(typeof(weekend)).GetValue(6));
                    break;
            }
            
            Console.WriteLine("Task 10");
            Console.WriteLine("введите массив через пробел");
            int[] arr = Console.ReadLine().Split(' ').Select(s=>int.Parse(s)).ToArray();
            Console.WriteLine("{0}", string.Join("", BubbleSort(arr)));
            Array.Sort(arr);
            foreach (byte i in arr)
            {
                Console.Write(i + " ");
            }
            var orderedArray = arr.OrderBy(N => N);
            foreach (byte i in orderedArray)
                Console.Write(i + " ");
            
            Console.WriteLine("Task 11");
            Console.WriteLine("введите массив через пробел");
            byte[] products = Console.ReadLine().Split(' ').Select(s => byte.Parse(s)).ToArray();
            for (int i = 1; i < products.Length; i++)
            {
                if (products[i] <= products[i - 1]) {
                    Console.WriteLine(products[i]);
                    break;
                }
            }





            Console.ReadKey();

        }
    }
}
