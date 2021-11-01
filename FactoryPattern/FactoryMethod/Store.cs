namespace FactoryPattern.FactoryMethod
{
    public abstract class Store
    {
        private readonly Product _product;

        protected Store(Product product)
        {
            _product = product;
        }
        
        public decimal Checkout()
        {
            var shipper = GetShipper();

            return shipper.CalculateFee(_product);
        }

        protected abstract IShipper GetShipper();
    }

    public class AppleStore : Store
    {
        public AppleStore(Product product)
            : base(product)
        {
        }
        
        protected override IShipper GetShipper()
        {
            return new Blackcat();
        }
    }
    
    public class PCHome : Store
    {
        public PCHome(Product product)
            : base(product)
        {
        }

        protected override IShipper GetShipper()
        {
            return new Postoffice();
        }
    }
}