using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice1;

namespace Practice1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static string Main_IsText_Entered()
        {
            //arrange
            var txt = "lskjaljsflka";
            //act
            var actual =new Program.Main(txt);
            //assert
            Assert.AreEqual(txt, actual);
        }
    }
}
