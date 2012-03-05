using System.Xml.Serialization;

namespace FlumeAgent.Config
{
    public class Collector
    {
        [XmlArray("ThriftNodes")]
        [XmlArrayItem("Node")]
        public FlumeNodeConfig[] ThriftNodes { get; set; }

        /// <summary>
        /// ��־�ռ���
        /// </summary>
        [XmlAttribute("Name")]
        public string Name;


    }
}