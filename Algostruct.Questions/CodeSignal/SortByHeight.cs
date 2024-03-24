using System.Linq;

namespace Algostruct.Questions.CodeSignal
{
    // Some people are standing in a row in a park.There are trees between them which cannot be moved.
    // Your task is to rearrange the people by their heights in a non-descending order without moving the trees.
    // People can be very tall!
    // Example
    // For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
    // solution(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
    public class SortByHeight
    {
        public static int[] Solution(int[] a)
        {
            int[] people = a.Where(p => p != -1).OrderBy(p => p).ToArray();
            int shift = 0;

            return a.Select(p => p != -1 ? people[shift++] : -1).ToArray();
        }
    }
}
