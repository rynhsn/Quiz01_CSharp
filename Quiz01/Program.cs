//Summary();
//StringLength();
//Reverse();
//Max();
//Dividers();
//SecretStrings();
//Saturday();
//SameString();
//SecondGreatest();
//Console.WriteLine(CheckKurawal("{{{}}"));
//TriangleDisplay();
decimal a = 9.2M;
Console.WriteLine(a);

static void Summary()
{
    Console.Write("Enter number integer : ");
    char[] num = Console.ReadLine().ToCharArray();
    int result = 0;
    foreach (var n in num)
    {
        result += int.Parse(n.ToString());
    }
    Console.WriteLine($"Total Sum : {result}");
    Console.WriteLine();
}

static void StringLength()
{
    Console.Write("Enter number integer : ");
    char[] num = Console.ReadLine().ToCharArray();
    int result = 0;
    foreach (var n in num)
    {
        result++;
    }
    Console.WriteLine($"Count : {result}");
    Console.WriteLine();
}

static void Reverse()
{
    Console.Write("Enter number integer : ");
    char[] num = Console.ReadLine().ToCharArray();
    for(var i = num.Length - 1; i >= 0; i--)
    {
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}

static void Max()
{
    List<int> num = new();
    bool cond = true;
    while (cond) {
        Console.Write("Enter integer [Type 0 for exit] : ");
        var input = int.Parse(Console.ReadLine());
        if (input > 0) num.Add(input); else cond = false;
    }
    Console.WriteLine($"Angka terbesar : {num.Max()}");
}

static void Dividers()
{
    Console.Write("Enter numbers : ");
    var num = int.Parse(Console.ReadLine());
    for(var i = 1; i < num; i++)
    {
        Console.Write(num % i == 0 ? $"{i} ":"");
    }
}

static void SecretStrings()
{
    Console.Write("Enter strings : ");
    var str = Console.ReadLine();
    var substr = str.Split();
    var result = new List<string>();

    foreach(var s in substr)
    {
        for (var i = 0; i < s.Length; i++)
        {
            var res = i > 0 && i < s.Length-1 ? "*" : s[i].ToString();
            result.Add(res);
        }
        result.Add(" ");
    }

    foreach(var r in result)
    {
        Console.Write(r);
    }
}

static void Saturday() {
    DateTime today = DateTime.Today;
    int daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)today.DayOfWeek + 7) % 7;
    DateTime nextSaturday = today.AddDays(daysUntilSaturday);

    Console.WriteLine($"Hari Sabtu : {nextSaturday.ToShortDateString()}");
    Console.WriteLine($"{daysUntilSaturday} hari lagi!");
}

static void SameString()
{
    Console.Write("Enter strings : ");
    string str = Console.ReadLine();
    Console.Write("Find String : ");
    string substr = Console.ReadLine();
    int count = (str.Length - str.Replace(substr, "").Length) / substr.Length;
    Console.WriteLine($"Total kata yang muncul : {count} kali dari text {str}");
}

static void SecondGreatest()
{
    List<int> num = new();
    for(var i = 1; i <= 5; i++)
    {
        Console.Write($"Enter {i}. number: ");
        num.Add(int.Parse(Console.ReadLine()));
    }
    var result = num.OrderByDescending(x => x).ElementAt(1);
    Console.WriteLine($"Second Greatest : {result}");
}

static bool CheckKurawal(string str)
{
    bool result, step = true;
    int counter = 0;
    foreach (char c in str)
    {
        if (c == '{' && step == true)
        {
            counter++;
        } else if (c == '}') {
            counter--;
            step = false;
        }
    }
    result = counter == 0;
    return result;
}

static void TriangleDisplay()
{
    for(var i = 5; i < 10; i++)
    {
        //Console.WriteLine(i);
        for (var j = 10; j > 5; j--)
        {
            if (j > i) Console.Write($"{j} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();

    for(var i = 1; i <= 5; i++)
    {
        for (var j = 0; j < 5; j++)
        {
            if (j < i) Console.Write($"{i + j} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();

    for (int i = 1; i <= 7; i++)
    {
        if (i <= 4)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = 1; j <= 8 - i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();

    for (int i = 1; i <= 5; i++)
    {
        for (int j = 1; j <= 5 - i; j++)
        {
            Console.Write("  ");
        }
        for (int j = i; j <= 2 * i - 1; j++)
        {
            Console.Write($"{j} ");
        }
        for (int j = 2 * i - 2; j >= i; j--)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();
}
