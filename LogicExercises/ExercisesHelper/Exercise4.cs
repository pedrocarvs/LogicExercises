using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicExercises.ExercisesHelper
{
    public static class Exercise4
    {

        public static LinkedList<int> GetWithSingleChildNodes(Node root)
        {
            LinkedList<int> list = new LinkedList<int>();

            GetParentsWithSingleChildNodes(root, list);

            return list;
        }

        public static void GetParentsWithSingleChildNodes(Node root, LinkedList<int> list)
        {

            if (root == null) return;

            if (IsParentWithSingleChlld(root))
            {
                    list.AddLast(root.data);
            }

            GetParentsWithSingleChildNodes(root.left,list);
            GetParentsWithSingleChildNodes(root.right,list);

        }

        public static bool IsParentWithSingleChlld(Node parent) 
        {

            return (parent.left != null && parent.right == null) || 
                   (parent.left == null && parent.right != null);
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public int data;

        public Node(int key) {

            left = null;
            right = null;
            data = key;
        }
    };
}
