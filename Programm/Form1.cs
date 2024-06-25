using System.Windows.Forms;
namespace Programm
{
    public partial class Form1 : Form
    {
        private List<PictureBox> holes;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            holes = new() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
        }
        private void Form1_Load(object sender, EventArgs e) => timer1.Start();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox9.Location = holes[new Random().Next(holes.Count)].Location;
            pictureBox9.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            label1.Text = "Score: " + score.ToString();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            score++;
            label1.Text = "Score: " + score.ToString();
            pictureBox9.Visible = false;
        }
    }
}