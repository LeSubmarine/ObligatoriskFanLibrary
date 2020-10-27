using System;
using FanLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FanLibraryUnitTest
{
    [TestClass]
    public class FanOutputUnitTest
    {
        private FanOutput _fanOutput;
        private int _testId;
        private string _testName;
        private double _testTemp;
        private double _testHumidity;

        [TestInitialize]
        public void preTest()
        {
            _fanOutput = null;
            _testId = 0;
            _testName = "Id test";
            _testTemp = 20;
            _testHumidity = 40;
        }

        [TestMethod]
        public void TestContructor()
        {
            _fanOutput = new FanOutput();
            _fanOutput = new FanOutput(_testId, _testName, _testTemp, _testHumidity);
            Assert.AreEqual(_testId,_fanOutput.Id);
            Assert.AreEqual(_testName,_fanOutput.Name);
            Assert.AreEqual(_testTemp, _fanOutput.Temperature);
            Assert.AreEqual(_testHumidity,_fanOutput.Humidity);
        }
        [TestMethod]
        public void TestId()
        {
            _fanOutput = new FanOutput();
            _fanOutput.Id = -9999;
            _fanOutput.Id = 0;
            _fanOutput.Id = 9999;
            _fanOutput = new FanOutput(0,"Id test",20,40);
            _fanOutput.Id = -9999;
            _fanOutput.Id = 0;
            _fanOutput.Id = 9999;
        }
        [TestMethod]
        public void TestName()
        {
            string nameCheck;
            _fanOutput = new FanOutput();
            try
            {
                nameCheck = _fanOutput.Name;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }

            _fanOutput = new FanOutput();
            try
            {
                _fanOutput.Name = "";
                Assert.Fail();
            }
            catch (FormatException)
            {

            }

            _fanOutput = new FanOutput();
            _fanOutput.Name = "Test";
            Assert.AreEqual("Test",_fanOutput.Name);

            _fanOutput = new FanOutput(_testId,_testName,_testTemp,_testHumidity);
            _fanOutput.Name = "NewTest";
            Assert.AreEqual("NewTest",_fanOutput.Name);
        }
        [TestMethod]
        public void TestTemperature()
        {
            double tempCheck;
            _fanOutput = new FanOutput();
            try
            {
                tempCheck = _fanOutput.Temperature;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }

            _fanOutput = new FanOutput();
            try
            {
                _fanOutput.Temperature = 0.00;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }

            _fanOutput = new FanOutput();
            _fanOutput.Temperature = 16;
            Assert.AreEqual(16, _fanOutput.Temperature);

            _fanOutput = new FanOutput(_testId, _testName, _testTemp, _testHumidity);
            Assert.AreEqual(_testTemp, _fanOutput.Temperature, 0.001);

            _fanOutput.Temperature = 17.4;
            Assert.AreEqual(17.4, _fanOutput.Temperature,0.001);

            try
            {
                _fanOutput.Temperature = 25.00001;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }
            _fanOutput.Temperature = 15;
            _fanOutput.Temperature = 25;
        }
        [TestMethod]
        public void TestHumidity()
        {
            double humidityCheck;
            _fanOutput = new FanOutput();
            try
            {
                humidityCheck = _fanOutput.Humidity;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }

            _fanOutput = new FanOutput();
            try
            {
                _fanOutput.Humidity = 0.00;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }

            _fanOutput = new FanOutput();
            _fanOutput.Humidity = 37;
            Assert.AreEqual(37, _fanOutput.Humidity);

            _fanOutput = new FanOutput(_testId, _testName, _testTemp, _testHumidity);
            Assert.AreEqual(_testHumidity, _fanOutput.Humidity, 0.001);

            _fanOutput.Humidity = 37.4;
            Assert.AreEqual(37.4, _fanOutput.Humidity, 0.001);

            try
            {
                _fanOutput.Humidity = 80.00001;
                Assert.Fail();
            }
            catch (FormatException)
            {

            }
        }
    }
}
