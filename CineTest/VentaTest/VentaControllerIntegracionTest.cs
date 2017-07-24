using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Cine.Venta;

namespace CineTest.VentaTest
{
    [TestClass]
    public class VentaControllerIntegracionTest
    {
        private IVentaController ventaController;

        [TestInitialize]
        public void Init()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IVentaRepository, VentaRepository>();
            unityContainer.RegisterType<IVentaService, VentaService>();
            unityContainer.RegisterType<IVentaConverter, VentaConverter>();

            unityContainer.RegisterType<IVentaController, VentaController>();

            ventaController = unityContainer.Resolve<IVentaController>();

        }

        [TestMethod]
        public void TestCreate()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaController.Create(ventaDTO);
        }

        [TestMethod]
        public void TestDelete()
        {
            ventaController.Delete(1);
        }

        [TestMethod]
        public void TestRead()
        {
            ventaController.Read(1);
        }

        [TestMethod]
        public void TestReadAll()
        {
            ventaController.ReadAll();
        }

        [TestMethod]
        public void TestUpdate()
        {
            VentaDTO entrada = new VentaDTO();
            ventaController.Update(entrada);
        }
    }
}
