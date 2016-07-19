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
    public class GLinkedListTests
    {
        [TestMethod()]
        public void GLinkedListTest()
        {
            //Arrange
            GNode<int> tail = new GNode<int>(2);
            GNode<int> middle = new GNode<int>(1, tail);
            GNode<int> head = new GNode<int>(0, middle); 
            GLinkedList<int> lst = new GLinkedList<int>(head);

            //Act
            GNode<int> expectedHead = lst.Head;
            GNode<int> expectedMiddle = lst.Head.NextNode;
            GNode<int> expectedTail = lst.GetLastNode();

            //Assert
            Assert.AreSame(head, expectedHead);
            Assert.AreSame(middle, expectedMiddle);
            Assert.AreSame(tail, expectedTail);
        }

        [TestMethod()]
        public void AddToEmptyListTest()
        {
            //Arrange
            GLinkedList<int> original = new GLinkedList<int>();
            GNode<int> head = new GNode<int>(23);

            //Act
            original.Add(head);

            //Assert
            Assert.AreSame(head, original.Head);
        }
    }
}