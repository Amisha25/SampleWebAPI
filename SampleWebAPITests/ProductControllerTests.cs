using NUnit.Framework;
using SampleWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleWebAPITests
{
    [TestFixture]
    public class ProductControllerTests
    {
        [Test]
        public void Get_NoParams_ReturnsProductList()
        {
            var productController = new ProductController();

            var result = productController.Get();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }


        [Test]
        public void Get_ValidParam_ReturnsProduct()
        {
            var productController = new ProductController();

            var result = productController.Get(0);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(0));
            Assert.That(result.Name, Is.EqualTo("Red Truck"));
            Assert.That(result.Description, Is.Not.Null);
        }
    }
}