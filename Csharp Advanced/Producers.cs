namespace Milestone_3
{
    public class Producers
    {
        private readonly Dictionary<int, string> _producers = new Dictionary<int, string>()
    {
        {1, "Kevin Feige" },
        {2, "Kathleen Kennedy" },
        {3, "Jerry Bruckheimer" },
        {4, "Steven Spielberg" },
        {5, "Christopher Nolan" },
        {6, "James Cameron" },
        {7, "Peter Jackson" }
    };

        public string this[int key]
        {
            get { return _producers[key]; }
            set { _producers[_producers.Count] = value; }
        }

        public void GetProducers()
        {
            foreach (var x in _producers)
            {
                Console.WriteLine(x.Key.ToString() + ". " + x.Value);
            }
        }

        public int GetProducerCount()
        {
            return _producers.Count;
        }
    }
}
