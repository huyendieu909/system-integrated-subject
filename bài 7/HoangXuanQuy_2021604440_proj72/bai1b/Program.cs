using static System.Console;
using System.IO;
using System.Text;
using Newtonsoft.Json;
namespace bai1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            OutputEncoding = Encoding.Unicode;
            WriteLine("Thực hiện đọc ghi file json nhanvien.json");
            SerializeAListOfObject();
            DeserializeAlistOfObject();
        }
        static string SerializeAListOfObject()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            nhanViens.Add(new NhanVien("nv01", "Dương Huy Khôi", 32343, 1000, 33343, "Minh Khai", "Bắc Từ Liêm", "Hà Nội"));
            nhanViens.Add(new NhanVien("nv02", "Trần Huy Lực", 10000, 1000, 11000, "Minh Khai", "Bắc Từ Liêm", "Hà Nội"));
            nhanViens.Add(new NhanVien("nv03", "Văn Thế Tài", 98090, 1000, 99090, "Minh Khai", "Bắc Từ Liêm", "Hà Nội"));
            File.WriteAllText("nhanvien.json", JsonConvert.SerializeObject(nhanViens));
            return JsonConvert.SerializeObject(nhanViens, Formatting.Indented);
        }
        static void DeserializeAlistOfObject()
        {
            List<NhanVien> nv = JsonConvert.DeserializeObject<List<NhanVien>>(File.ReadAllText("nhanvien.json"));
            foreach (var s in nv)
            {
                WriteLine(s.ToString());   
            }
        }
        class NhanVien
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public double Luong { get; set; }
            public double Thuong { get; set; }
            public double TongLuong { get; set; }
            public string Xa { get; set; }
            public string Huyen { get; set; }
            public string Tinh { get; set; }
            public string DiaChi
            {
                get
                {
                    return Xa + ", " + Huyen + ", " + Tinh;
                }
            }
            public NhanVien(string maNV, string hoTen, double luong, double thuong, double tongLuong, string xa, string huyen, string tinh)
            {
                MaNV = maNV;
                HoTen = hoTen;
                Luong = luong;
                Thuong = thuong;
                TongLuong = tongLuong;
                Xa = xa;
                Huyen = huyen;
                Tinh = tinh;
            }
            public override string ToString()
            {
                return string.Format($"{MaNV,4}, {HoTen,30}, {Luong,15}, {Thuong,15}, {TongLuong,15}, {DiaChi,-100}");
            }
        }
    }
}
