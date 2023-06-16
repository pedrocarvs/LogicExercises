using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicExercises.ExercisesHelper
{
    public class Exercise2
    {
        public static LinkedList<T> ReverseLinkedListLoops<T>(LinkedList<T> linkedList)
        {

            LinkedList<T>  AuxList = new LinkedList<T>();

            LinkedListNode<T> current = linkedList.Last;


            while (current != null)
            {
                AuxList.AddLast(current.Value);
                current = current.Previous;
            }
            linkedList = AuxList;

            return linkedList;
        }

        public static LinkedList<T> ReverseWithRecursion<T>(LinkedList<T> list)
        {
            LinkedList<T> reversedList = new LinkedList<T>();

            ReverseRecursively(list.First, reversedList);

            return reversedList;
        }

        private static void ReverseRecursively<T>(LinkedListNode<T> node, LinkedList<T> reversedList)
        {
            if (node == null)
                return;

            ReverseRecursively(node.Next, reversedList);
            reversedList.AddLast(node.Value);
        }

        public static string ConvertToStringLinkedList<T>(LinkedList<T> list) 
        { 
            StringBuilder sb = new StringBuilder();
            LinkedListNode<T> current = list.First;
            sb.Append(" { ");
            while (current != null)
            {
                sb.Append(current.Value.ToString());
                if (current.Next != null)
                {
                    sb.Append(" : ");
                }
                current = current.Next;
            }
            sb.Append(" } ");
            return sb.ToString();
        }
    }
}
