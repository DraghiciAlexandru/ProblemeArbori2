using System;
using System.Collections.Generic;
using System.Text;

namespace Probleme2Arbori.Probleme
{
    class Problema1
    {

        public Problema1(BST<int> ierarhie, int nr)
        {
            insert(ierarhie.Root, nr);
        }

        public void insert(TreeNode<int> node, int nr)
        {
            if (node.Data > nr)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<int> { Data = nr, Left = null, Right = null };
                }
                else
                {
                    insert(node.Left, nr);
                }
            }
            else
            {
                if(node.Right==null)
                {
                    node.Right = new TreeNode<int> { Data = nr, Left = null, Right = null };
                }
                else
                {
                    insert(node.Right, nr);
                }
            }
        }

    }
}
