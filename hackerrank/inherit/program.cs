//https://www.hackerrank.com/challenges/30-inheritance/problem
using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] scores){
        base.firstName = firstName;
        base.lastName = lastName;
        base.id = id;
        this.testScores = scores;        
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    
    public string Calculate(){
        int countScores = this.testScores.Count();
        int totalScores = 0;
        
        foreach(int score in this.testScores){
            totalScores += score;
        }
        string result = "";
        int answer = totalScores / countScores;
        if(answer >= 90 && answer <= 100){
            result = "O";    
        }else if(answer >= 80 && answer < 90){
            result = "E";
        }else if( answer >= 70 && answer < 80){
            result = "A";
        }else if( answer >= 55 && answer < 70){
            result = "P";
        }else if( answer >= 40 && answer < 55){
            result = "D";
        }else if( answer < 40){
            result = "T";
        }      
        return result;  
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}