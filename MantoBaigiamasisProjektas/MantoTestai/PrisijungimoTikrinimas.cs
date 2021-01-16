using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class PrisijungimoTikrinimas : MantoBazine

    {
        private PrisijungimoPuslapis prisijungimoPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            prisijungimoPuslapis = new PrisijungimoPuslapis(driver);
        }

        [Test]
        public void NesekmingasPrisijungimasPrieTinklapio()
        {
            prisijungimoPuslapis.PaspauskPirmaLogIn();
            Thread.Sleep(2000);
            prisijungimoPuslapis.IveskBlogaUsername();
            prisijungimoPuslapis.IveskBlogaPassword();
            prisijungimoPuslapis.PaspauskLogInMygtuka();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
        }
        [Test]
        public void PrisijunkPrieTinklapioIrAtsijunk()
        {
            prisijungimoPuslapis.PaspauskPirmaLogIn();
            Thread.Sleep(2000);
            prisijungimoPuslapis.IveskUsername();
            prisijungimoPuslapis.IveskPassword();
            prisijungimoPuslapis.PaspauskLogInMygtuka();
            Thread.Sleep(2000);
            prisijungimoPuslapis.PatikrinkArTasVartotojas();
            Thread.Sleep(2000);
            prisijungimoPuslapis.SekmingasAtsijungimas();
            Thread.Sleep(2000);
        }
    }
}
