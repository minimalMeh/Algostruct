using Algostruct.Algorithms.Sort;

var result = SelectionSort<int>.Sort(new[] { 1, 6, 4, 2, 3, 7, 1, 0, -10, 4, 22, 9, 13 });
Console.WriteLine(string.Join(", ", result));