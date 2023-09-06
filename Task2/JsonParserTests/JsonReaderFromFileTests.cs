using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonParser.Tests
{
    [TestClass()]
    public class JsonReaderFromFileTests
    {
        [TestMethod()]
        public void ReadDataTest()
        {
            var jsonReader = new JsonReaderFromFile();

            string data = jsonReader.ReadData(); 
            
            Assert.IsNotNull(data);
            Assert.AreNotEqual("\r\n", data);    
        }
    }
}