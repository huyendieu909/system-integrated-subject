using Newtonsoft.Json;
using System.Text;
using static System.Console;
namespace HoangXuanQuy_2021604440_proj61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            WriteLine("===Thực hiện ghi và đọc file json===");
            SerializeListAnObject();
            DeserializeListAnObject();
        }
        static string SerializeListAnObject()
        {
            List<NhanVien> nv = new List<NhanVien>();
            nv.Add(new NhanVien("nv01", "Dương Hải Hậu", "nam", "Hà Nội", "Nhân viên"));
            nv.Add(new NhanVien("nv02", "Bùi Công Lý", "nam", "Ninh Bình", "CEO"));
            nv.Add(new NhanVien("nv03", "Nguyễn Diệu Huyền", "nữ", "Hải Dương", "CFO"));
            File.WriteAllText("nhanvien.json", JsonConvert.SerializeObject(nv));
            return JsonConvert.SerializeObject(nv, Formatting.Indented);
        }
        static void DeserializeListAnObject()
        {
            List<NhanVien> nv2 = new List<NhanVien>();
            nv2 = JsonConvert.DeserializeObject<List<NhanVien>>(File.ReadAllText("nhanvien.json"));
            foreach (NhanVien i in nv2)
            {  
                Console.WriteLine(i.ToString());
            }
        }
    }
}