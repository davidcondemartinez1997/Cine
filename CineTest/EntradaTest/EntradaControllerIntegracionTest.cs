using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Cine.Entrada;

namespace CineTest.EntradaTest
{
    [TestClass]
    public class EntradaControllerIntegracionTest
    {
        private IEntradaController entradaController;

        [TestInitialize]
        public void Init()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();

            unityContainer.RegisterType<IEntradaController, EntradaController>();

            entradaController = unityContainer.Resolve<IEntradaController>();

        }

        [TestMethod]
        public void TestCreate()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);  
        }

        [TestMethod]
        public void TestDelete()
        {
            entradaController.Delete(1);
        }

        [TestMethod]
        public void TestRead()
        {
            entradaController.Read(1);
        }

        [TestMethod]
        public void TestReadAll()
        {
            entradaController.ReadAll();
        }

        [TestMethod]
        public void TestUpdate()
        {
            EntradaDTO entrada = new EntradaDTO();
            entradaController.Update(entrada);
        }
    }
}
