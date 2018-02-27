using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoorControl;

namespace DoorControl.Unit.Test
{
    public class DoorControlTest
    {
        private DoorControl uut = new DoorControl();

        [Test]
        public void AddTest()
        {
            Assert.That(uut.Add(3, 6), Is.EqualTo(9));
        }

}
}
