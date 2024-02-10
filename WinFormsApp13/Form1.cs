namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        Lista elenco = new Lista("pippo");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valore = textBox1.Text;
            elenco.Push(valore);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Nodo x = elenco.Inizio;
            listBox1.Items.Add(x.Valore);
            while (x.Successivo != null)
            {
                x = x.Successivo;
                listBox1.Items.Add(x.Valore);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            elenco.serializza();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            elenco = Lista.Deserializza();
        }
    }
}