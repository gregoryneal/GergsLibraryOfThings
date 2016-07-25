using System.Collections.Generic;

namespace GergsLibraryOfThings.gerg.things.lists.markov
{
    class GMarkovChain<T>
    {
        List<GMarkovNode<T>> nodes = new List<GMarkovNode<T>>();

        public GMarkovChain() { }

        public GMarkovChain(List<GMarkovNode<T>> nodes) {
            this.nodes = nodes;
        }

        public void AddNode(GMarkovNode<T> node) {
            this.nodes.Add(node);
        }

        public List<GMarkovNode<T>> GenerateSequence(GMarkovNode<T> startNode, int length) {
            List<GMarkovNode<T>> sequence = new List<GMarkovNode<T>>();
            sequence.Add(startNode);

            for (int i = 1; i < length; i++) {
                sequence.Add(sequence[i - 1].GetNextRandomNode());
            }

            return sequence;
        }
    }
}
