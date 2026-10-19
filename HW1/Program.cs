public class CaNhan
{
    private string hoTen;
    private string maSV;
    private string lop;
    private string username;
    private string email;

    public CaNhan(string hoTen, string maSV, string lop, string username, string email)
    {
        this.hoTen = hoTen;
        this.maSV = maSV;
        this.lop = lop;
        this.username = username;
        this.email = email;
    }

    public string GetHoTen() { return this.hoTen; }
    public void SetHoTen(string hoTen) { this.hoTen = hoTen; }

    public string GetMaSV() { return this.maSV; }
    public void SetMaSV(string maSV) { this.maSV = maSV; }

    public string GetLop() { return this.lop; }
    public void SetLop(string lop) { this.lop = lop; }

    public string GetUsername() { return this.username; }
    public void SetUsername(string username) { this.username = username; }

    public string GetEmail() { return this.email; }
    public void SetEmail(string email) { this.email = email; }
}

internal class Program
{
    
    private static void Main(string[] args)
    {
        CaNhan QuangTrung = new CaNhan("Lê Quang Trung", "10125306", "12525W.1", "quangtrung-dev", "akacua2202@gmail.com");

        Console.WriteLine("Họ tên: " + QuangTrung.GetHoTen());
        Console.WriteLine("Mã SV: " + QuangTrung.GetMaSV());
        Console.WriteLine("Lớp: " + QuangTrung.GetLop());
        Console.WriteLine("Username: " + QuangTrung.GetUsername());
        Console.WriteLine("Email: " + QuangTrung.GetEmail());

        Console.ReadKey();
    }
}