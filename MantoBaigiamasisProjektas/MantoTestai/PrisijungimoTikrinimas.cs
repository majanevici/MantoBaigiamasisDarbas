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
        public void NeprisijunkPrieTinklapio()
        {
            prisijungimoPuslapis.PaspauskPirmaLogIn();
            Thread.Sleep(5000);
            prisijungimoPuslapis.IveskBlogaUsername();
            prisijungimoPuslapis.IveskBlogaPassword();
            
            prisijungimoPuslapis.PaspauskLogInMygtuka();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(4000);
        }

        [Test]
        public void PrisijunkPrieTinklapio()
        {
            prisijungimoPuslapis.PaspauskPirmaLogIn();
            Thread.Sleep(5000);
            prisijungimoPuslapis.IveskUsername();
            prisijungimoPuslapis.IveskPassword();
            prisijungimoPuslapis.PaspauskLogInMygtuka();
            Thread.Sleep(3000);
            prisijungimoPuslapis.SekmingasAtsijungimas();

            Thread.Sleep(4000);
        }
      


    }

    
}
