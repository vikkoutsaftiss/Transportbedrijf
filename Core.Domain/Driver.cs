namespace Core.Domain
{
    public class Driver
    {
        private string _name;
        public string Name { get { return _name; } }
        public Driver(string name)
        {
            _name = name;
        }
    }
}
