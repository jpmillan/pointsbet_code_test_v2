using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointsBet_Backend_Online_Code_Test;

namespace PointsBet_Backend_Online_Code_Test.Tests
{
    [TestClass]
    public class StringFormatterTests
    {
        [TestMethod]
        public void ToCommaSeparatedList_ItemsWithSpaces_PreservesSpaces()
        {
            string[] items = { "Oro", "Plata", "Mata" };
            string result = StringFormatter.ToCommaSeparatedList(items, "'");
            Assert.AreEqual("'Oro', 'Plata', 'Mata'", result);
        }
        
    }
}