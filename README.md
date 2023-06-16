# LogicExercises


Question 1
This code is part of a .NET console application:
static void Main(string[] args)
{
 AnimalList listOfAnimals = new AnimalList();
 DoubleList listOfNumbers = new DoubleList();
 listOfNumbers.DoSomething(2.5);
 listOfAnimals.DoSomething(new Animal());
}
public class Animal
{
 public string Name { get; set; }
 public List<string> Habitats { get; set; }
}
public class AnimalList
{
 public void DoSomething(Animal animal)
 {
 Console.WriteLine("Foo Animal");
 }
}
public class DoubleList
{
 public void DoSomething(double number)
 {
 Console.WriteLine("Foo Number");
 }
}
Optimize the code in such a way that you can replace the lists with a GenericList class with a single
DoSomething() method.
  
Question 2
Write 2 methods to reverse a .NET LinkedList<T>, one using loops, one using recursion.
v1.8 12-2022

Question 3
Write a piece of code to check if two Strings are anagrams.
What is the space complexity of your solution? What is the time complexity of your solution?

Question 4
Create a function that can determine which parent nodes in a binary tree only have one child of
which this child node is also an end node.
Tip: recursiveness!
Below is an example of an unbalanced binary tree that you can use, but make sure the function
works on any binary tree. Show the result. For example, the result of the tree shown below should
be node 14, 23 and 72
