class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
    //    Queue<string> hoso_canxuly = new Queue<string>();
    //     hoso_canxuly.Enqueue("Ho so 1");
    //     hoso_canxuly.Enqueue("Ho so 2");
    //     hoso_canxuly.Enqueue("Ho so 3");

    //     while (hoso_canxuly.Count > 0)
    //     {
    //         var hoso = hoso_canxuly.Dequeue();
    //         Console.WriteLine($"Dang xu ly ho so {hoso}, con lai {hoso_canxuly.Count} ho so trong hang cho xu ly.");
    //     }

    Stack<string> hoso_canxuly = new Stack<string> ();

      hoso_canxuly.Push ("Hồ sơ A"); 
      hoso_canxuly.Push ("Hồ sơ B"); 
      hoso_canxuly.Push ("Hồ sơ C");

      while (hoso_canxuly.Count > 0) {
        var hs = hoso_canxuly.Pop();
        Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
      }
    }
}

