namespace LeetCode.Recursion
{
    public sealed class TotalNQueensSolution
    {
        public int TotalNQueens(int n)
        {
            if (n == 0) return 0;
            if (n <= 2) return 1;

            int count = 0;
            int[][] field = new int[n][];
            for(int i = 0; i < n; ++i)
            {
                field[i] = new int[n];
            }
            ProceedRow(0, field, n, ref count);
            return count;
        }

        private static void ProceedRow(int row, int[][] field, int n, ref int count)
        {
            for(int col = 0; col < n; ++col)
            {
                if(IsNotUnderAttack(row, col, field))
                {
                    PlaceQueen(row, col, field);
                    if(row == field.Length - 1)
                    {
                        ++count;
                    }
                    else
                    {
                        ProceedRow(row + 1, field, n, ref count);
                    }
                    RemoveQueen(row, col, field);
                }
            }
        }

        private static bool IsNotUnderAttack(int row, int col, int[][] field)
        {
            for(int idx = 0; idx < field.Length; ++idx)
            {
                if (field[row][idx] == 1 || field[idx][col] == 1) return false;
            }
            for(int rowIdx = row + 1, colIdx = col + 1; rowIdx < field.Length && colIdx < field.Length; ++rowIdx, ++colIdx)
            {
                if (field[rowIdx][colIdx] == 1) return false;
            }
            for (int rowIdx = row - 1, colIdx = col - 1; rowIdx >= 0 && colIdx >= 0; --rowIdx, --colIdx)
            {
                if (field[rowIdx][colIdx] == 1) return false;
            }
            for (int rowIdx = row + 1, colIdx = col - 1; rowIdx < field.Length && colIdx >= 0; ++rowIdx, --colIdx)
            {
                if (field[rowIdx][colIdx] == 1) return false;
            }
            for (int rowIdx = row - 1, colIdx = col + 1; rowIdx >= 0 && colIdx < field.Length; --rowIdx, ++colIdx)
            {
                if (field[rowIdx][colIdx] == 1) return false;
            }
            return true;
        }

        private static void PlaceQueen(int row, int col, int[][] field) => field[row][col] = 1;
        
        private static void RemoveQueen(int row, int col, int[][] field) => field[row][col] = 0;
    }
}
