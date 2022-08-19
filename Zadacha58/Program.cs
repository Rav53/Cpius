            
int n = 5;
var a = Snake(n);
for (int i = 0; i < n; i++)
{
 for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j]+ "\t");
    }
        Console.WriteLine();
}

int[,] Snake(int n)
{
    var result = new int[n, n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
        result[i, j] = rand.Next(n, n);
        for (int currentIndex = 1, step = 0; step < n / 2; step++)
        {
        for (int j = step; j < n - step; j++)
            result[step, j] = currentIndex;
        for (int j = step; j < n - step; j++)
            result[n - step - 1, j] = currentIndex;
        for (int i = step + 2; i < n - step - 1; i++)
            result[i, step] = currentIndex;
        for (int i = step + 1; i < n - step - 1; i++)
            result[i, n - step - 1] = currentIndex;
            currentIndex = 1 - currentIndex;
            result[step + 1, step] = currentIndex;
        }
        if (n % 2 != 0 && result[0, 0] == 1)
            result[n / 2, n / 2] = 1;
            return result;
}
    
