using System.Text;
using System.Xml;
using static System.Console;
namespace HoangXuanQuy_2021604440_proj62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            WriteLine("---Chương trình đọc file XML---");
            XmlDocument doc = new XmlDocument();
            doc.Load("Sanpham.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList li = root.SelectNodes("sanpham");
            int i = 1;
            foreach (XmlNode item in li)
            {
                WriteLine($"______Phần tử thứ {i}______");
                WriteLine("-Mã sản phẩm: " + item.SelectSingleNode("masp").InnerText);
                WriteLine("-Tên sản phẩm: " + item.SelectSingleNode("tensp").InnerText);
                WriteLine("-Số lượng: " + item.SelectSingleNode("soluong").InnerText);
                WriteLine("-------------------------");
                i++;
            }
        }
    }
}