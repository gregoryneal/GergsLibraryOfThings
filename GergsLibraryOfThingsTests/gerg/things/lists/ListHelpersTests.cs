using Microsoft.VisualStudio.TestTools.UnitTesting;
using GergsLibraryOfThings.gerg.things.lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GergsLibraryOfThings.gerg.things.lists.Tests
{
    [TestClass()]
    public class ListHelpersTests
    {
        [TestMethod()]
        public void ReverseGLinkedListTest()
        {
            //Arrange
            GNode<int> c = new GNode<int>(3);
            GNode<int> b = new GNode<int>(2, c);
            GNode<int> a = new GNode<int>(1, b);
            GLinkedList<int> list = new GLinkedList<int>(a);

            //Act
            ListHelpers.ReverseGLinkedList(ref list);

            //Assert
            Assert.AreSame(list.Head, c);
            Assert.AreSame(list.GetLastNode(), a);
            Assert.AreSame(list.Head.NextNode, b);
        }
    }
}