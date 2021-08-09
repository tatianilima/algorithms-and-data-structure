using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

//https://www.hackerrank.com/challenges/30-binary-numbers/problem

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim()); //5
        string resultBase2 = "";
        
        //convert base 2 when I had mod % 2
        while(n>0){
            int temp =n/2; //first result: 2 
            int rem = n%2; //second result: 1 
            resultBase2 = resultBase2 + rem.ToString();
            n=temp;
        }
        
        //count consecutives 1's
        string[] listBase2 = resultBase2.Split('0');
        ///if result 000
        if(listBase2.Count()==0)
        {
            Console.WriteLine(0);
        }
        
        int consecutives = 0;
        foreach(var element in listBase2){
            if(element.Length > consecutives){
                consecutives = element.Length;
            }
        }
        Console.WriteLine(consecutives);
    }
}
