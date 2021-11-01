namespace FactoryPattern.AbstractFactory
{
    public interface IThemeFactory
    {
        IButton createButton();
        
        IInput createInput();
    }

    public class DarkThemeFactory : IThemeFactory
    {
        public IButton createButton()
        {
            return new DarkButton();
        }

        public IInput createInput()
        {
            return new DarkInput();
        }
    }
    
    public class PurpleThemeFactory : IThemeFactory
    {
        public IButton createButton()
        {
            return new PurpleButton();
        }

        public IInput createInput()
        {
            return new PurpleInput();
        }
    }
}