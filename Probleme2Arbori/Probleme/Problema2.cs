using System;
using System.Collections.Generic;
using System.Text;

namespace Probleme2Arbori.Probleme
{
    class Problema2
    {
        public Problema2(BST<int> bst, int x)
        {
            bst.delete(bst.Root, x);
        }
    }
}
