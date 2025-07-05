public class NhanVien
{
    public string HoTen { get; set; }
    public string GioiTinh { get; set; }
    public double HeSoLuong { get; set; }
    public int SoCon { get; set; }
    public double TroCap { get; private set; }
    public double ThucLinh { get; private set; }

    public NhanVien(string hoTen, string gioiTinh, double heSoLuong, int soCon)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        HeSoLuong = heSoLuong;
        SoCon = soCon;
        TinhTroCap();
        TinhThucLinh();
    }

    private void TinhTroCap()
    {
        if (SoCon == 0) TroCap = 0;
        else if (SoCon == 1) TroCap = 500000;
        else TroCap = 1000000;
    }

    private void TinhThucLinh()
    {
        ThucLinh = HeSoLuong * 1500000 + TroCap;
    }
}
