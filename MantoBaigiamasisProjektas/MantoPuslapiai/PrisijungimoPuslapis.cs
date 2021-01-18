using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class PrisijungimoPuslapis : MantoBazinePuslapiu

    {
        public PrisijungimoPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement mygtukasLogIn => driver.FindElement(By.Id("login2"));
        private IWebElement usernameLaukas => driver.FindElement(By.Id("loginusername"));
        private IWebElement passwordLaukas => driver.FindElement(By.Id("loginpassword"));
        private IWebElement logInMygtukas => driver.FindElement(By.CssSelector("#logInModal > div > div > div.modal-footer > button.btn.btn-primary"));
        private IWebElement logOutMygtukas => driver.FindElement(By.Id("logout2"));
        private IWebElement vartotojoPavadinimoIcona => driver.FindElement(By.Id("nameofuser"));

        public void PaspauskPirmaLogIn()
        {
            mygtukasLogIn.Click();
        }
        public void IveskUsername()
        {
            usernameLaukas.SendKeys("majanevici@gmail.com");
        }
        public void IveskPassword()
        {
            passwordLaukas.SendKeys("Mantukas12345");
        }
        public void PaspauskLogInMygtuka()
        {
            logInMygtukas.Click();
        }
        public void PatikrinkArTasVartotojas()
        {
            Assert.AreEqual("Welcome majanevici@gmail.com", vartotojoPavadinimoIcona.Text);
        }
        public void SekmingasAtsijungimas()
        {
            logOutMygtukas.Click();
        }
        public void IveskBlogaUsername()
        {
            usernameLaukas.SendKeys("mantas");
        }
        public void IveskBlogaPassword()
        {
            passwordLaukas.SendKeys("12345");
        }
    }
}