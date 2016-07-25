using System.Collections.Generic;
using System;

namespace GergsLibraryOfThings.gerg.things.lists.markov
{
    class GMarkovNode<T>
    {
        private List<GMarkovLink<T>> connections = new List<GMarkovLink<T>>();

        public GMarkovNode() {
            EnsureProbabilitySumIsLessThanOne();
        }

        public GMarkovNode(List<GMarkovLink<T>> connections) {
            this.connections = connections;
            EnsureProbabilitySumIsLessThanOne();
        }

        public GMarkovNode(GMarkovLink<T> singularNode, params GMarkovLink<T>[] otherNodes) {
            this.connections.Add(singularNode);

            if (otherNodes.Length > 0) {
                foreach(GMarkovLink<T> link in otherNodes) {
                    this.connections.Add(link);
                }
            }

            EnsureProbabilitySumIsLessThanOne();
        }

        public void AddLink(GMarkovLink<T> link) {
            this.connections.Add(link);

            EnsureProbabilitySumIsLessThanOne();
        }

        public GMarkovNode<T> GetNextRandomNode() {

            Random random = new Random();
            double val = random.NextDouble();
            double prob = GetTotalProbability();

            while (val >= prob) {
                val = random.NextDouble();
            }

            double sum = 0;
            GMarkovNode<T> ret = new GMarkovNode<T>();

            for (int i = 0; i < connections.Count; i++) {
                sum += connections[i].Probability;

                if (val < sum) {
                    ret = connections[i].GetHeadNode();
                    break;
                }
            }

            return ret;
        }

        private void EnsureProbabilitySumIsLessThanOne() {
            
            double sum = GetTotalProbability();

            if (sum > 1) {
                throw new ProbabilityGreaterThanOneException("The probability sum of a node is greater than 1.");
            }
        }

        private double GetTotalProbability() {

            double sum = 0;

            foreach(GMarkovLink<T> link in this.connections) {
                sum += link.Probability;
            }

            return sum;
        }
    }
}
