using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Constructors
{
    internal class Gym
    {
        //Fields
        List<string> _equipment;
        List<string> _facilities;
        string _name;
        string _location;
        double _fee;
        int _opening;
        int _closing;
        bool _isOpen;


        //Default constructor is a constructor that takes no arguement. 

        //Overload constructor is a constructor that has parameters required to create a new instance of the object
        public Gym(double fee, int opening, int closing)
        {
            _fee = fee;
            _opening = opening;
            _closing = closing;
        }




        //this overrides the ToString() in this particular class, but not the entire namespace.
        public override string ToString()
        {
            return $"{_name} : Location - {_location} : {_opening}:00 - {_closing}:00 : Fee - {_fee}";
        }


    }
}
