using System.Text;
using System.Xml;
using static System.Console;
namespace HoangXuanQuy_2021604440_proj63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            WriteLine("=====Hiển thị file xml ra màn hình=====");
            XmlDocument doc = new XmlDocument();
            doc.Load("Congty.xml");
            XmlElement root = doc.DocumentElement;
            printNode(root);
        }
        static void printNode(XmlNode node)
        {
            //Console.Write(node.Name);
            
            Console.Write("{0, -5}",node.Value);
            
            XmlNodeList child = node.ChildNodes;
            foreach (XmlNode childNode in child)
            {
                printNode(childNode);
            }
            if (node.Name == "nhanvien") WriteLine();
        }
    }
}