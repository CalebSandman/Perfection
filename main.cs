using System;

class Program {
  public static void Main (string[] args) {

    //prompt for input
    Console.WriteLine ("Input a number:");
    var inputNum = Console.ReadLine();

    //checks for input being a number
    int? num = IsInputNumber.GetNumber(inputNum);

    //variable that holds the sum of the numbers that divide evenly into input number
    int divEven = 0;

    //checks every positive number lower than the input for even divisibility, except 0
    for(int i = 1; i < num; i++)
    {
      if(num % i == 0)
      divEven += i;
    }

    //checks if the sum of the numbers that divide evenly into the input number is equal to        the input number
    if(divEven == num)
    Console.WriteLine("Perfect");
    else if(!num.HasValue)
    Console.WriteLine("Not an integer");
    else
    Console.WriteLine("Not perfect");
  }
}