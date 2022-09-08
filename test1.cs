using System;
class test
{
    static void test1()
    {
        int A, B, C, SUM;
        Console.WriteLine("input number1 :");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("input number2:");
        B = int.Parse(Console.ReadLine());
        Console.WriteLine("input number3:");
        C = int.Parse(Console.ReadLine());
        SUM = A + B + C;
        Console.WriteLine("SUM = {0}", SUM);
    }
    static void Main (String[] args){
        int Max,Min,Number;
        Console.Write("input Max :");
        Max = int.Parse(Console.ReadLine());
        Console.Write("input Min :");
        Min = int.Parse(Console.ReadLine());
        Console.Write("input number :");
        Number = int.Parse(Console.ReadLine());
        if (Max > Min){
            if (Min <= Number && Max >= Number){
            Console.Write("True");
            }
            else {
            Console.Write("False");
            }
        }
        else {
            Console.WriteLine("Error");
        }
    }
    tatic void test3(){
        double intpot,Sum;
    Console.Write("Input number:");
    input = double.Parse(Console.ReadLine);
    Sum=Math.Pow;
    Console.WriteLine("Sum:{0}");
    }

     tatic void test4(){
        double Input,Output;
        Console.Write("Input Number:");
        Input=double.Parse(Console.ReadLine());
        Output=Math.Abs(Input);
         Console.WriteLine("Output : {0}", Output);
     }

     tatic void test5(){
    Console.WriteLine("Test 5");
    int input, A, no1,no2,no3,no4;
    Console.Write("Input  Number : ");
    input = int.Parse(Console.ReadLine());
    if (input<5){
        for (A=1;A<=4;A++){
        input++;
        Console.WriteLine("Next : {0} ",input);
    }
    }
    else{
        no1 = input+1; no2=input+2;no3=input+3;no4=input+4;
        if (input == 5){
            Console.WriteLine(no1);Console.WriteLine(no2);Console.WriteLine(no3);Console.WriteLine("1");
        }
        if (input == 6){
            Console.WriteLine(no1);Console.WriteLine(no2);Console.WriteLine("1");Console.WriteLine("2");
         }
        if (input == 7){
            Console.WriteLine(no1);Console.WriteLine("1");Console.WriteLine("2");Console.WriteLine("3");
        }
        if (input == 8){
            Console.WriteLine("1");Console.WriteLine("2");Console.WriteLine("3");Console.WriteLine("4");
        }
    }

 }
      
 

    

