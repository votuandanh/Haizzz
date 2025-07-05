public class QuanLyNhanVien
{
    public List<NhanVien> DanhSachNhanVien = new List<NhanVien>();
    public int TongSoNhanVien => DanhSachNhanVien.Count;
    public int SoNhanVienNu => DanhSachNhanVien.Count(nv => nv.GioiTinh == "Nữ");
    public double TongThucLinh => DanhSachNhanVien.Sum(nv => nv.ThucLinh);
    public void ThemNhanVien(NhanVien nv)
    {
        DanhSachNhanVien.Add(nv);
    }
}
