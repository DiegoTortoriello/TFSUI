﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;


namespace SeleniumUI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http:google.com");

        }
    }
}