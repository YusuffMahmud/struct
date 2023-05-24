// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int age  = 1;
// while(age <= 5)
// {
//     Console.WriteLine("Your age is " + age);
//     age ++;
// }

// int num = 1;
// while(num <= 10)
// {
//     Console.WriteLine(num);
//     num++;
// }
// Console.WriteLine("Enter your number");
// int n = int.Parse(Console.ReadLine());
// int num = 0;
// int sum = 0;
// while(num <= n)
// {
//      num ++;
//      sum += num;
//     Console.Write (" + " + num);
// }
// Console.WriteLine(" = " + sum);

// TO CHECKED IF A NUMBER IS A EVEN NUMBER
// Console.WriteLine("Enter your number");
// int number = int.Parse(Console.ReadLine());
// int num = 1;
// while(number <= 20)
// {
// if(number % 2 == 0)
// {
//     Console.Write(number + ",");
// 
// number++;
// }
// checked IF A NUMBER IS ODD NUMBER/
// Console.WriteLine("Enter your number");
// int number = int.Parse(Console.ReadLine());
// int num = 1;
// while(number <= 20)
// {
// if(number % 2 == 1)
// {
//     Console.Write(number + ",");
// }
// number++;
// }

// Console.WriteLine("Enter your age");
// int age = int.Parse(Console.ReadLine());
// int n = 1;
// int infinite = age + 100;
// while(age <= infinite)
// {
//     Console.WriteLine("Your age in the next 3 years will be {0} years is {1}",n,age);
//     n = n+3;
//     age = age + 3;

// }


// Console.WriteLine("Enter your number");
// int num = int.Parse(Console.ReadLine());
// int x = 1;
// while(x < 10)
// {
//     Console.WriteLine(x);
// x++;
// }



// int sum = 0;
// for(int i = 1; i <= 5; i++)
// {
//     Console.WriteLine("Enter your number");
//     int t = int.Parse(Console.ReadLine()) ;
//       sum = sum += t;
//     System.Console.WriteLine(sum);
// }    

// int x = 1;
// for(Console.WriteLine("Going first"); x <= 5; Console.WriteLine("Going Last"))
// {
//     Console.WriteLine(x);
//      x++;
// }


// TO CHECKED IF A NUMBER IS A PRIME NUMBER
// Console.WriteLine("Enter your number");
// int num = int.Parse(Console.ReadLine());
// int divider = 2;
// int maxdivider = (int)Math.Sqrt(num);
// bool prime = true;
// while(prime && (divider <= maxdivider))
// {
//     if(num % divider == 0)
//     {
//     prime = false;

//     }
// divider++;
// }
// Console.WriteLine("prime" + prime);
// bool stop  = true;
// int p = 0;
// do
// {
//     Console.WriteLine(p);
//     p++;
//     if(p == 10)
//     {
//         stop = false;
//     }
// } 
//  while (stop);

// Console.WriteLine("Enter your number");
// int num = int.Parse(Console.ReadLine());
// for(int i = 0; i <= 4; i++)
// {
//     Console.WriteLine();
//     for(int k = 0; k <= 4; k++)
//     {
//         Console.Write(1);
//     }
// }

// int p = 2;
// while(p <= 12)
// {
//     int j = 1;
//     while (j <= 12)
//     {
//     Console.WriteLine($"{p} * {j} = {p * j}");
//     j++;
//     }
//  p++;
// }

// Question 1
// Console.WriteLine("Enter your number");
// int N = int.Parse(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine(i + " ");
// }
// Question 2
// Console.WriteLine("Enter your number");
// int num = int.Parse(Console.ReadLine());
// for (int i = 0; i <= num; i++)
// {
//     if(i % 7 == 0 && i % 3 == 0)
//      {
//       Console.WriteLine(i + " ");
//      }
// }
// Question 3
//  Console.WriteLine("Enter your first number");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter your second number");
// int num2 = int.Parse(Console.ReadLine());
// if(num1 > num2 && num2 < num1)
// {
//     Console.WriteLine($"The maximum number is {num1}");
// }
// else
// {
//     Console.WriteLine($"The maximum number is {num2}");
//  
