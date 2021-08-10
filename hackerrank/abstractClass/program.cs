//https://www.hackerrank.com/challenges/30-abstract-classes/problem
using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book{
    private int price;
    private string title;
    private string author;
    
    public MyBook(string title, string author, int price) : base(title, author){  
        this.title = title;
        this.author = author;      
        this.price = price;
    }
    public override void display(){
        string title = this.title;
        string author = this.author;
        int price = this.price;
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}