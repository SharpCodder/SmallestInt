using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SmallestInt.Tests
{    
    [TestFixture]
    public class SmallestIntServiceTests
    {
        [Test]
        public void NullArrayListShouldThrowError()
        {
            SmallestIntService service = new SmallestIntService();
            Assert.Throws<NullReferenceException>(() => service.Get(null));
        }
    }
}
