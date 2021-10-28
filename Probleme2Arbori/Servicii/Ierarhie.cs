using System;
using System.Collections.Generic;
using System.Text;

namespace Probleme2Arbori
{
    class Ierarhie<T> where T : IComparable<T>
    {
        TreeNode<T> root;

        public TreeNode<T> Root
        {
            get { return root; }
        }

        public Ierarhie(T data)
        {
            root = new TreeNode<T> { Data = data, Left = null, Right = null };
        }

        public TreeNode<T> find(TreeNode<T> node, T data)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data.Equals(data))
            {
                return node;
            }

            TreeNode<T> left= find(node.Left, data);

            if (left != null)
            {
                return left;
            }


            return find(node.Right, data);
        }

        public bool addSubordinate(T manager, T subordonat)
        {
            TreeNode<T> node = find(root, manager);

            if (node == null)
            {
                return false;
            }

            if (node.Left != null && node.Right != null)
            {
                return false;
            }

            if (node.Left == null)
            {
                node.Left = new TreeNode<T> { Data = subordonat, Left = null, Right = null };
                return true;
            }
            else
            {
                node.Right = new TreeNode<T> { Data = subordonat, Left = null, Right = null };
                return true;
            }
        }

        public void afisare()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                if (queue.Peek().Left != null) 
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null) 
                {
                    queue.Enqueue(queue.Peek().Right);
                }

                Console.Write(queue.Peek().Data + " ");

                queue.Dequeue();
            }
        }

        public void preorder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);

            preorder(node.Left);
            preorder(node.Right);
        }

        public void inorder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            inorder(node.Left);

            Console.Write(node.Data + " ");

            inorder(node.Right);
        }

        public void postorder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            postorder(node.Left);
            postorder(node.Right);
            Console.WriteLine(node.Data);
        }

        public int grad(TreeNode<T> node)
        {
            if (node == null)
                return 0;

            if (node.Left != null && node.Right != null)
                return 2 + grad(node.Left) + grad(node.Right);
            else if (node.Left != null && node.Right == null)
                return 1 + grad(node.Left);
            else if (node.Left == null && node.Right != null)
                return 1 + grad(node.Right);

            else
                return 0;
        }

        public int height(TreeNode<T> node)
        {
            if (node == null)
            {
                return -1;
            }

            return 1 + Math.Max(height(node.Left), height(node.Right));
        }

        public int nivel(TreeNode<T> node, T data)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Data.Equals(data))
            {
                return nivel(null, data);
            }

            else if (find(node.Left, data) != null)
                return 1 + nivel(node.Left, data);
            else if (find(node.Right, data) != null)
                return 1 + nivel(node.Right, data);

            return -1;
        }

    }
}
