﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class assign
    {
        public static void SwapNo()
        {
            Console.WriteLine("enter a number");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();
            string c = b;
            b = a;
            a = c;
            Console.WriteLine("the value of a= {0},the value of b ={1}", a, b);



        }

        public static void DisplayNo()
        {
            Console.WriteLine("enter a number");
            string d = Console.ReadLine();
            string e = d + " ";
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 5; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(d);
                    }
                    else
                    {
                        Console.Write(e);
                    }


                }

            }
            Console.WriteLine();
        }

        public static void Days()
        {
            int day;
            Console.WriteLine("enter your day");
            day = Convert.ToInt32(Console.ReadLine());


            switch (day)
            {

                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("ENTER A VALID NO");
                    break;
            }

        }

        public static void BasicArray()
        {
            int[] arr = new int[5];
            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter {0} th element of array", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int n = 0; n < arr.Length-1; n++) 
            {
                for (int m = (n+1) ; m < arr.Length; m++) 
                {
                    if (arr[n] > arr[m])
                    {
                        temp = arr[n];
                        arr[n] = arr[m];
                        arr[m] = temp;
                    }
                    else continue;
                     

                  
                }
               
            }
            int sum = 0;
            foreach(int item in arr)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
            Array.ForEach(arr, j => sum = sum + j);
            float ave = sum / (arr.Length);
            Console.WriteLine("{0} the average of array", ave);
            Console.WriteLine("{0} the minimum element of array",arr[0]);
            Console.WriteLine("{0} the maximum element of array", arr[(arr.Length-1)]);



        }

        public static void Marks()
        {
            int[] studentmarks = new int[10];
            int use = 0;
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("enter student marks {0}", i);
                studentmarks[i] = Convert.ToInt32(Console.ReadLine());
             

            }
            for (int q = 0; q < studentmarks.Length-1; q++)
            {
                for( int r=q+1; r < studentmarks.Length;r++)
                {
                    if (studentmarks[q] > studentmarks[r])
                    {
                        use = studentmarks[r];
                        studentmarks[r] = studentmarks[q];
                        studentmarks[q] = use;


                    }
                    else continue; 

                }
            }
           
            int sumofmarks = 0;
            Array.ForEach(studentmarks, g => sumofmarks = sumofmarks + g);
            float averagemarks = sumofmarks / (studentmarks.Length);
            Console.WriteLine("{0}sum of marks", sumofmarks);
            Console.WriteLine("{0} the average of array", averagemarks);
            Console.WriteLine("{0} the minimum element of array", studentmarks[0]);
            Console.WriteLine("{0} the maximum element of array", studentmarks[(studentmarks.Length - 1)]);
            Console.Write("asending order  ");
            foreach (int num in studentmarks)
            {
                Console.Write("{0}  ", num);
            }

             
            Console.WriteLine();
            Array.Reverse(studentmarks);
            Console.Write("desending order of marks");
            foreach(int k in studentmarks)
            {
                Console.Write(k +" ");

            }
            Console.WriteLine();


        }
         public static void Copyarr()
        {
            int[] array1=new int []  { 5,10,3,20,25};
            int[] array2 = new int[5];
          for(int z=0;z< 5;z++)
            {
                array2[z] = array1[z];

            }
            Console.WriteLine("the new array is");
          for(int i =0;i<5;i++)
            {
                Console.Write(array2[i] + " ");
               
            }
            Console.WriteLine();






        }

        }

        class driver
        {
            public static void Main()
            {
                assign.SwapNo();
                assign.DisplayNo();
                assign.Days();
                assign.BasicArray();
            assign.Marks();
            assign.Copyarr();
                Console.Read();
                

            }
        }
    }

