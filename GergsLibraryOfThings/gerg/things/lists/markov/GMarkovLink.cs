namespace GergsLibraryOfThings.gerg.things.lists.markov
{
    class GMarkovLink<T>
    {
        GMarkovNode<T> head;
        GMarkovNode<T> tail;
        double probability;
        public double Probability
        {
            get
            {
                return probability;
            }

            set
            {
                EnsureProbabilityIsLessThanOne(value);
                probability = value;
            }
        }

        public GMarkovLink(GMarkovNode<T> from, GMarkovNode<T> to, double probability) {
            this.tail = from;
            this.head = to;
            this.Probability = probability;
        }

        public GMarkovLink(GMarkovNode<T> to, double probability) {
            this.head = to;
            this.Probability = probability;
        }

        private void EnsureProbabilityIsLessThanOne(double prob) {
            if (prob > 1) {
                throw new ProbabilityGreaterThanOneException("Markov link cannot have a probability greather than 1.");
            }
        }

        public GMarkovNode<T> GetHeadNode() {
            return this.head;
        }

        public GMarkovNode<T> GetTailNode() {
            return this.tail;
        }
    }
}
