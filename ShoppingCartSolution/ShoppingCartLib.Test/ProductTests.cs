using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;

namespace ShoppingCartLib.Test
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductTest()
        {
            Product p = new Product(101,"chocolate",100,0.5f);
            Assert.AreEqual<int>(p.Id,101);
            Assert.AreEqual<string>(p.Name,"chocolate");
            Assert.AreEqual<double>(p.Price,100);
            Assert.AreEqual<float>(p.Discount,0.5f);
        }
    }
}
