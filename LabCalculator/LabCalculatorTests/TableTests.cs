using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Tests
{
    [TestClass()]
    public class TableTests
    {
        [TestMethod]
        public void Power_6to0_1expected()
        {
            //arrange
            string numberr = "6";
            string power = "0";
            string expected = "1";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr + "^" + power);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_13to0_infinityexpected()
        {
            //arrange
            string numberr = "12";
            string divide = "6";
            string expected = "2";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr + "/" + divide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void div_16to2_8expected()
        {
            //arrange
            string numberr = "16";
            string div = "2";
            string expected = "8";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr + " div " + div);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}