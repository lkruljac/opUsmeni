using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Threading;


using IronPython.Hosting; //Pristup IronPython interpretreru
using IronPython.Runtime; //Pristup IronPython tipovima podataka
using Microsoft.Scripting; //DLR podrška
using Microsoft.Scripting.Hosting; //DLR podrška


namespace SorterSetup
{
    public partial class Form2 : Form
    {
      
        private Thread _t;
        private ManualResetEvent _eventStop = new ManualResetEvent(false);
        Form1 form1;
        public Form2(Form1 form1local)
        {
            form1 = form1local;
            InitializeComponent();
            for (int i = 0; i < form1.myEnvParm.conteinerNumber; i++)
            {
                this.flowLayoutPanel1.Controls.Add(new Container(i+1));
            }
            _t = new System.Threading.Thread(new ThreadStart(DoSomething));
            _t.Start();
            


        }

        private void CreateLikFile(int a)
        {
            if (InvokeRequired)
            {
                this.flowLayoutPanel1.Invoke(new Action<int>(CreateLikFile), new object[] { a });
                return;
            }
            //writing shapes in .lik file
            String exePath = Directory.GetCurrentDirectory();
            String imagePath = Path.GetFullPath(Path.Combine(exePath, @"../../../Images").ToString());
            for (int containerC = 0; containerC < form1.myEnvParm.conteinerNumber; containerC++)
            {
                imagePath = Path.GetFullPath(Path.Combine(exePath, @"../../../Images").ToString());
                String fileName = DateTime.Now.ToFileTimeUtc().ToString() + "_image" + containerC + ".lik";
                imagePath = Path.Combine(imagePath, fileName);
                using (StreamWriter outputFile = new StreamWriter(imagePath))
                {
                    string line = "";
                    Container container = (Container) this.flowLayoutPanel1.Controls[containerC];
                    for (int j=0; j < container.dataGridView1.Rows.Count-1; j++)
                    {
                        line = "";
                        DataGridViewRow row = (DataGridViewRow)container.dataGridView1.Rows[j];
                        line = line + row.Cells[1].Value.ToString();
                        line = line + " ";
                        line = line + row.Cells[2].Value.ToString();
                        line = line + " " + (j * 20 + 15) + " " + (j * 20 + 15);
                        outputFile.WriteLine(line);
                    }
                }
            }
        }

        private void DoSomething()
        {
            loop();
            CreateLikFile(2);

            //select file to draw
            //TODO
            //Iron Python drawing image

            //String path = @"C:\Users\Luka\Desktop\DA - 2 semestar\Nyarko, Filko - Projekt\SorterSetup\Images\132035408976953460_image5.lik";
            //ScriptEngine pyEngine = null;
            //ScriptScope pyScope = null;
            //ScriptSource scriptSourceObj;

            //var options = new Dictionary<string, object>();
            //options["Frames"] = true;
            //options["FullFrames"] = true;
            //pyEngine = Python.CreateEngine(options);
            //var paths = pyEngine.GetSearchPaths();
            //paths.Add(@"C:\Python27\Lib");
            //paths.Add(@"C:\Python27\Lib\lib-tk");

            //paths.Add(@"C:\Users\Luka\Desktop\DA - 2 semestar\Nyarko, Filko - Projekt\SorterSetup\PythonApplication1");

            //pyEngine.SetSearchPaths(paths);
            //pyScope = pyEngine.CreateScope();
            //String exePath = Directory.GetCurrentDirectory();
            //String pythonScriptPath = Path.GetFullPath(Path.Combine(exePath, @"../../../PythonApplication1/ApplicationModule.py").ToString());
            //scriptSourceObj = pyEngine.CreateScriptSourceFromFile(pythonScriptPath);
            //scriptSourceObj.Execute(pyScope);
            //dynamic openLikFile = pyScope.GetVariable("FunOpen");
            //openLikFile(path);


            _eventStop.Set();
            //this.Close();
            //form1.Show();

        }

        private void loop()
        {
            string line="";
            int simulationCounter =  0;
            while (!_eventStop.WaitOne(1, false))
            {

                
                // FROM ARDUINO - UART
                 
                line = form1.myPort.ReadLine();
                
                 

                //RAND WITH PYTON
                //ScriptEngine pyEngine = null;
                //ScriptScope pyScope = null;
                //ScriptSource scriptSourceObj;
                //var options = new Dictionary<string, object>();
                //options["Frames"] = true;
                //options["FullFrames"] = true;
                ////paths.Add(@"C:\Python27\Lib"); // or you can add the CPython libs instead
                //pyEngine = Python.CreateEngine(options);
                //var paths = pyEngine.GetSearchPaths();
                //paths.Add(@"C:\Python27\Lib");
                //pyEngine.SetSearchPaths(paths);
                //pyScope = pyEngine.CreateScope();
                //String exePath = Directory.GetCurrentDirectory();
                //String pythonScriptPath = Path.GetFullPath(Path.Combine(exePath, @"../../../RandWithPython/RandWithPython.py").ToString());
                //scriptSourceObj = pyEngine.CreateScriptSourceFromFile(pythonScriptPath);
                //scriptSourceObj.Execute(pyScope);
                //dynamic openLikFile = pyScope.GetVariable("GetObject");
                //line = openLikFile();

                //if (simulationCounter == 10)
                //{
                //    line = "End\r";
                //}


                 
                AppendTextBox(line);
                if (line == "End\r")
                {
                    MessageBox.Show("All objects are sorted");
                    break;
                }
                if (line == "")
                {
                    continue;
                }
                MyObject myObj = ToMyObject(line);
                InsertInTabele(myObj);
                simulationCounter ++;
            }
        }
        
        public void InsertInTabele(MyObject myObj)
        {
            if (InvokeRequired)
            {
                this.flowLayoutPanel1.Invoke(new Action<MyObject>(InsertInTabele), new object[] { myObj });
                return;
            }
            Container container = (Container) this.flowLayoutPanel1.Controls[myObj.conteiner];
            DataGridViewRow row = (DataGridViewRow) container.dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = container.dataGridView1.RowCount;
            row.Cells[1].Value = myObj.shape;
            row.Cells[2].Value = myObj.color;
            row.Cells[3].Value = myObj.weight.ToString();
            row.Cells[4].Value = myObj.filter.ToString();
            container.dataGridView1.Rows.Add(row);
        }


        public void AppendTextBox(string line)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { line });
                return;
            }
            this.richTextBoxMonitor.Text = line;
        }

        private MyObject ToMyObject(string line)
        {
            MyObject myObj = new MyObject();
            string[] keyWords;
            keyWords = line.Split(';');
            myObj.color = keyWords[0];
            myObj.shape = keyWords[1];
            myObj.weight = float.Parse(keyWords[2]);
            myObj.filter = int.Parse(keyWords[3]);
            myObj.conteiner = int.Parse(keyWords[4]);
            return myObj;
        }

        private void break_Click(object sender, EventArgs e)
        {
            _eventStop.Set();
            this.Close();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
