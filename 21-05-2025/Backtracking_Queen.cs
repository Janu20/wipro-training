class Program
{

    static void Main()
    {
        int N = 4; 
        SolveNQueens(N);
    }

    static void SolveNQueens(int N)
    {
        char[,] board = new char[N, N];
       
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                board[i, j] = '_';

        List<char[,]> solutions = new List<char[,]>();
        PlaceQueens(board, 0, N, solutions);

        
        foreach (var solution in solutions)
        {
            PrintBoard(solution, N);
            Console.WriteLine();
        }
    }

    static void PlaceQueens(char[,] board, int row, int N, List<char[,]> solutions)
    {
        if (row == N)
        {
           
            char[,] solution = new char[N, N];
            Array.Copy(board, solution, board.Length);
            solutions.Add(solution);
            return;
        }

        for (int col = 0; col < N; col++)
        {
            if (IsSafe(board, row, col, N))
            {
                board[row, col] = 'Q';
                PlaceQueens(board, row + 1, N, solutions);
                board[row, col] = '_'; 
            }
        }
    }

    static bool IsSafe(char[,] board, int row, int col, int N)
    {
       
        for (int i = 0; i < row; i++)
            if (board[i, col] == 'Q')
                return false;

       
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 'Q')
                return false;

        for (int i = row - 1, j = col + 1; i >= 0 && j < N; i--, j++)
            if (board[i, j] == 'Q')
                return false;

        return true;
    }

    static void PrintBoard(char[,] board, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(board[i, j] + " ");
            Console.WriteLine();
        }
    }
}
