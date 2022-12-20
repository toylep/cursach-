using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach_
{
    internal class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public int MousePositionX;
        public int MousePositionY;
        public float GravitationX = 0;
        public float GravitationY = 1;

        public void UpdateState()
        {

            foreach (var particle in particles)
            {

                particle.Life -= 1;
                if (particle.Life < 0)
                {
                    var direction = (double)Particle.rand.Next(360);
                    var speed = 1 + Particle.rand.Next(10);
                    particle.Life = 20 + Particle.rand.Next(100);
                    particle.Radius = 2 + Particle.rand.Next(10);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                }
                else
                {
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                   
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                    
                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                    
                }

            }
            for (var i = 0; i < 100; i++)
            {
                if (particles.Count < 500)
                {
                    var particle = new Particle();
                }
            }
        }
        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

    }
}
