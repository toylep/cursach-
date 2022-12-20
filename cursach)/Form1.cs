namespace cursach_
{
    public partial class Form1 : Form
    {List<Particle> particles = new List<Particle>();
      Emitter emitter= new Emitter();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for(int i = 0; i < 500; i++)
            {
                var particle = new ParticleColor();
                // particle.X=pictureBox1.Image.Width/2;
                // particle.Y=pictureBox1.Image.Height/2;
                particle.Fromcolor = Color.Green;
                particle.Tocolor = Color.FromArgb(0, Color.Magenta);
                particles.Add(particle);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            emitter.UpdateState();
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {    g.Clear(Color.White);
                emitter.Render(g);

            }
            pictureBox1.Invalidate();

        }
       
        private int MousePositionX = 0;
        private int MousePositionY = 0;
       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionX= e.X;
            MousePositionY= e.Y;
        }
    }
}