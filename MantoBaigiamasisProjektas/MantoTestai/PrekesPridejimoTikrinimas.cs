using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class PrekesPridejimoTikrinimas : MantoBazine

    {
        private PrekiuPuslapis prekiuPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            prekiuPuslapis = new PrekiuPuslapis(driver);
        }
        [Test]
        public void PridekPreke()
        {
            prekiuPuslapis.PaspauskKategorijosMygtuka();
            Thread.Sleep(3000);
            prekiuPuslapis.PaspauskTelefonaiMygtuka();
            Thread.Sleep(3000);
            prekiuPuslapis.PaspauskIphone6();
            Thread.Sleep(3000);
            prekiuPuslapis.PridekTelefonaIkrepseli();
            Thread.Sleep(3000);
            //prekiuPuslapis.PaspauskPranesimeClose();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            prekiuPuslapis.PaspauskKrepselis();
            Thread.Sleep(3000);
            prekiuPuslapis.PaspauskMygtukaIstrinti();
            Thread.Sleep(3000);
        }
    }
}