using System;
using ClasesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DniInvalidoParaExtrangero()
        {
            bool fallo = false;

            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458",
                EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Deudor);                
            }
            catch (NacionalidadInvalidaException e)
            {
                Console.WriteLine(e.Message);
                fallo = true;
            }

            Assert.IsTrue(fallo);
        }

        [TestMethod]
        public void DniInvalidoParaArgentino()
        {
            bool fallo = false;

            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "999999999",
                EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Deudor);
            }
            catch (NacionalidadInvalidaException e)
            {
                Console.WriteLine(e.Message);
                fallo = true;
            }

            Assert.IsTrue(fallo);
        }

        [TestMethod]
        public void ValorNumerico()
        {
            bool fallo = false;

            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "asdasda",
                EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Deudor);
            }
            catch (DniInvalidoException e)
            {
                Console.WriteLine(e.Message);
                fallo = true;
            }

            Assert.IsTrue(fallo);
        }


        [TestMethod]
        public void NoNulos()
        {
            Universidad gim = new Universidad();

            Assert.IsTrue(gim.Instructores != null);

            Assert.IsTrue(gim.Jornadas != null);

        }


    }
}
