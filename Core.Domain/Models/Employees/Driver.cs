namespace TransporT.Shared.Models.Employees
{
    public class Driver
    {
        private int _id;
        private string _name;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public Driver(string name)
        {
            _name = name;
        }
    }
}
