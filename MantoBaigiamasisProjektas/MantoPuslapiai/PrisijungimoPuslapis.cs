using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class PrisijungimoPuslapis : MantoBazinePuslapiu

    {
        public PrisijungimoPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement paspauskMygtukaLogIn => driver.FindElement(By.Id("login2"));
        private IWebElement iveskUsernameLaukas => driver.FindElement(By.Id("loginusername"));
        private IWebElement iveskPasswordLaukas => driver.FindElement(By.Id("loginpassword"));
        private IWebElement paspauskLogInMygtukas => driver.FindElement(By.CssSelector("#logInModal > div > div > div.modal-footer > button.btn.btn-primary"));
        private IWebElement paspauskLogOutMygtukas => driver.FindElement(By.Id("logout2"));

        public void PaspauskPirmaLogIn()
        {
            paspauskMygtukaLogIn.Click();
        }
        public void IveskUsername()
        {
            iveskUsernameLaukas.SendKeys("majanevici@gmail.com");
        }
        public void IveskPassword()
        {
            iveskPasswordLaukas.SendKeys("Mantukas12345");
        }
        public void PaspauskLogInMygtuka()
        {
            paspauskLogInMygtukas.Click();
        }
        public void SekmingasAtsijungimas()
        {
            paspauskLogOutMygtukas.Click();

        }
        public void IveskBlogaUsername()
        {
            iveskUsernameLaukas.SendKeys("mantas");
        }
        public void IveskBlogaPassword()
        {
            iveskPasswordLaukas.SendKeys("12345");
        }

    }
}