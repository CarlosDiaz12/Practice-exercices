using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExercisesLib = Practice_exercices.Exercises;
namespace Practice_exercises.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AccumTest()
        {
            Assert.AreEqual("A-Bb-Ccc-Dddd", ExercisesLib.Accum("abcd"));
            Assert.AreEqual("R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy", ExercisesLib.Accum("RqaEzty"));
            Assert.AreEqual("C-Ww-Aaa-Tttt", ExercisesLib.Accum("cwAt"));
        }

        // [TestMethod]
        public void TestLinesCounter()
        {
            CollectionAssert.AreEqual(new List<string>() { }, ExercisesLib.LinesCounter(new List<string>() { }));
            CollectionAssert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, ExercisesLib.LinesCounter(new List<string> { "a", "b", "c" }));
            CollectionAssert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, ExercisesLib.LinesCounter(new List<string> { "", "", "", "", "" }));
        }

    }
}
