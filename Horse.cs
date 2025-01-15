using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesApp
{
    internal class Horse
    {
        // Member variables
        private string _color = "";
        private string _origin = "";
        private bool _isOld;

        // Properties
        public string Color { get => _color; set => _color = value; }

        public string Origin
        {
            get
            {
                if (IsOld)
                {
                    return _origin + " - Old Breed";
                }
                else
                {
                    return _origin;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _origin = "UNKNOWN";
                }
                else
                {
                    _origin = value;
                }
            }
        }

        public bool IsOld { get => _isOld; set => _isOld = value; }

        // Constructor
        public Horse(string color, string origin, bool isOld)
        {
            Color = color;
            Origin = origin;
            IsOld = isOld;
            Console.WriteLine($"You have a {color} horse from {origin}. {(isOld ? "It is an old breed." : "It is not an old breed.")}");
        }
    }
}
