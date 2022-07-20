using System.IO;
using System.Linq;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void Sbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
       
            string path = @"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt";
            StreamReader read = new StreamReader(path);
            string fileData = read.ReadToEnd();
            DataBox.Text = fileData;
       

            if ((Sbox.Text.Contains(DataBox.Text)) && (DateSet.Text.Contains(DataBox.Text)))
            {
                string GetLine(string fileName, int line)
                {

                    {
                        for (int i = 1; i < line; i++)
                            read.ReadLine();
                        return read.ReadLine();
                    }
                }


                //Sbox.Text.Contains(fileData);
                //DateSet.Text.Contains(fileData);
                //richTextBox1.Show();
                //read.ReadLine();
                ////richTextBox1.Text = fileData;
                ////richTextBox1.AppendText(read.ReadLine());
                //Console.WriteLine(richTextBox1 + "Here are the list:");
                //if (true)
                //{

                //    string GetLine(string fileName, int line)
                //    {

                //        {
                //            for (int i = 1; i < line; i++)
                //                read.ReadLine();
                //            return read.ReadLine();
                //        }
                //    }
                //}

            }
            read.Close();
        }  
               



        private void Clrbtn_Click(object sender, EventArgs e)
        {
            DataBox.Clear();
            Sbox.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateSet_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
        
 // Console.WriteLine(richTextBox1);
                //Console.WriteLine( Sbox.Text = fileData.ToString());
                //Console.WriteLine(DateSet.Text = fileData.ToString());

                //for (int i = 1; i < ; i++)
                //    read.ReadLine();
                //return read.ReadLine();
                //richTextBox1.AppendText(read.ReadLine());
                //Console.WriteLine(richTextBox1 + "Here are the list:");
                //read.ReadLine();
                //Console.ReadLine();
                //path.CompareTo(Sbox.Text);
                //richTextBox1.Show();

                //richTextBox1.Find(Sbox.Text, start, path.Length, RichTextBoxFinds.MatchCase);


                //Console.WriteLine(richTextBox1 + "Here are the list:");


        //richTextBox1.AppendText(fileData);

        //while (start < end)
        //{
        //    richTextBox1.Find(path, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
        //    start = richTextBox1.Text.LastIndexOf(Sbox.Text, start);
        //}





        //                    StreamReader read = new StreamReader(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt", true);

        //                    string info = read.ReadLine();
        //                    int findingInfo = richTextBox1.Find(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt");
        //                    Sbox.Text = findingInfo.ToString();

        //                    if (Sbox.Text.CompareTo(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt")== 0)

        //                       {
        //                        richTextBox1.AppendText(read.ReadLine());
        //                         Console.WriteLine(  richTextBox1 + "Here are the list:");
        //                        read.ReadLine();



        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Info error");

        //                    }
        //#pragma warning restore CS8602 // Dereference of a possibly null reference.
        //                    read.Close();    

            //int start = 0;
            //int end = richTextBox1.Text.LastIndexOf(Sbox.Text);
            //richTextBox1.SelectAll();
            //richTextBox1.SelectionBackColor = Color.White;  
            //while (start < end)
            //{
            //    richTextBox1.Find(Sbox.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
            //    richTextBox1.SelectionBackColor = Color.Yellow;
            //    start = richTextBox1.Text.IndexOf(Sbox.Text, start) + 1;
            //}





            //        string info = Reader.ReadLine();

            //        if (Sbox.Text.Contains(info))
            //        {

            //Console.WriteLine(richTextBox1); 
            //MessageBox.Show(info = Reader.ReadLine());
            //Console.WriteLine(richTextBox1);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Search not found");
            //        }
            //Reader.Close();

            //    }








            //if (Sbox.Text.Contains(info)) ;
            //{
            //    MessageBox.Show(info = Reader.ReadLine());
            //    Console.WriteLine(richTextBox1);
            //                    }
            //else
            //{
            //    MessageBox.Show("Search not Valid");
            //}

       





//File.ReadAllLines(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt");
//string[] Date = Sbox.Text.Split(' ');
//foreach (string date in Date)
//{
//    int startIndex = 0; 
//    while (startIndex < richTextBox1.TextLength)
//    {
//    int wordStartIndex = richTextBox1.Find(date, startIndex, RichTextBoxFinds.None);
//        if (wordStartIndex != -1)
//        {
//            richTextBox1.SelectionStart = wordStartIndex;   
//            richTextBox1.SelectionLength = Date.Length;
//            richTextBox1.SelectionBackColor = Color.Blue;
//        }
//        else
//        {
//            break;
//            startIndex += wordStartIndex + Date.Length;
//        }
//    }
//}

//string GetLine(string fileName, int line)
//{
//    using (var sr = new StreamReader(fileName))
//    {
//        for (int i = 1; i < line; i++)
//            sr.ReadLine();
//        return sr.ReadLine();
//    }
//    }
//string infotoSearch = Sbox.Text;
//string Search = Console.ReadLine();
//bool condition = false;
//for (int i = 0; i < info.Length; i++)
//{
//    if (info[i].Contains(Sbox.Text)== true)
//    {
//        condition = true;
//        break;
//    }
//    else
//    {
//        condition = false;
//    }
//}
//if (condition == true)
//{
//    MessageBox.Show("{0} Found in Data", infotoSearch);
//}
//else
//{
//    MessageBox.Show("{0} Not Found in Data", infotoSearch);
//}
//}




