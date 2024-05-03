using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoreTestes
{
    public class ValidaStringTeste
    {
        private ValidaString _validaString;

        public ValidaStringTeste()
        {
            _validaString = new ValidaString();
        }

        [Fact]
        public void Retorna3CaracteresEmOla()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validaString.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }
    }
}