using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach_
{
    internal class Particle
    {
        public int Radius; 
        public float X; 
        public float Y; 
        public float Direction; 
        public float Speed;
        public float Life;
        public float SpeedX;
        public float SpeedY;
        public static Random rand = new Random();
        public Particle()
        {
            Direction = rand.Next(360);
            Speed = 1 + rand.Next(10);
            SpeedX = (float)(Math.Cos(Direction / 180 * Math.PI) * Speed);
            SpeedY = (float)(Math.Sin(Direction/180*Math.PI) * Speed);
            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }
        public virtual void Draw(Graphics g)
        {
             float k = Math.Min(1f,Life /100);
            int alpha =(int)(k * 255);
            
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);
            //
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }
    }
}
