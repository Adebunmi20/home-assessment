using System;

namespace ClassAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Console.WriteLine("=============== Question 1 ==============");
            Console.WriteLine("Enter 1st integer: ");
            int integer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a 2nd integer: ");
            int integer2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers dividable by 5 without remainder from " + integer1 + "to " + integer2 + " are:");
            int count = 0; 
            for (int j = integer1; j <= integer2; j++)
            {
                if (j % 5 == 0)
                {
                    Console.WriteLine(j);
                    count++;
                }
            }
           { 
               Console.WriteLine("Total number dividable by 5 is: " + count.ToString());
           }
           /*Console.WriteLine("============== Question 2 ============");
            int n = 100;
            int f1 = 0, f2 = 1, i;
 
         if (n < 1)
         return;
         for (i = 1; i < n; i++) 
         {
            Console.WriteLine(f2 + " ");
            int next = f1 + f2;
            f1 = f2;
            f2 = next;
         } 

           Console.WriteLine("============ Question 3 ============");
           Console.WriteLine("Write 5 numbers: ");
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           int c = int.Parse(Console.ReadLine());
           int d = int.Parse(Console.ReadLine());
           int e = int.Parse(Console.ReadLine());

           if((a >= b) && (a >= c) && (a >= d) && (a >= e))
           {
               Console.WriteLine("The greatest number is " + a);
               return;
           }
           
          if((b >= a) && (b >= c) && (b >= d) && (b >= e))
           {
               Console.WriteLine("The greatest number is " + b);
               return;
           }
           if((c >= a) && (c >= b) && (c >= d) && (c >= e))
           {
               Console.WriteLine("The greatest number is " + c);
               return;
           }
           if((d >= a) && (d >= b) && (d >= c) && (d >= e))
           {
               Console.WriteLine("The greatest number is " + d);
               return;
           }
           if((e >= b) && (e >= c) && (e >= d) && (e >= d))
           {
               Console.WriteLine("The greatest number is " + e);
               return;
           }
             
             Console.WriteLine("================ Question 5 ======================");
             Console.WriteLine("Enter any number from 1-9");
             int number = Convert.ToInt32(Console.ReadLine());
             switch(number)
            {
                case 1:
                Console.WriteLine(1*10);
                break;
                case 2 :
                Console.WriteLine(2*10);
                break;
                case 3:
                Console.WriteLine(3*10);
                break;
                case 4:
                Console.WriteLine(4*100);
                break;
                case 5:
                Console.WriteLine(5*100);
                break;
                case 6:
                Console.WriteLine(6*100);
                break;
                case 7:
                Console.WriteLine(7*1000);
                break;
                case 8:
                Console.WriteLine(8*1000);
                break;
                case 9:
                Console.WriteLine(9*1000);
                break;
                default:Console.WriteLine("Invalid digit, input a valid one");
                break;
            }  
            Console.WriteLine("================= Question 6 ================");
            Console.Write("Enter Number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
            {
                if (i % (3 * 7) != 0)
                {
                  Console.WriteLine(i);
                }
            }*/
            /*Console.WriteLine("============== Question 7 =============");
             for (int i = 0; i < 4; i++)
            {
                if(i != 0) Console.WriteLine();

                for (int q = 0; q < 13; q++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Club "); break;
                        case 1: Console.Write("Diamond "); break;
                        case 2: Console.Write("Heart "); break;
                        case 3: Console.Write("Spades "); break;
                    }
                    switch(q)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }
            Console.WriteLine("================= Question 8 =================");
            int firstN = 0, secondN = 1, thirdN = 0;

            Console.Write("Enter Number: ");
            int length = Int32.Parse(Console.ReadLine());

            Console.Write("0, 1,");

            for(int i = 2; i < length; i++)
            {
                thirdN = firstN + secondN;
                Console.Write(" {0},", thirdN);
                firstN = secondN;
                secondN = thirdN;
            }
            Console.WriteLine("============== Question 10 ===============");
            int[] num = new int[20];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i * 5;
                Console.WriteLine(num[i]);
            }
            /*Console.WriteLine("=============== Question 11 ====================="); 
            Console.Write("Enter first array: ");
            string inputArrayOne = Console.ReadLine();            
            string[] arrayOne = inputArrayOne.Split(new char[] { ',' });
            Console.Write("Enter second array: ");
            string inputArrayTwo = Console.ReadLine();
            string[] arrayTwo = inputArrayTwo.Split(new char[] { ',' });
            bool arraysAreEqual = true;
            if (arrayOne.Length != arrayTwo.Length)
            {
                Console.WriteLine("The arrays have different number of elements.");
            }
            else
            {                
                for (int z = 0; z < arrayOne.Length; z++)
                {
                    if (arrayOne[z] != arrayTwo[z])
                    {
                        arraysAreEqual = false;
                        break;
                    }
                }
                if (arraysAreEqual)
                {
                    Console.WriteLine("Arrays are equal.");
                }
                else
                {
                    Console.WriteLine("Arrays are different.");
                }
            }
            Console.WriteLine("=============== Question 12 ==============");
            int count = 1, tempCount = 1, numbers = 0;

			Console.Write ("Enter number length: ");
			int length = Int32.Parse (Console.ReadLine ());
			int[] arr = new int[length];

			for (int i = 0; i < arr.Length; i++) 
			{
				Console.Write ("Enter {0} element: ", i);
				arr [i] = Int32.Parse (Console.ReadLine ());
			}

			for (int i = 0; i < arr.Length - 1; i++) 
			{
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

				if (tempCount > count) 
				{
					count = tempCount;
					numbers = arr [i];
				}
			}

			for (int i = 0; i < count; i++) Console.Write ("{0}, ", numbers);
            Console.WriteLine("=============== Question 13 ===================");
            int count = 0, initCount = 1, foundNumber = 0;

            Console.Write("Enter number length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) initCount++;
                else initCount = 1;
                if (initCount > count)
                {
                    count = initCount;
                    foundNumber = arr[i];
                }
            }
            Console.WriteLine("{0} was found {1} times.", foundNumber, count);
            Console.WriteLine("================= Question 14 ===============");
            Console.Write("Enter number: ");
            int num = Int32.Parse(Console.ReadLine());    
            string binar = Convert.ToString(num, 2);
            Console.WriteLine("Result is {0}", binar);
            Console.WriteLine("================= Quetion 15 ================");
            Console.Write("Enter decimal number: ");
            int binary = Int32.Parse(Console.ReadLine());
            string toDecimal1 = Convert.ToString(binary, 10);
            string toBinary = Convert.ToString(binary, 2);
             Console.WriteLine("Result is {0}", toBinary);
             Console.WriteLine("=============== Question 16 =================");
             Console.Write("Enter decimal number: ");
             int n = Int325.Parse(Console.ReadLine());
             string toDecimal = Convert.ToString(n, 10);
             string hexaDecimal = Convert.ToString(toDecimal, 16);
             Console.WriteLine("Result is {0}", hexaDecimal);*/
             Console.WriteLine("================ Question 17 ===============");
             Console.WriteLine("Enter hexadecimal number: ");
             int d = Int32.Parse(Console.ReadLine());
             string hexaDecimal = Convert.ToString(d, 16);
             string toDecimal = Convert.ToString(d, 10);
             Console.WriteLine("Result is {0}", toDecimal);

             Console.WriteLine("=============== Question 18 ================");
             Console.WriteLine("Enter hexadecimal number: ");
             string hdnum = Convert.ToString(Console.ReadLine());
             int convertnum = Convert.ToInt32(hdnum, 16);
             Console.WriteLine("Result is {0}", convertnum );
             string convertednum = Convert.ToString(convertnum, 2);
             Console.WriteLine("Result is {0}", convertednum); 
             Console.WriteLine("=============== Question 19 ================");
             Console.WriteLine("Enter Binary number: ");
             string binnum = Convert.ToString(Console.ReadLine());
             int decnum = Convert.ToInt32(binnum, 2);
             string hexanum = Convert.ToString(decnum, 16);
             Console.WriteLine("Result is {0}", hexanum);


        }

    }
}
