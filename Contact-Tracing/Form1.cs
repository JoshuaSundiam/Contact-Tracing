namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter folder = new StreamWriter(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt", true);

            folder.WriteLine("Name:" + tbox1.Text);
            folder.WriteLine("Contact No.:" + tbox2.Text);
            folder.WriteLine("Address:" + tbox3.Text);
            folder.Close();

            

        }
    }
}