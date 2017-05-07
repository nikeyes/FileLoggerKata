using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileLoggerKata.UnitTests.Dado_Un_FileLogger
{
    [TestClass]
    public class Cuando_Llamo_Metodo_Log
    {
        [TestMethod]
        public void Entonces_Es_Obligatorio_Pasarle_Un_Parámetro_Message()
        {
            FileLogger _sut = new FileLogger();

            _sut.Log("Mensaje Obligatorio");

        }

        [TestMethod]
        public void Entonces_Anade_El_Mensaje_Al_Final_Del_Fichero_De_Log()
        {
            FileLogger _sut = new FileLogger();
            
            String expected = "Mensaje Obligatorio";

            _sut.Log("Mensaje Obligatorio");

            String actual = _sut.GetLastMessage();

            Assert.AreEqual(expected, actual);
        }
    }
}
