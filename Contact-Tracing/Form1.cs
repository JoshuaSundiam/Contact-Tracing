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

            folder.WriteLine("Name:" + tbox1);
            folder.WriteLine("Contact No.:" + tbox2);
            folder.WriteLine("Address:" + tbox3);
            

            

        }
    }
}