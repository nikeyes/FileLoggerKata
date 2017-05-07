using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileLoggerKata.UnitTests.Dado_Un_FileLogger
{
    [TestClass]
    public class Cuando_Llamo_Metodo_Log
    {
        private ILogger _sut;
        
        [TestInitialize]
        public void TestInitialize()
        {
           _sut = new MemoryLogger();
        }

        [TestMethod]
        public void Entonces_Es_Obligatorio_Pasarle_Un_Parámetro_Message()
        {
            _sut.Log("Mensaje Obligatorio");
        }

        [TestMethod]
        public void Entonces_Anade_El_Mensaje_Al_Final_Del_Fichero_De_Log()
        {
            String expected = "Mensaje Obligatorio";

            _sut.Log("Mensaje Obligatorio");

            String actual = _sut.GetLastMessage();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Y_Se_Han_Logado_3_Mensajes_Entonces_Hay_3_Mensajes_En_El_Log()
        {
            int expected = 3;

            _sut.Log("Mensaje Obligatorio 1");
            _sut.Log("Mensaje Obligatorio 2");
            _sut.Log("Mensaje Obligatorio 3");

            int actual = _sut.GetNumMessages();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Entonces_Escribe_Logs_En_Fichero_log_txt()
        {
            String expected = "log.txt";

            _sut.Log("Mensaje");

            String actual = _sut.GetLastMessage();

            Assert.AreEqual(expected, actual);
        }
    }
}
