using UC18;

namespace MSTest
{
    [TestClass]
    public class TesteCalculadora
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Ação
            var resultado = Calculadora.Somar(pNum, sNum);

            //Verificação
            Assert.AreEqual(rNum, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]

        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
           
            var resultado = Calculadora.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);
        }
    }
}