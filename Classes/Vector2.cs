using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Vector2
    {
        float x,y;
        public Vector2()
        {
            this.x = 0f;
            this.y = 0f;
        }
        public Vector2(float x,float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetDistanceTo(Vector2 other) 
        {
            return (float)Math.Abs(Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2)));
        }
    }
}
