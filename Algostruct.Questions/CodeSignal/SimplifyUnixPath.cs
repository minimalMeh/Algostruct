using System.Collections.Generic;
using System.Text;

namespace Algostruct.Questions.CodeSignal
{
    //    Given an absolute file path(Unix-style), shorten it to the format /<dir1>/<dir2>/<dir3>/....
    //Here is some info on Unix file system paths:
    /// is the root directory; the path should always start with it even if it isn't there in the given path;
    /// is also used as a directory separator; for example, /code/fights denotes a fights subfolder in the code
    /// folder in the root directory;
    //this also means that // stands for "change the current directory to the current directory"
    //. is used to mark the current directory;
    //.. is used to mark the parent directory; if the current directory is root already, .. does nothing.
    //Example
    //For path = "/home/a/./x/../b//c/", the output should be
    //solution(path) = "/home/a/b/c".

    public class SimplifyUnixPath
    {
        public static string GetFullPath(string path)
        {
            string[] splitted = path.Split('/');
            StringBuilder fullPathBuilder = new();
            Stack<string> directories = new();

            for (int i = 0; i < splitted.Length; i++)
            {
                if (splitted[i].Length == 0 || splitted[i] == ".")
                    continue;

                if (splitted[i] == "..")
                {
                    if (fullPathBuilder.Length != 0)
                    {
                        string currentDirectory = directories.Pop();
                        fullPathBuilder.Remove(
                            fullPathBuilder.Length - currentDirectory.Length - 1,
                            currentDirectory.Length + 1);
                    }
                    continue;
                }

                fullPathBuilder.Append('/');
                fullPathBuilder.Append(splitted[i]);
                directories.Push(splitted[i]);
            }

            return fullPathBuilder.Length == 0 ? "/" : fullPathBuilder.ToString();
        }
    }
}
