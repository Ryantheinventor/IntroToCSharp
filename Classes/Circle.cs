using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Circle
    {
        Vector2 position;
        float radius;

        public Circle()
        {
            this.position = new Vector2();
            this.radius = 1f;
        }

        public Circle(Vector2 position, float radius) 
        {
            this.position = position;
            this.radius = radius;
        }

        public bool ContainsPoint(Vector2 point) 
        {
            return radius >= position.GetDistanceTo(point);
        }

        public bool CheckOverlap(Circle other) 
        {
            return radius + other.radius > position.GetDistanceTo(other.position);
        }

    }
}
