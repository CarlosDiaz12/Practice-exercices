using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PEMethods = Practice_exercices.Program;
namespace Practice_exercises.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AccumTest()
        {
            Assert.AreEqual("A-Bb-Ccc-Dddd", PEMethods.Accum("abcd"));
            Assert.AreEqual("R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy", PEMethods.Accum("RqaEzty"));
            Assert.AreEqual("C-Ww-Aaa-Tttt", PEMethods.Accum("cwAt"));
        }

        // [TestMethod]
        public void TestLinesCounter()
        {
            CollectionAssert.AreEqual(new List<string>() { }, PEMethods.LinesCounter(new List<string>() { }));
            CollectionAssert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, PEMethods.LinesCounter(new List<string> { "a", "b", "c" }));
            CollectionAssert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, PEMethods.LinesCounter(new List<string> { "", "", "", "", "" }));
        }

    }
}
