using System;
using System.ComponentModel.Design;

namespace Лабка_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voznesenskyi Tymofii IPS-13.2 Var-5");
            Menu();
        }

        static void Menu()
        {
            char command;
            char key;
            do
            {
                Console.WriteLine("Menu of command");
                Console.WriteLine("Task 1");
                Console.WriteLine("Task 2");
                Console.WriteLine("Task 3");
                Console.WriteLine("Task 4");
                Console.WriteLine("Task 5");
                Console.WriteLine("Task 6");
                Console.WriteLine("Task 7");
                Console.WriteLine();
                Console.WriteLine("select of command, press number of key");
                command =(char) Console.Read();
                Console.ReadLine();
                switch (command)
                {
                    case '1': ShellSort(); break;
                    case '2': EratosphenSort(); break;
                    case '3': AlternationSort(); break;
                    case '4': MinMaxValue(); break;
                    case '5': Deleting(); break;
                    case '6': BracketFinding(); break;
                    case '7': SalesMartix(); break;
                    default: Console.WriteLine("wrong command"); break;
                }
                Console.WriteLine("Continue y/n");
                key = (char)Console.Read();
                Console.ReadLine();
            } while (key!='n');
        }
        
        static void ShellSort()
        {
            int a, i, j, step, tmp;
            Console.WriteLine("Enter number of elements: ");
            a = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int[a];
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 50);
            }
            for (i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"   ");
            }
            Console.WriteLine();
            //сортировка вставкой

            
            //5 7 4 6 9

            /*for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                
                while (j>=0 && array[j]>key)
                {
                    array[j + 1] = array[j];
                    array[j] = key;
                    j--;
                }
            }
*/
            //5 7 4 6 9
            for (step = a / 2; step > 0; step /= 2)
            {
                for (i = step; i < array.Length; i++)
                {
                    tmp = array[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (tmp<array[j-step])
                        {
                            array[j] = array[j - step];
                        }
                        else break;
                    }

                    array[j] = tmp;
                }
            }
            
            for (j = 0; j < array.Length; j++)
            {
                Console.Write(array[j]+"   ");
            } 
        }

        static void EratosphenSort()
        {
            int n, i, j, s;
            Console.WriteLine("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            //sorting

            arr[1] = 0;
            for (s = 0; s < n; s++)
            {
                if (arr[s] != 0)
                {
                    for (j = s * 2; j < n; j += s)
                    {
                        arr[j] = 0;
                    }
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

        static void AlternationSort()
        {
            int n, i, j, temp;
            Console.WriteLine("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[n];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"   ");
            }
            Console.WriteLine();
            
            //sorting

            for (i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] < 0)
                    {
                        for (j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[j] > 0)
                            {
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                        }
                    }
                }
                else
                {
                    if (arr[i] > 0)
                    {
                        for (j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] < 0)
                            {
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                        }
                    }
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"   ");
            } 
        }

        static void MinMaxValue()
        {
            int n, i, j, n2, n3, q, min, max;
            n2 = 0;
            n3 = 0;
            j = 0;
            q = 0;
            Console.WriteLine("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[n];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"   ");
            }
            
            Console.WriteLine();
            
            //max and min

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    n2++;
                }
                if (arr[i] > 0)
                {
                    n3++;
                }
            }
            
            int[] arr2 = new int[n2];
            int[] arr3 = new int[n3];
                
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 )
                {
                    arr2[j] = arr[i];
                    j++;
                }
                else if (arr[i] > 0)
                {
                    arr3[q] = arr[i];
                    q++;
                }
            }
            
            min = arr3[0];
            max = arr2[0];

            for (j = 0; j < arr2.Length; j++)
            {
                if (arr2[j] > max)
                {
                    max = arr2[j];
                }
            }
            
            for (q = 0; q < arr3.Length; q++)
            {
                if (arr3[q] < min)
                {
                    min = arr3[q];
                }
            }

            Console.WriteLine("Min value among positive value: " + min);
            Console.WriteLine("Max value among negative value: " + max);
        }

        static void Deleting()
        {
            int n, i, j, min, k, i1, j1;
            i1 = 0;
            j1 = 0;
            Console.WriteLine("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] arr = new int[n, n];
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr[i, j] = rand.Next(-10, 10);
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }

            min = arr[0, 0];
            
            //finding min value
            
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arr[i,j] < min)
                    {
                        min = arr[i, j];
                        i1 = i;
                        j1 = j;
                    }
                }
            }

            Console.WriteLine("Index i= "+(i1+1)+"  Index j= "+(j1+1)+"  Min Value= "+min);
            
            //deleting row and column

            for (i = i1; i < n - 1; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr[i, j] = arr[i + 1, j];
                }
            }
            
            for (i=0; i < n; i++)
            {
                for (j = j1; j < n-1; j++)
                {
                    arr[i, j] = arr[i, j + 1];
                }
            }
            
            for (i = 0; i < n-1; i++)
            {
                for (j = 0; j < n-1; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

        static void BracketFinding()
        {
            string str;
            Console.WriteLine("Enter your string: ");
            str = Console.ReadLine();
            char[] cInpuArr = str.ToCharArray();
            int cnt = 0;
            foreach (char c in cInpuArr)
                if (c == '(')
                    cnt++;
                else if (c == ')')
                    cnt--;
 
            if (cnt == 0)
                Console.WriteLine("The number of the bracket is the same");
            else
                Console.WriteLine("The number of the bracket is NOT the same");  
        }

        static void SalesMartix()
        {
            int n, i, j, min, k, i1, j1;
            i1 = 0;
            j1 = 0;
            Console.WriteLine("Enter number of products: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] arr = new int[n, 6];
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    arr[i, j] = rand.Next(10, 30);
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //finding sum
            for (i = 0; i < n; i++)
            {
                int sum = 0;
                
                for (j = 0; j < 6; j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine("Sum of product "+(i+1)+" for 6 month is: "+sum);
            }
            Console.WriteLine();
            //sum of all elements
            int sumMat = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    sumMat += arr[i, j];
                }
                
            }
            Console.WriteLine("Sum of all products for all moths is: "+sumMat);
        }
    }
}
