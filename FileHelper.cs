public class FileHelper
{
    public static string GetNewFile(string detectPath, Action action)
    {
        if (!Directory.Exists(detectPath)) {
            throw new DirectoryNotFoundException($"The directory '{detectPath}' does not exist.");
        }

        HashSet<string> beforeFiles = new HashSet<string>(Directory.GetFiles(detectPath));

        action();

        HashSet<string> afterFiles = new HashSet<string>(Directory.GetFiles(detectPath));

        string newFile = afterFiles.Except(beforeFiles).FirstOrDefault();

        return newFile ?? throw new Exception("No new file detected.");
    }
}
