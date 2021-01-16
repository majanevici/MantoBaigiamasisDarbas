using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class UrlTikrinimas : MantoBazine

    {
        private NotaruRumaiPuslapis notaruRumaiPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            notaruRumaiPuslapis = new NotaruRumaiPuslapis(driver);
        }
        [Test]
        public void ArTikraiTamePuslapyjeEsi()

        {
            notaruRumaiPuslapis.IsjunkSlapukus();
            Thread.Sleep(2000);
            notaruRumaiPuslapis.IsskleiskNaujienas();
            Thread.Sleep(2000);
            notaruRumaiPuslapis.PalyginkURL();
            Thread.Sleep(2000);
            
        }
    }
}
