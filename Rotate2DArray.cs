namespace Playground
{
    public class Rotate2DArray
    {
        public int[,] number;
        public int temp;

        public Rotate2DArray(int[,] num)
        {
            number = num;
        }

        public void RotateBy90DegreeAntiClockwise()
        {
            for (int i = 0; i <= number.Rank; i++)
            {
                for (int j = 0; j < number.Rank - 1; j++)
                {
                    temp = number[i, j];
                    number[i, j] = number[i, number.Rank];
                    number[i, number.Rank] = temp;
                }
            }

            for (int i = 0; i <= number.Rank; i++)
            {
                for (int j = i; j <= number.Rank; j++)
                {
                    temp = number[i, j];
                    number[i, j] = number[j, i];
                    number[j, i] = temp;
                }
            }

        }
    }
}
