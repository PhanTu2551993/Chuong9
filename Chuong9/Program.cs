namespace Sony
{
    class Laptops
    {
        public Laptops()
        {
            Console.WriteLine("Manufactures Laptops of different configuarations");
        }

        // Lỗi class Player phải để ở public vì constructure của class Player đang để ở public
        //class Player

        //Lớp Player trong namespace Sony được định nghĩa nhưng không được sử dụng trong mã, điều này không gây ra lỗi khi chạy
        //nhưng có thể là phần dư thừa trong đoạn code này hoặc xảy ra lỗi khi muốn sử dụng đến Player

        //Sửa lỗi
        public class Player
        {
            public Player()
            {
                Console.WriteLine("CD as well as DVD players are manufactures");
            }
        }
    }
}
namespace Dell
{
    class Laptops
    {
        static void Main(string[] args)
        {
            Sony.Laptops objSonyLaptop = new Sony.Laptops();
        }
    }
}