using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

					
public class Program
{
	public static void Main()
	{
  //Arrays
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
	  	
	//Using loops with Arrays
		string[] names = {"Redee", "Theo", "Jujuu", "Serwaa", "Abena"};
		
		Console.Write("Enter name - ");
		string studentNames = Console.ReadLine();
		
		bool contains = false;
		for(int i = 0; i < names.Length; i++)
		{
			if(studentNames == names[i])
			{
				contains = true;
			}
		}
		if(contains == true)
		{
			Console.WriteLine("The person is in this class.");
		}
		else
		{
			Console.WriteLine("The person is not in this class.");
		}
		
		
		
	//parallel loops
		
		string[] students = {"Redee", "Theo", "Jujuu", "Aku", "Serwaa", "Abena"};
		int[] grades = {78, 67, 56, 48, 90, 60};
		
		Console.Write("Enter name - ");
		string namesOfStudents = Console.ReadLine();
		
		bool contain = false;
		int studentGrade = 0;
		for(int i = 0; i < students.Length; i++)
		{
			if(namesOfStudents == students[i])
			{
				contain = true;
			 	studentGrade = grades[i];
				break;
			}
		}
		if(contain == true)
		{
			Console.WriteLine("The person is in this class.");
			Console.WriteLine("The students grade is " + studentGrade);

		}
		else
		{
			Console.WriteLine("The person is NOT in this class.");
		}
		
	}
}



		
	

