namespace ComputerProject
{
    public class Bag : IBag
    {
        public string Name { get; }
        public int NumberOfCompartments { get; }
        public string Color { get; }
        public string Material { get; }

        public Bag(string name, int numberOfCompartments, string color, string material)
        {
            Name = name;
            NumberOfCompartments = numberOfCompartments;
            Color = color;
            Material = material;
        }

        public override string ToString()
        {
            return $"Bag Name: {Name}, Compartments: {NumberOfCompartments}, Color: {Color}, Material: {Material}";
        }
    }
}