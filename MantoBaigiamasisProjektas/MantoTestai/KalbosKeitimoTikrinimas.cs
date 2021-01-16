using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class KalbosKeitimoTikrinimas : MantoBazine

    {
        private KalbosPuslapis kalbosPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            kalbosPuslapis = new KalbosPuslapis(driver);
        }
        [Test]
        public void PakeiskKalbaIAnglu()

        {
            kalbosPuslapis.IsjunkSlapukus();
            Thread.Sleep(2000);
            kalbosPuslapis.IsskleiskKalbas();
            Thread.Sleep(2000);
            kalbosPuslapis.PasirinkKalba();
            Thread.Sleep(2000);
            kalbosPuslapis.PalyginkArPasiketeKalba();
            Thread.Sleep(2000);
        }
    }
}
