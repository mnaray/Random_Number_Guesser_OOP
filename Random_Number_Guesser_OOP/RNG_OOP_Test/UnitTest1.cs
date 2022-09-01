using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Random_Number_Guesser_OOP;

namespace RNG_OOP_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnTooLarge()
        {
            HintManager hintManager = new HintManager();
            using (StringWriter stringWriter = new StringWriter())
            {
                // reads stdOut of method
                Console.SetOut(stringWriter);
                hintManager.OnWrongAnswer(25, 5);

                // sets the expected and the actualy Value
                string expected = "Your guess was greater than the secret number. Try again.";
                string actual = stringWriter.ToString().Trim();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void OnTooLow()
        {
            HintManager hintManager = new HintManager();
            using (StringWriter stringWriter = new StringWriter())
            {
                // reads stdOut of method
                Console.SetOut(stringWriter);
                hintManager.OnWrongAnswer(25, 35);

                // sets the expected and the actualy Value
                string expected = "Your guess was below the the secret number. Try again.";
                string actual = stringWriter.ToString().Trim();

                Assert.AreEqual(expected, actual);
            }
        }


    }
}