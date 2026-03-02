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

        [TestMethod]
        public void ToCommaSeparatedList_EmptyArray_ReturnsEmptyString()
        {
            string[] items = { };
            string result = StringFormatter.ToCommaSeparatedList(items, "'");
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedList_SingleItemWithNoQuote_ReturnsItemOnly()
        {
            string[] items = { "onlyone" };
            string result = StringFormatter.ToCommaSeparatedList(items, "");
            Assert.AreEqual("onlyone", result);
        }

        [TestMethod]
        public void ToCommaSeparatedList_NumericStrings_FormatsCorrectly()
        {
            string[] items = { "67", "3.14", "-88", "0" };
            string result = StringFormatter.ToCommaSeparatedList(items, "`");
            Assert.AreEqual("`67`, `3.14`, `-88`, `0`", result);
        }
    }
}