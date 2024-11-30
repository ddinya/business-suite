using BusinessSuite.Helpers;
internal class Program
{
    private static void Main(string[] args)
    {
        string mode = Welcome.AskForMode();
        if (mode == "Create Invoice") {
            var file = FileManipulation.GetFile();
            var path = Path.GetDirectoryName(file);
            Console.WriteLine($"path{path}" );
            var fileNumber = FileManipulation.GetNewFileNumber(file);
            var newFileName = $"invoice_{fileNumber}.docx";
            FileManipulation.CopyFile(file, Path.Combine(path, newFileName));
        }
        Console.WriteLine(" ");
    }
}