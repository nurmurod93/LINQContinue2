//string sentence = "the quick brown fox jumps over the lazy dog";

//string[] words = sentence.Split(' ');

//var querySyntax = from word in words
//            group word.ToUpper() by word.Length into gr
//            orderby gr.Key
//            select new { Length = gr.Key, Words = gr };
//foreach(var obj in querySyntax)
//{
//    Console.WriteLine("Words of length: {0}", obj.Length);
//    foreach(var word in obj.Words)
//    {
//        Console.WriteLine(word);
//    }
//}

//var methodSyntax = words.GroupBy(w => w.ToUpper(), w => w.Length)
//                        .Select(g => new { Length = g.Key, Words = g })
//                        .OrderBy(o => o.Length);
//foreach(var obj in methodSyntax)
//{
//    Console.WriteLine("Words of length: {0}", obj.Length);
//    foreach(var word in obj.Words)
//    {
//        Console.WriteLine(word);
//    }
//}

//int[] raqamlar = { 32, 0, 1, 3, 7, 4, 5, -9, 2, 1, -4, -1, 10, 55};

//var surov = raqamlar.OrderBy(x => x).ToArray();
//Array.ForEach(surov, s => Console.WriteLine(s));
//Console.WriteLine();
//var surov2 = raqamlar.OrderByDescending(x => x).ToArray();
//Array.ForEach(surov2, s => Console.WriteLine(s));

//var query = from raqam in raqamlar
//            orderby raqam descending
//            select raqam;
//foreach(var item in query)
//    Console.WriteLine(item);

//var query2 = from raqam in raqamlar
//             orderby raqam descending
//             select raqam;
//foreach (var item in query2) 
//    Console.WriteLine(item);


string[] words = {"the", "quick", "brown", "fox", "jumps",  "over", "the", "lazy", "dog"};

var query = words.OrderBy(w => w.Length).ThenByDescending(w => w.Substring(0, 1));

foreach(var item in query)
{
    Console.WriteLine(item);
}

var query2 = from w in words
             orderby w.Length descending, w.Substring(0, 1)
             select w;
foreach(var item in query2)
{
    Console.WriteLine(item);
}