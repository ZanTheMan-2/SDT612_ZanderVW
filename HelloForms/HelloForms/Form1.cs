namespace HelloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetingsBTN_Click(object sender, EventArgs e)
        {

            //main code
            String name = InputFieldBox.Text;
            MessageBox.Show("Hello " + name + "!");

        }
    }
}
