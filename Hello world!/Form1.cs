namespace Hello_world_
{
    public partial class Form1 : Form
    {
        public object HelloWorld { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello Johannes!";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nice Try";
        }
    }
}