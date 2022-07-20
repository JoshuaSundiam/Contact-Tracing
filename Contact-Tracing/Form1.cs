using System;
using System.Windows.Forms;
using System.IO;
using ZXing;
using ZXing.QrCode;
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
        private void Openform(object obj)
        {
          

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt";
            StreamWriter folder = new StreamWriter(path, true);

        Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            QrBox.Image = qrcode.Draw(datePicker1.Text + infobox1.Text + infobox2.Text + infobox3.Text, 50);

            folder.WriteLine("Date: " + datePicker1.Text);
            folder.WriteLine("Name: " + infobox1.Text);
            folder.WriteLine("Contact No.: " + infobox2.Text);
            folder.WriteLine("Address: " + infobox3.Text);
            folder.Write(qrcode);
            folder.Close();

          

           
            //  string path = @"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt";
            //  StreamWriter folder = new StreamWriter(path, true);
            //var writer = new BarcodeWriter();
            //  writer.Format = BarcodeFormat.QR_CODE;
            //  var text1 = datePicker1.Text;
            //  var text2 = infobox1.Text;
            //  var text3 = infobox2.Text;
            //  var text4 = infobox3.Text;
            //  var result = writer.Write(text1, text2, text3, text4);
            //  path = result;
            MessageBox.Show("Data Received");

            
            infobox1.Clear();
            infobox2.Clear();
           infobox3.Clear();
           
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //StreamReader folder = new StreamReader(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt", true);



            //    string date = datePicker1.Text;
            //    string name = infobox1.Text;
            //    string cn = infobox2.Text;
            //    string address = infobox3.Text;
            //    StreamReader folder = new StreamReader(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt", true);
            //string path = @"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt";
            //    StreamReader read = new StreamReader(path);
            //    string fileData = read.ReadToEnd();

            //    if ((date.Contains(path)) && (name.Contains(path)) && (cn.Contains(path)) && (address.Contains(path)) )
            //    {
            //        read.ReadLine();
            //        string line1 = date.Substring(0, date.IndexOf(path));   
            //        string line2 = name.Substring(name.IndexOf(path) + 1);
            //        string line3 = cn.Substring(cn.IndexOf(path) + 1);
            //        string line4 = address.Substring(address.IndexOf(path) + 1);
            //        line1 = line2;
            //        line2 = line3;
            //        line3 = line4;
            //MessageBox.Show(line1);
            //    string[] v = path.Split('.');
            //    MessageBox.Show();
            //}





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
           
            infobox1.Clear();
            infobox2.Clear();
            infobox3.Clear();
            QrBox.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
          
        }
    }
}