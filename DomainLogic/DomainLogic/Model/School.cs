using System;
using System.Collections.Generic;
using DomainLogic.Model;

namespace DomainLogic.Model
{
    public class School
    {
        private DateTime _cratedDate;
        public School()
        {
            CreatedDate = DateTime.Now;
        }
        public DateTime CreatedDate {
            get
            {
                return _cratedDate;
            }
            set
            {
                if (value.Year < 1753)
                {
                    throw new ArgumentException("Datetime before year 1753 not allowed for datetime in MSSQL DB");
                }
                _cratedDate = value;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
    }
}