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
    public class SchoolTest
    {
        [Test]
        public void School_properties_are_set_on_create_test()
        {
            var room = new Room() { Id = 1 };
            var createdDate = DateTime.Now;
            School school = new School()
            {
                CreatedDate = createdDate,
                Rooms = new List<Room>() { room },
                Name = "TheSchool",
                Id = 1
            };

            Assert.AreEqual(school.Id, 1);
            Assert.AreEqual(school.Name, "TheSchool");
            Assert.AreEqual(school.Rooms.Count, 1);
            Assert.AreEqual(school.Rooms[0], room);
            Assert.AreEqual(school.CreatedDate, createdDate);
        }

        [Test]
        public void CreatedDate_cannot_be_default_date_year_one_test()
        {
            School school = new School();
            Assert.AreNotEqual(DateTime.MinValue, school.CreatedDate);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatedDate_cannot_be_date_below_year_1753_test()
        {
            var year1752 = new DateTime(1752, 1, 1); 
            School school = new School() { CreatedDate = year1752};
        }

        [Test]
        public void CreatedDate_can_be_date_above_year_1753_test()
        {
            var year1753 = new DateTime(1753, 1, 1);
            School school = new School() { CreatedDate = year1753 };
            Assert.AreEqual(year1753, school.CreatedDate);
            var year10FromNow = DateTime.Now.AddYears(10);
            school.CreatedDate = year10FromNow;
            Assert.AreEqual(year10FromNow, school.CreatedDate);

        }

    }
}
