using System;

namespace DeleteDic
{
    class DeleteDirect
    {
        public string Wordname;
        public string SearchDirect(Wordname)
        {
            Console.WriteLine("Nhập vào đây từ bạn muốn xóa: ");
            // Highest priority: viết method xóa từ
            // B1: Dùng vòng lặp for/câu điều kiện if else để tìm xem từ đó có tồn tại trong list hay không
            // B2: Nếu tìm được từ thì hỏi ng dùng có muốn xóa hay không (Y/N) (sử dụng switch case hoặc if else)
            Wordname = Console.ReadLine();
        }
    }
}