﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Hello World", result.ElementAt(0));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
