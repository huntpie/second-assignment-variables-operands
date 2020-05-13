using System;

namespace second_assignment_variables_operands
{
  class Program
  {
    static void Main(string[] args)
    {
      //declare variables
      var numberOfCupsOfCoffee = 2;
      var fullName = "Pierce Hunt";
      var today = "05/12/2020";

      //output variables
      Console.WriteLine("Hello, my name is " + fullName + ". I roughly have " + numberOfCupsOfCoffee
        + " cups of coffee every day including today, " + today + ".");

      Console.Write("User, what is your name? ");
      //read string into variable
      var userName = Console.ReadLine();

      var greeting = $"Nice to meet you, {userName}. I hope you, {userName}, like this program!";
      //writing a string into the console
      Console.WriteLine(greeting);

      //ask user to input two numbers
      Console.Write("User, please input two numbers: ");
      var firstNumberAsString = Console.ReadLine();
      var secondNumberAsString = Console.ReadLine();

      //convert each string into double
      double firstOperand = Double.Parse(firstNumberAsString);
      double secondOperand = Double.Parse(secondNumberAsString);

      //add operands into new variable
      double sum = firstOperand + secondOperand;

      //subtract secondoperand from first
      double difference = firstOperand - secondOperand;

      //multiple operands 
      double product = firstOperand * secondOperand;

      //divide first operand by second
      double quotient = firstOperand / secondOperand;

      //find remainder
      double remainder = firstOperand % secondOperand;

      //present sum, difference, quotient, product, remainder to user
      Console.WriteLine("Hello, User, if you add your first number, "
        + firstOperand + ", and your second number, "
        + secondOperand + ", the total is "
        + sum + ", the difference of your two numbers: "
        + difference + ", quotient: "
        + quotient + ", product: "
        + product + ", remainder: "
        + remainder + ".");

      //Adventure mode use boolean logic
      //dateTime struct
      //move all code to separate file and invoke from main method.

    }
  }
}
