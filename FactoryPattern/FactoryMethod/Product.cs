namespace FactoryPattern.FactoryMethod
{
    public class Product
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public Size Size { get; set; }
    }
    
    public struct Size
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
    }
}