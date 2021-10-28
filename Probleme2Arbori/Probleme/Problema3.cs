using System;
using System.Collections.Generic;
using System.Text;

namespace Probleme2Arbori.Probleme
{
    class Problema3
    {
        public Problema3(BST<int> bst1, BST<int> bst2)
        {
            Console.WriteLine(structura(bst1.Root, bst2.Root));
        }

        public bool structura(TreeNode<int> node1, TreeNode<int> node2)
        {
            Queue<TreeNode<int>> queue1 = new Queue<TreeNode<int>>();
            Queue<TreeNode<int>> queue2 = new Queue<TreeNode<int>>();

            if (node1 != null)
                queue1.Enqueue(node1);
            if (node2 != null)
                queue2.Enqueue(node2);

            while (queue1.Count > 0 && queue2.Count > 0)
            {
                if (queue1.Peek().Left != null && queue2.Peek().Left != null)
                {
                    queue1.Enqueue(queue1.Peek().Left);
                    queue2.Enqueue(queue2.Peek().Left);
                }
                else if ((queue1.Peek().Left != null && queue2.Peek().Left == null) || (queue1.Peek().Left == null && queue2.Peek().Left != null))
                {
                    return false;
                }

                if (queue1.Peek().Right != null && queue2.Peek().Right != null)
                {
                    queue1.Enqueue(queue1.Peek().Right);
                    queue2.Enqueue(queue2.Peek().Right);
                }
                else if ((queue1.Peek().Right != null && queue2.Peek().Right == null) || (queue1.Peek().Right == null && queue2.Peek().Right != null))
                {
                    return false;
                }


                queue1.Dequeue();
                queue2.Dequeue();
            }

            if (queue1.Count == 0 && queue2.Count == 0)
                return true;
            return false;
        }
    }
}
