using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler243;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler243.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void eulerphiTest3()
        {
            long n = Euler243.Program.eulerphi(3);
            Assert.AreEqual<long>(2, n);
        }

        [TestMethod()]
        public void eulerphiTest99()
        {
            long n = Euler243.Program.eulerphi(99);
            Assert.AreEqual<long>(60, n);
        }
    }
}