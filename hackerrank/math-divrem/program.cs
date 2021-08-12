//https://www.hackerrank.com/challenges/30-interfaces/problem
using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int result = 0;
        int quotient = 0;
        for(int i = 0; i<n; i++){
            var a = i+1;
            if(n % a == 0){     
                quotient = Math.DivRem(n, a, out int remainder);        
                result += quotient;
            }
        }
        return result;
    }
}

class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}