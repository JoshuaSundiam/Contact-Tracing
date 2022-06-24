namespace Contact_Tracing
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//        Assignment 4
//1. Continue coding "your" own contact tracing app.
//	- Add the ff features in the program:

//       a.List all records written in the file

//       b.Can filter record by date
//       b. Display all data of selected record
//	- Feel free to add more functionality
//	- Be creative, the realistic the better.
//	- Please don't submit downloaded program
//	- Your program should be uploaded to github before June 25
// 2. - Record a demo presenting your contact tracing viewer app (less than 3 min only)
//	- Send the demo directly to my messenger before June 25
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter folder = new StreamWriter(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt", true);

            folder.WriteLine("Date:" + Dbox.Text);
            folder.WriteLine("Name:" + tbox1.Text);
            folder.WriteLine("Contact No.:" + tbox2.Text);
            folder.WriteLine("Address:" + tbox3.Text);
            folder.Close();
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
          Form2 form = new Form2();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dbox.Clear();
            tbox1.Clear();
            tbox2.Clear();
            tbox3.Clear();
        }
    }
}