using System;
using System.Collections;
using System.Collections.Generic;

namespace GergsLibraryOfThings.gerg.things.lists
{
    public class GLinkedList<T>
    {
        public GNode<T> Head;
        
        public GLinkedList(GNode<T> head)
        {
            this.Head = head;
        }

        public GLinkedList()
        {
            this.Head = null;
        }

        public void Add(T item) {
            GNode<T> newNode = new GNode<T>(item);
            Add(newNode);
        }

        public void Add(GNode<T> newNode) {
            GNode<T> curr = this.Head;
            //List is empty
            if (curr == null) {
                this.Head = newNode;
            }
            else {
                GetLastNode().NextNode = newNode;
            }
        }

        public T GetLastItem() {
            return GetLastNode().Item;
        }

        public GNode<T> GetLastNode() {
            GNode<T> curr = this.Head;
            if (curr == null) return null;
            else {
                while (curr.NextNode != null) {
                    curr = curr.NextNode;
                }

                return curr;
            }
        }
    }
}
