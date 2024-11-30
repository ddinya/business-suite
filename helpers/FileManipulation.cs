namespace BusinessSuite.Helpers;
public class FileManipulation
{
  public static string? GetFile()
  {
    string exampleFilePath = string.Empty;
    bool exampleFileExists = false;
    while (!exampleFileExists)
    {
      Console.Write("Enter the path to example file: ");
      // /home/dsdy/Desktop/suite-test
      exampleFilePath = Console.ReadLine();
      Console.WriteLine(File.Exists(exampleFilePath) ? $"Found the file at path: {exampleFilePath}!" : "Couldn't find the file, try changing the path");
      Console.WriteLine(" ");
      exampleFileExists = File.Exists(exampleFilePath);
      Console.WriteLine(exampleFilePath);
    }
    if (!string.IsNullOrEmpty(exampleFilePath))
    {
      return exampleFilePath;
    }
    return null;
  }

  public static string? GetNewFileNumber(string path)
  {
    string folder = Path.GetFileName(Path.GetDirectoryName(path));
    Console.WriteLine(folder);
    string[] files = Directory.GetFiles(folder).Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
    files = files.Where(f => Path.GetFileName(f).ToLower().StartsWith("invoice")).ToArray();
    foreach (string file in files)
    {
      Console.WriteLine(file);
    }
    var lastFile = files.Last();
    if (lastFile != null)
    {
      var fileNumber = lastFile.Split('_')[1];
      return $"{Int32.Parse(fileNumber) + 1}";
    }
    return "1";
  }

  public static string GetFolder(string path)
  {
    string folder = Path.GetFileName(Path.GetDirectoryName(path));
    return folder;
  }

  public static void CopyFile(string exampleFile, string newFile)
  {
    File.Copy(exampleFile, newFile);
  }
}