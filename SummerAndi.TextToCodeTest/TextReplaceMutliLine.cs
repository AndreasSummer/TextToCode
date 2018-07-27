using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SummerAndi.TextToCodeTest
{
    [TestClass]
    public class TextReplaceMutliLine
    {
        [TestMethod]
        public void ListCreateRightCount()
        {
            string inp = "Hallo" + Environment.NewLine + "Welt";

            SummerAndi.TextToCodeLogic.Patterns.TextReplaceMutliLine m = new TextToCodeLogic.Patterns.TextReplaceMutliLine();
            var x = m.CreateListFromString(inp);

            Assert.AreEqual(2, x.Count);
        }

        [TestMethod]
        public void ListCreateItems()
        {
            string inp = "Hallo" + Environment.NewLine + "Welt";

            SummerAndi.TextToCodeLogic.Patterns.TextReplaceMutliLine m = new TextToCodeLogic.Patterns.TextReplaceMutliLine();
            var x = m.CreateListFromString(inp);

            Assert.AreEqual("Hallo", x[0],"Erste Objekt richtig");
            Assert.AreEqual("Welt", x[1], "zweite Objekt richtig");
        }

        [TestMethod]
        public void ConvertTest()
        {
            string inp = "Hallo" + Environment.NewLine + "Welt";

            SummerAndi.TextToCodeLogic.Patterns.TextReplaceMutliLine m = new TextToCodeLogic.Patterns.TextReplaceMutliLine();
            var x = m.Convert(inp, "Text = {placeholder}");

            var exp = "Text = Hallo" + Environment.NewLine + "Text = Welt";
            Assert.AreEqual(exp, x);


        }

    }
}
