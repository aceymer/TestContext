using System;

namespace DomainLogic.Model
{
    public class Room
    {
        private string _name;

        public Room() {
            Name = "";
        }

        public int Capacity { get; set; }
        public int Id { get; set; }
        public string Name {
            get { return _name; }
            set {
                if (value == null) {
                    throw new ArgumentException("Name cannot be null");
                }
                _name = value;
            }
        }
    }
}