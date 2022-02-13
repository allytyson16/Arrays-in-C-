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
		
		
		//Useful Array Methods
	//Binary search
		int[] myArrays = {5, 10, 14, 45, 64, 75, 86};
		Console.WriteLine("Enter a number to check if it exists. ");
		int number = int.Parse(Console.ReadLine());
		
		
		int answer = Array.BinarySearch(myArrays, number);
		if(answer < 0)
		{
			Console.WriteLine("The number does not exist.");
		}
		else
		{
			Console.WriteLine("The numbers position in this array is {0}", answer);
		}
		
	//Array sorting
		int[] myArray1 = {5, 45, 2, 75, 34, 11};
		Array.Sort(myArray1);
		for(int i = 0; i < myArray1.Length; i++)
		{
			Console.WriteLine(myArray1[i]);
		}
		
		Console.WriteLine(" ");
		
		
	//Array reverse
		int[] myArray2 = {34, 35, 64, 23, 75, 90};
		Array.Reverse(myArray2);
		for(int i = 0; i < myArray.Length; i++)
		{
			Console.WriteLine(myArray2[i]);
		}
		
		
	}
}



		
	

