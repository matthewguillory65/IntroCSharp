using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student curStudent = new Serialization.Student(this.textBox2.Text, (int)this.numericUpDown1.Value, this.textBox1.Text);
            DataSerialization<Student>.Serialize("Student", curStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student lastStudent = DataSerialization<Student>.Deserialize("Student");
            this.textBox2.Text = lastStudent.NAME;
            this.numericUpDown1.Value = lastStudent.AGE;
            this.textBox1.Text = lastStudent.ID;
        }
    }

    public class Student
    {
        private string mName;
        private int mAge;
        private string mID;
        public Student() { }
        public Student(string mName, int mAge, string mID)
        {
            NAME = mName;
            AGE = mAge;
            ID = mID;
        }
        
        public string NAME { get { return mName; } set { mName = value; } }
        public int AGE { get { return mAge; }  set { mAge = value; } }
        public string ID { get { return mID; } set { mID = value; } }
    }

    public static class DataSerialization<T>
    {
        /// <summary>
        /// We invoke this function when have the data when we want to serialize ready. The arguements we pass in to
        /// the function callm tell the application where to save the data which by default is the project
        /// directory two files deep in a folder called Savedfiles and inside that folder we will find a file
        /// with the name that matches the data stored inside the string passed into the function call.
        /// Once that file has been found we then take the data pass into the function and write it to said file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void Serialize(string fileName, T data)
        {
            //Creates a new XMLSerializer object with an arguement of the type of data passed in.
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //Creates a new TextWritter object and assigns it a StreamWritter object that takes in an
            //arguement of the file path.
            TextWriter writter = new StreamWriter(@"\\Savedfiles\" + fileName + ".xml");
            //Invoke the Serialize functions from the XMLSerializer and assigns it the TextWritter object created
            //and the data we are trying to write our data.
            serializer.Serialize(writter, data);
            //Closes the file we where using to write our data.
            writter.Close();
        }

        /// <summary>
        /// We invoke this function when we are trying to load some data back into our application that has already been saved.
        /// This function will break if you're trying to find a file that doesn't exist. We specify that the file we are looking
        /// for by the data stored in the string passed into the function call.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T Deserialize(string fileName)
        {
            //Creates a new Generic object we will use to hold the data we are trying to return
            T data;
            //Creates a new XmlSerializer objects with an arguement of the type of the generic object we are trying to create.
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //Creates a new TextReader object with a child object of the class with the arguement of a string that is the file
            //directory of the file we are trying to get the data from.
            TextReader reader = new StreamReader(@"\\SavedFiles\" + fileName + ".xml");
            //Invokes the Deserialize function from the XmlSerializer class and casts the return as the generic type and
            //passes in the TextReader object as an arguement into the function call.
            data = (T)serializer.Deserialize(reader);
            //Closes the TextReader object file
            reader.Close();
            //Returns our generic object
            return data;
        }
    }
}
