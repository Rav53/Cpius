int N = 3, M = 3;
            var a = CreateSnakeArrayVsClock(N, M);
 CreateSnakeArray(A) = int n, int m ;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] CreateSnakeArray(int n, int m)
            {
            int[,] A = new int[n, m];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = m*(dirChanges%2) + n*((dirChanges + 1)%2) - (dirChanges/2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
            return A;
            }