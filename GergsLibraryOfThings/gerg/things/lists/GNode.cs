using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GergsLibraryOfThings.gerg.things.lists
{
    public class GNode<T>
    {
        public T Item { get; set; }
        public GNode<T> NextNode { get; set; }

        public GNode(T item) {
            this.Item = item;
            this.NextNode = null;
        }

        public GNode(T item, GNode<T> nextNode) {
            this.Item = item;
            this.NextNode = nextNode;
        }
    }
}
