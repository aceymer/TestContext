using DomainLogic.Context;
using DomainLogic.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicTest.Context
{
    [TestFixture]
    public class SchoolContextTest
    {
        [Test]
        public void Can_add_room_to_context_test()
        {
            var room = new Room() { Id = 1};
            var context = Context();
            context.Rooms.Add(room);
            context.SaveChanges();
            
            var roomFromDB = context.Rooms.FirstOrDefault(x => x.Id == room.Id);

            Assert.AreEqual(room.Id, roomFromDB.Id);

            var context2 = Context();
            var roomFromDB2 = context2.Rooms.FirstOrDefault(x => x.Id == room.Id);

            Assert.AreEqual(room.Id, roomFromDB2.Id);

        }

        [Test]
        public void Can_remove_room_from_context_test()
        {
            //Create Room from Context 1
            var room = new Room() { Id = 2 };
            var context = Context();
            context.Rooms.Add(room);
            context.SaveChanges();

            //Make sure Room exists from Context 2
            var context2 = Context();
            var roomFromDB = context2.Rooms.FirstOrDefault(x => x.Id == room.Id);
            Assert.IsNotNull(roomFromDB);

            //Delete Room from Context 2 and save
            context2.Rooms.Remove(roomFromDB);
            context2.SaveChanges();

            //Make sure room is deleted from Context 2
            var roomFromDB2 = context2.Rooms.FirstOrDefault(x => x.Id == room.Id);
            Assert.IsNull(roomFromDB2);

            //Make sure room is deleted from Context 3
            var roomFromDB3 = Context().Rooms.FirstOrDefault(x => x.Id == room.Id);
            Assert.IsNull(roomFromDB3);

        }

        [Test]
        public void Can_update_room_from_context_test()
        {
            //Create a room
            //Create a context (context 1)
            //Add a room to the context 1
            //Create a new context (context 2)
            //Update the room using the ATTACH keyword (Maybe change the name)
            //Update the room in the context 2 (DB)
            //Create a new context (context 3)
            //Assert that the name has been changed using context 3
        }

        private SchoolContext Context()
        {
            return new SchoolContext("SchoolTest");
        }
    }
}
