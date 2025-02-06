namespace Milestone_3
{
    public class Actors
    {
        private readonly Dictionary<int, string> _actors = new Dictionary<int, string>()
        {
            {1, "Robert Downy Jr" },
            {2, "Chris Evans" },
            {3, "Tom Holland" },
            {4, "Ryan Reynolds" },
            {5, "Chris Hemsworth" },
            {6, "Scarlet Johanson" },
            {7, "Mark Ruffalo" }
        };

        public string this[int key]
        {
            get { return _actors[key]; }
            set { _actors[_actors.Count] = value; }
        }

        public void GetActors()
        {
            foreach (var x in _actors)
            {
                Console.WriteLine(x.Key.ToString() + ". " + x.Value);
            }
        }
        public int GetActorsCount()
        {
            return _actors.Count;
        }
    }
}
