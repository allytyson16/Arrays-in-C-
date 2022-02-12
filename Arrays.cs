using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

					
public class Program
{
	public static void Main()
	{
  
         int[] myArray = {79, 45, 46, 67, 47, 87, 64, 75};
         
          for (int i = 0; i < myArray.Length; i++)
            {
				  myArray[i] += 3;
                Console.WriteLine(myArray[i]);
             }
  		     foreach(int grade in myArray)
      		{
	    		Console.WriteLine(grade);
		      }
	  	
		string[] names = {"Redee", "Theo", "Frank", "Jujuu", "Akua"};
		
		Console.Write("Enter name - ");
		string studentNames = Console.ReadLine();
		
		bool contains = true;
		for(int i = 0; i < names.Length; i++)
		{
			if(studentNames == names[i])
			{
				contains = true;
			}
		}
		if(contains = true)
		{
			Console.WriteLine("The person is in this class.");
		}
		else
		{
			Console,WriteLine("The person is not in this class.");
		}
		
	}
}


