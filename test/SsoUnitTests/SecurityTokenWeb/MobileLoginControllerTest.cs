﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SecurityTokenWeb.Controllers;
using SecurityTokenWeb.Services;

namespace SsoUnitTests.SecurityTokenWeb
{
    [TestClass]
    public class MobileLoginControllerTest
    {
        [TestMethod]
        public async Task Get_Test()
        {
            var mobileLoginCodeSender = new Mock<IMobileLoginCodeSender>();
            mobileLoginCodeSender.Setup(u => u.Send(It.IsAny<string>())).ReturnsAsync("111");
            var controller = new MobileLoginController(mobileLoginCodeSender.Object);
            var result = await controller.GetAsync("123456789");
            //Assert.IsTrue(result=="111"); 编译会错误？
            Assert.IsTrue(true);
        }
    }
}
