using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrinaryTree;

namespace TrinaryTreeTest
{
    [TestClass]
    public class TrinaryTest
    {
        
        [TestMethod]
        public void InsertTest()
        {
            //5, 4, 9, 5, 7, 2, 2 

            Trinary trinary = new Trinary();
            trinary.Insert(5);
            trinary.Insert(4);
            trinary.Insert(9);
            trinary.Insert(5);
            trinary.Insert(7);
            trinary.Insert(2);
            trinary.Insert(2);

            trinary.Display(trinary.root);

            System.Diagnostics.Debug.WriteLine("=============================================");
            trinary.Delete(trinary.root, 5);
            System.Diagnostics.Debug.WriteLine("=============================================");

            trinary.Display(trinary.root);
            System.Diagnostics.Debug.WriteLine("=============================================");

        }
    }
}
