using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Constructors
{
    internal class Bullet
    {
        string _name;
        float _x;
        float _y;
        float _velocity;
        float _rotation;
        string _visual;
        float _damage;
        float _radius;

        public Bullet(string name, float x, float y, float velocity)
        {
            _name = name;
            _x = x;
            _y = y;
            _velocity = velocity;

        }
        public void UpdateLocation()
        {
            _x += _velocity;
            _y += _velocity;
        }

        public override string ToString()
        {
            return $"Bullet {_name} X: {_x} Y: {_y} Velocity: {_velocity}";
        }
    }
}
