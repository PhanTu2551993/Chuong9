using System;
using Play = Sony.Players.DvdPlayer;
//using Play = Sony.Player; // Sửa lại alias cho đúng namespace

namespace Sony
{
    //C2: Thêm sửa Player thành Players để giống với namespace đã được gọi 
    namespace Players
    {
        class CdPlayer
        {
            public CdPlayer()
            {
                Console.WriteLine("CD-R as well as CD-RW are available");
            }
        }

        //class DvdPlayer()
        class DvdPlayer // Loại bỏ dấu ngoặc đơn () trong khai báo lớp
        {
            public DvdPlayer()
            {
                Console.WriteLine("DVD-R as well as DVD-RW are available");
            }
        }
    }
}

namespace Samsung
{
    class Player
    {
        static void Main(string[] args)
        {
            //Play.DvdPlayer objPlayer = new Players.DvdPlayer();
                Play objPlayer = new Play();  // Sử dụng alias Play để khởi tạo DvdPlayer
            //Play.DvdPlayer objPlayer = new Play.DvdPlayer(); // Sử dụng đúng alias và từ khóa new
        }
    }
}
