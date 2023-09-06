using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonParser.Models;

namespace JsonParser.Tests
{
    [TestClass()]
    public class JsonWriterToFileTests
    {

        [TestMethod()]
        public void WriteDataTest()
        {
            var conflicts = new List<Conflict>()
            { 
                new Conflict() { BrigadeCode = "12345", DevicesSerials = new string[] {"94678","8546845","78465786" } },
                new Conflict() { BrigadeCode = "67890", DevicesSerials = new string[] {"45645238","3783783","4254534" } },
                new Conflict() { BrigadeCode = "11111", DevicesSerials = new string[] {"11111","123131","12312145" } }
            };

            var jsonWriter = new JsonWriterToFile(conflicts);
            jsonWriter.WriteData();


            Assert.IsNotNull(conflicts);
        }
    }
}