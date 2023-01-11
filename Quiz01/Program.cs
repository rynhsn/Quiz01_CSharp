
//=============================MAIN PROGRAM==============================
Menu:
Console.WriteLine("+-------------------------------------------+");
Console.WriteLine("     Kuis 01 C# Code.id | .Net Bootcamp      ");
Console.WriteLine("+-------------------------------------------+");
Console.WriteLine("[1] Summary number");                              
Console.WriteLine("[2] Length of number");
Console.WriteLine("[3] Reverse numbers ");
Console.WriteLine("[4] Max number");
Console.WriteLine("[5] The dividers");
Console.WriteLine("[6] Prime number");
Console.WriteLine("[7] Secret strings");
Console.WriteLine("[8] When is saturday");
Console.WriteLine("[9] Twin strings");
Console.WriteLine("[10] Second greatest");
Console.WriteLine("[11] Bracket checker");
Console.WriteLine("[12] Triangle display");
Console.WriteLine();
Console.WriteLine("[99] Keluar");
Console.WriteLine("+--------------------------------------------+");
Console.WriteLine();

Console.Write("Masukkan pilihan : ");
var choice = Console.ReadLine();
Console.Clear();

switch (choice)
{
    case "99":
        Console.WriteLine("Keluar dari program");
        goto Keluar;
    case "1":
        Summary();
        break;
    case "2":
        StringLength();
        break;
    case "3":
        Reverse();
        break;
    case "4":
        Max();
        break;
    case "5":
        Dividers();
        break;
    case "6":
        Prime();
        break;
    case "7":
        SecretStrings();
        break;
    case "8":
        Saturday();
        break;
    case "9":
        SameString();
        break;
    case "10":
        SecondGreatest();
        break;
    case "11":
        Console.WriteLine(CheckKurawal());
        Console.WriteLine();
        break;
    case "12":
        TriangleDisplay();
        break;
    default:
        Console.WriteLine("Pilihan yang dimasukkan tidak sesuai!");
        Console.WriteLine();
        goto Menu;
}

Repeat:
Console.Write("Apakah akan mengulang program? (y/t) : ");
var repeat = Console.ReadLine();
Console.Clear();

if(repeat == "y" || repeat == "Y")
{
    goto Menu;
}
else if(repeat == "t" || repeat == "T")
{
    goto Keluar;
}
else
{
    Console.Clear();
    Console.WriteLine("Masukan tidak dikenali : ");
    goto Repeat;
}

Keluar:

static void Summary()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|       1. MENGHITUNG TOTAL ANGKA YANG DIMASUKKAN      |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
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
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|          2. MENGHITUNG PANJANG KARAKTER              |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine(); 
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
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|             3. MEMBALIKAN URUTAN MASUKAN             |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    Console.Write("Enter number integer : ");
    char[] num = Console.ReadLine().ToCharArray();
    for(var i = num.Length - 1; i >= 0; i--)
    {
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

static void Max()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|              4. MENCARI NILAI TERBESAR               |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    List<int> num = new();
    bool cond = true;
    while (cond) {
        Console.Write("Enter integer [Type 0 for exit] : ");
        var input = int.Parse(Console.ReadLine());
        if (input > 0) num.Add(input); else cond = false;
    }
    Console.WriteLine($"Angka terbesar : {num.Max()}");
    Console.WriteLine();
}

static void Dividers()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|               5. MENCARI ANGKA PEMBAGI               |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    Console.Write("Enter numbers : ");
    var num = int.Parse(Console.ReadLine());
    for(var i = 1; i < num; i++)
    {
        Console.Write(num % i == 0 ? $"{i} ":"");
    }
    Console.WriteLine();
    Console.WriteLine();
}

static void Prime()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("| 6. MENAMPILKAN BILANGAN PRIMA DENGAN LIMIT TERTENTU  |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    Console.Write("Enter limit number : ");
    var num = int.Parse(Console.ReadLine());
    for (var i = 2; i < num; i++)
    {
        bool result = true;
        for(var j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                result = false;
                break;
            }
        }
        if(result) Console.Write($"{i} ");
    }
    Console.WriteLine();
}
static void SecretStrings()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|            7. MENYEMBUNYIKAN STRING TENGAH           |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
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
    Console.WriteLine();
}


static void Saturday() 
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|   8. BERAPA HARI LAGI MENUJU HARI SABTU BERIKUTNYA   |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine(); 
    DateTime today = DateTime.Today;
    int daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)today.DayOfWeek + 7) % 7;
    DateTime nextSaturday = today.AddDays(daysUntilSaturday);

    Console.WriteLine($"Hari Sabtu : {nextSaturday.ToShortDateString()}");
    Console.WriteLine($"{daysUntilSaturday} hari lagi!");
    Console.WriteLine();
}

static void SameString()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|             9. MENCARI STRING YANG SAMA              |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    Console.Write("Enter strings : ");
    string str = Console.ReadLine();
    Console.Write("Find String : ");
    string substr = Console.ReadLine();
    int count = (str.Length - str.Replace(substr, "").Length) / substr.Length;
    Console.WriteLine($"Total kata yang muncul : {count} kali dari text {str}");
    Console.WriteLine();
}

static void SecondGreatest()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|          10. MENCARI NILAI TERBESAR KEDUA            |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    List<int> num = new();
    for(var i = 1; i <= 5; i++)
    {
        Console.Write($"Enter {i}. number: ");
        num.Add(int.Parse(Console.ReadLine()));
    }
    var result = num.OrderByDescending(x => x).Distinct().ElementAt(1);
    Console.WriteLine($"Second Greatest : {result}");
    Console.WriteLine();
}

static bool CheckKurawal()
{
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|         11. CEK KURUNG KURAWAL BERPASANGAN           |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine();
    Console.Write("Masukkan kurung kurawal : ");
    var str = Console.ReadLine();
    Console.WriteLine();
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
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine("|             12. DISPLAY RUNTUTAN ANGKA               |");
    Console.WriteLine("+------------------------------------------------------+");
    Console.WriteLine(); 
    
    int row, col, num;
    num = 10;
    row = 5;
    col = 5;

    //Console.Write("Masukkan batas atas : ");
    //num = int.Parse(Console.ReadLine());
    //Console.Write("Masukkan jumlah baris dan kolom : ");
    //col = int.Parse(Console.ReadLine());
    Console.WriteLine();

    for (var i = col; i < num; i++)
    {
        //Console.WriteLine(i);
        for (var j = num; j > col; j--)
        {
            if (j > i) Console.Write($"{j} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();

    //Console.Write("Masukkan baris : ");
    //row = int.Parse(Console.ReadLine());
    //Console.Write("Masukkan kolom : ");
    //col = int.Parse(Console.ReadLine());
    Console.WriteLine();


    for (var i = 1; i <= row; i++)
    {
        for (var j = 0; j < col; j++)
        {
            if (j < i) Console.Write($"{i + j} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();

    //Console.Write("Masukkan kolom : ");
    //col = int.Parse(Console.ReadLine());
    Console.WriteLine();

    for (int i = 1; i < col*2; i++)
    {
        if (i <= col)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = 1; j <= col*2 - i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();

    //Console.Write("Masukkan baris : ");
    //row = int.Parse(Console.ReadLine());
    Console.WriteLine();

    for (int i = 1; i <= row; i++)
    {
        for (int j = 1; j <= row - i; j++)
        {
            Console.Write("  ");
        }
        for (int j = i; j < 2 * i; j++)
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