using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesApp
{
    internal class carr
    {
        // member variable
        //private string _model = "";
        private string _brand = "";

        // Property
        public string Model { get; set; }

        // Lambda expressions
        //public string Model1 { get => _model; set => _model = value; }
        public string Brand {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }

            set {
                if (string.IsNullOrEmpty(value)) 
                { 
                    Console.WriteLine("You enered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                { 
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get; set; }



        // constructor
        public carr(string model, string brand, bool isLuxury) 
        { 
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {brand} of the model {model} has been created");
            IsLuxury = isLuxury;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm in a {Model} and I'm Driving");
        }
    }
}
