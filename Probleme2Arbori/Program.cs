using Probleme2Arbori.Probleme;
using System;

namespace Probleme2Arbori
{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int> ierarhie = new BST<int>();
            ierarhie.insert(8);
            ierarhie.insert(3);
            ierarhie.insert(10);
            ierarhie.insert(1);
            ierarhie.insert(6);
            ierarhie.insert(4);
            ierarhie.insert(7);
            ierarhie.insert(14);
            ierarhie.insert(13);
            BST<int> ierarhie2 = new BST<int>();
            ierarhie2.insert(8);
            ierarhie2.insert(3);
            ierarhie2.insert(10);
            ierarhie2.insert(2);
            ierarhie2.insert(6);
            ierarhie2.insert(4);
            ierarhie2.insert(7);
            ierarhie2.insert(14);
            ierarhie2.insert(13);

            Problema3 problema1 = new Problema3(ierarhie, ierarhie2);
        }
    }
}
