namespace Algostruct.Questions.CodeSignal
{
    public class AlmostIncreasingSequence
    {
        public static bool Solution(int[] sequence)
        {
            int count = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    count++;

                    if (count > 1)
                        return false;

                    // Check if removing the current element would make the sequence strictly increasing.
                    if (i > 1 && sequence[i] <= sequence[i - 2])
                    {
                        sequence[i] = sequence[i - 1]; // Remove current element
                    }
                }
            }

            return true;
        }
    }
}
