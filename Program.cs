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

		// Stack<string> hoso_canxuly = new Stack<string> ();

		//   hoso_canxuly.Push ("Hồ sơ A"); 
		//   hoso_canxuly.Push ("Hồ sơ B"); 
		//   hoso_canxuly.Push ("Hồ sơ C");

		//   while (hoso_canxuly.Count > 0) {
		//     var hs = hoso_canxuly.Pop();
		//     Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
		//   }


		// LinkedList<string> cacbaihoc = new LinkedList<string>();
		// var bh1 = cacbaihoc.AddFirst("Bài học 1");
		// var bh3 = cacbaihoc.AddLast("Bài học 3");
		// LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "Bài học 2");
		// cacbaihoc.AddLast("Bài học 4");
		// cacbaihoc.AddLast("Bài học 5");

		// var node = bh2;
		// Console.WriteLine(node.Value);
		// node = node.Next;
		// Console.WriteLine(node.Value);
		// node = node.Next;
		// Console.WriteLine(node.Value);

		// Dictionary<string, int> sodem = new Dictionary<string, int>()
		// {
		// 	["one"] = 1,
		// 	["tow"] = 2,
		// };
		// // Thêm hoặc cập nhật
		// sodem["three"] = 3;
		// sodem.Add("four", 4);

		// var keys = sodem.Keys;
		// foreach (var k in keys)
		// {
		// 	var value = sodem[k];
		// 	Console.WriteLine($"{k} = {value}");
		// }

		HashSet<int> hashset1 = new HashSet<int>() {5,2,3,4};
		Console.WriteLine($"Phần tử trong hashset1 {hashset1.Count}");
		foreach (var v in hashset1)
		{
			Console.Write(v + " ");
		}
		Console.WriteLine();

		HashSet<int> hashset2 = new HashSet<int>();
		hashset2.Add(3);
		hashset2.Add(4);
		if (hashset1.IsSupersetOf(hashset2))
			Console.WriteLine($"hashset1 là tập chứa hashset2");
	}
}