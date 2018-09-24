using System;  
public class LargestIn3Num  
{  
    public static void Main()
{
    int num1, num2, num3;
   
    Console.Write("Find the largest of three numbers:\n");
   
    Console.Write("Enter the 1st number :");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the  2nd number :");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the 3rd  number :");
    num3 = Convert.ToInt32(Console.ReadLine());
 
  if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.Write("The 1st Number is the Largest among three. \n\n");
        }
        else
        {
            Console.Write("The 3rd Number is the Largest among three. \n\n");
        }
    }
    else if (num2 > num3)
        Console.Write("The 2nd Number is the Largest among three \n\n");
    else
        Console.Write("The 3rd Number is the Largest among three \n\n");
}
}
