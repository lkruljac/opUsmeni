using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace SorterSetup
{
    public class FilterData
    {
        public List<string> colors = new List<string>();
        public List<string> shapes = new List<string>();
        public int conteinerNumber;
        public decimal minWeight;
        public decimal maxWeight;

        public FilterData()
        {

        }

        public void Fill(Filter filter)
        {
            this.colors = filter.getColors();
            this.shapes = filter.getShapes();
            this.minWeight = filter.getMin();
            this.maxWeight = filter.getMax();
            this.conteinerNumber = (int) filter.getContainer();
        }

        public string ToXml()
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(textWriter, this);
                return textWriter.ToString();
            }
        }

    }
}
