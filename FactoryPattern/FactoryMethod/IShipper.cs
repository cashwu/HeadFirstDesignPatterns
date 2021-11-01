namespace FactoryPattern.FactoryMethod
{
    public interface IShipper
    {
        decimal CalculateFee(Product product);
        
        string Name { get; }
    }

    public class Blackcat : IShipper
    {
        public decimal CalculateFee(Product product)
        {
            var weight = product.Weight;
            if (weight > 20)
            {
                return 500;
            }

            return (decimal) (100 + weight * 10);
        }

        public string Name => "-- 黑貓 --";
    }

    public class Postoffice : IShipper
    {
        public decimal CalculateFee(Product product)
        {
            var weight = product.Weight;
            var feeByWeight = 80 + weight * 10;

            var size = product.Size.Length * product.Size.Width * product.Size.Height;

            var feeBySize = size * 0.0000353 * 1100;

            return feeByWeight < feeBySize ? (decimal) feeByWeight : (decimal) feeBySize;
        }

        public string Name => "-- 郵局 --";
    }
}
