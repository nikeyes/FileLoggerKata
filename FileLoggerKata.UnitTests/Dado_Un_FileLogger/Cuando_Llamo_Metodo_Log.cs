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
    }
}
