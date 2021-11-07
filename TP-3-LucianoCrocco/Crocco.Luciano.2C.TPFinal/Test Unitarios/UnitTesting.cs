using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;
using System.Collections.Generic;

namespace Test_Unitarios
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        [ExpectedException(typeof(CaracteresInvalidoException))]
        public void TestCaracteresInvalidos()
        {
            Piloto piloto = new Piloto(" ", " ", 20, ESexo.Masculino, 50, true);
        }

        [TestMethod]
        [ExpectedException(typeof(PilotoRepetidoException))]
        public void TestPilotoRepetido()
        {
            Piloto p1 = new Piloto("Luciano", "Crocco", 20, ESexo.Masculino, 50, true);
            Piloto p2 = new Piloto("Luciano", "Crocco", 20, ESexo.Masculino, 50, true);
            List<Piloto> pilotos = new List<Piloto>();

            pilotos += p1;
            pilotos += p2;
        }
    }
}
