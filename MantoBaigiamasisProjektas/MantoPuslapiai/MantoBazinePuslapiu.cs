using OpenQA.Selenium;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    public class MantoBazinePuslapiu
    {
        protected IWebDriver driver;
        public MantoBazinePuslapiu(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}