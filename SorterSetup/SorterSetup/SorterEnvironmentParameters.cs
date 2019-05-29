using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SorterSetup
{
    public class SorterEnvironmentParameters
    {
        public List<string> colors = new List<string>();
        public List<string> shapes = new List<string>();
        public int conteinerNumber;
        public decimal minWeight;
        public decimal maxWeight;



        public SorterEnvironmentParameters()
        {

        }


        //load from xml
        public void LoadParm(out SorterEnvironmentParameters mySEP)
        {
            mySEP = this;
            try
            {
                string envParPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resource\envParam.xml"));
                
                // Create an instance of the XmlSerializer.
                XmlSerializer serializer = new XmlSerializer(typeof(SorterEnvironmentParameters));
                SorterEnvironmentParameters i = new SorterEnvironmentParameters();
                using (Stream reader = new FileStream(envParPath, FileMode.Open))
                {
                    // Call the Deserialize method to restore the object's state.
                    i = (SorterEnvironmentParameters)serializer.Deserialize(reader);
                }
                mySEP = i;
            }

            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }


        //just for generating first xml
        public void makeXml()
        {
            SorterEnvironmentParameters p = new SorterEnvironmentParameters();
            p.colors.Add("Blue");
            p.colors.Add("Red");
            p.maxWeight = 999;
            p.minWeight = 1;
            p.shapes.Add("Cube");
            p.shapes.Add("Sphere");
            p.conteinerNumber = 6;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
            x.Serialize(Console.Out, p);
            Console.WriteLine(); 
        }
    

        //getters
        public List<string> getAllColors()
        {
            return this.colors;
        }

        public List<string> getAllShapes()
        {
            return this.shapes;
        }

        public decimal getMinWeight()
        {
            return this.minWeight;
        }

        public decimal getMaxWeight()
        {
            return this.maxWeight;
        }
            


    }

}
