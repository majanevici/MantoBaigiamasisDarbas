using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class NotaroBuveinesTikrinimas : MantoBazine

    {
        private NotaroBuveinesPuslapis notaroBuveinesPuslapis;

        [SetUp]
        public void NotaroBuveine()
        {
            notaroBuveinesPuslapis = new NotaroBuveinesPuslapis(driver);
        }
        [Test]
        public void SuraskNotaroBiura()

        {
            notaroBuveinesPuslapis.IsjunkSlapukus();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PaieskosLaukas();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.IveskNotara();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PaspauskIeskoti();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PaspauskAntNotaro();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.Biuras();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.SuraskBiuraGoogle();
            Thread.Sleep(2000);
        }
    }
}
