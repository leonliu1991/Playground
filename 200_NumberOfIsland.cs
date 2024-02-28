using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class _200_NumberOfIsland
    {
        int nr;
        int nc;
        public int NumIslands(char[][] grid)
        {
            nr = grid.Length;
            nc = grid[0].Length;
            int count = 0;
            for(int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nc; j++) 
                {
                    if(grid[i][j] == '1')
                    {
                        count++;
                        DFS(grid, i, j);
                    }
                }
            }
            return count;
        }

        public void DFS(char[][] grid, int i, int j)
        {
            if(i>=0 && j>=0 && i < nr && j < nc && grid[i][j] == '1')
            {
                grid[i][j] = '0';
                DFS(grid, i - 1, j);
                DFS(grid, i + 1, j);
                DFS(grid, i, j+1);
                DFS(grid, i, j-1);

            }
        }
    }
}
