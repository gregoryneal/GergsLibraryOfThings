using GergsLibraryOfThings.gerg.things.lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GergsLibraryOfThings.gerg.things.lists
{
    public static class ListHelpers
    {
        public static void ReverseGLinkedList<T>(ref GLinkedList<T> list) {
            if (list.IsEmpty()) return;

            GLinkedList<T> copy = new GLinkedList<T>();
            while (!list.IsEmpty()) {
                copy.Push(list.Pop());
            }

            list = copy;
        }

    }
}
