using LogicExercises.ExercisesHelper;
using static LogicExercises.ExercisesHelper.Exercise1;

//Exercise 1

GenericList<object> objList = new GenericList<object>();
objList.DoSomething(2.5);
objList.DoSomething(new Animal());


//exercise 2
LinkedList<int> myList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });

LinkedList<int> reversedWithLoop = Exercise2.ReverseLinkedListLoops(myList);
LinkedList<int> reversedWithRecursion = Exercise2.ReverseWithRecursion(myList);

Console.WriteLine("ListReverted loops: {0}", Exercise2.ConvertToStringLinkedList(reversedWithLoop));
Console.WriteLine("ListReverted Recursive: {0}", Exercise2.ConvertToStringLinkedList(reversedWithRecursion));


//Exercise 3

string word1 = "Anna";
string word2 = "Anns";

Console.WriteLine("Are the strings Anagrams? {0}", Exercise3.AreStringsAnagrams(word1, word2));


//Exercise 4 

Node root = new Node(50);
root.left = new Node(17);
root.right = new Node(76);
root.left.left = new Node(9);
root.left.right = new Node(23);
root.left.left.right = new Node(14);
root.left.left.right.left = new Node(12); //
root.left.right.left = new Node(19);       //
root.right.left = new Node(54);
root.right.left.right = new Node(72);
root.right.left.right.left = new Node(67); //


LinkedList<int> nodes =  Exercise4.GetWithSingleChildNodes(root);

Console.WriteLine("Parents that have one child that is end node: {0}", Exercise2.ConvertToStringLinkedList(nodes)) ;

