using DomainLogic.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicTest.Model
{
    [TestFixture]
    public class RoomTest
    {
        [Test]
        public void Properties_are_set_on_create_test()
        {
            Room room = new Room() { Id = 1, Name = "School1", Capacity = 5 };
            Assert.AreEqual(room.Id, 1);
            Assert.AreEqual(room.Name, "School1");
            Assert.AreEqual(room.Capacity, 5);
        }

        [Test]
        public void Room_name_cannot_be_empty_test()
        {
            var room = new Room();
            Assert.IsNotNull(room.Name);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Name_propertie_cannot_be_set_to_null_test()
        {
            Room room = new Room();
            room.Name = null;
        }
    }
}
