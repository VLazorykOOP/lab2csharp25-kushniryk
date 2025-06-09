using System.Data;
using static System.Console;

static void Task1()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[] a = new int[n];

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(0, 9);
    }

    int odd = 0;

    for(int i = 0; i < n; i++)
    {
        if(a[i] % 2 != 0)
        {
            odd++;
        }
        Write($"[{a[i]}]");
    }
    WriteLine($"\nCount odd element: {odd}");
}

static void Task2()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[] a = new int[n];

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(0, 9);
    }

    int max = 0;
    int index = 0;

    for (int i = 0; i < n; i++)
    {
        if(a[i] > max)
        {
            max = a[i];
            index = i;
        }
        Write($"[{a[i]}]");
    } 
    WriteLine($"\nLast maximum element index: {index}");
    WriteLine($"Last maximum element: {max}");
    
}

static void Task3()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int [,] b = new int [n,n];

    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            b[i,j] = rand.Next(-9, 9);
        }
    }

    WriteLine("Before swap:");
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"[{b[i,j]}]");
        }
        WriteLine();
    }

    if(n % 2 == 0)
    {
        for (int i = 0; i < n; i++) 
        {
            int temp = b[i, n / 2];
            b[i, n / 2] = b[i, (n / 2) - 1];
            b[i, (n / 2) - 1] = temp;
        }
    }
    else
    {
        for (int i = 0; i < n; i++) 
        {
            int temp = b[i, (n - 1) / 2];
            b[i, (n - 1) / 2] = b[i, 0];
            b[i, 0] = temp;
        }
    }


    WriteLine("After swap:");
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"[{b[i,j]}]");
        }
        WriteLine();
    }
}

static void Task4()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[][] c = new int[n][];

    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        c[i] = new int[rand.Next(1, 9)];
    }

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            c[i][j] = rand.Next(-9, 9);
        }
    }

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            Write($"[{c[i][j]}]");
        }
        WriteLine();
    }

    int even = 0;
    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            if(c[i][j] % 2 == 0)
            {
                even++;
                break;
            }
        }
    }

    int[] a = new int[even];
    int last = 0;

    for (int i = 0; i < c.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < c[i].Length; j++)
        {
            if(c[i][j] % 2 == 0)
            {
                last = c[i][j];
            }
        }
        a[i] = last;
    }
    WriteLine("Result:");
    for(int i = 0; i < a.Length; i++)
        Write($"[{a[i]}]");
}

Task4();


