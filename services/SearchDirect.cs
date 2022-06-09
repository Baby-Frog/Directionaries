using System;

namespace DeleteDic
{
    class SearchDirect
    {
        public string Wordname;
        public string SearchDirect(Wordname)
        {
            Console.WriteLine("Nhập vào đây từ bạn muốn tìm: ");
            // Highest priority: viết method tìm từ
            // B1: Dùng vòng lặp for/câu điều kiện if else để tìm xem từ đó có tồn tại trong list hay không
            // B2: Nếu tìm được từ thì hiển thị ý nghĩa của từ  (sử dụng Console.WriteLine)
            Wordname = Console.ReadLine();
        }
    }
}