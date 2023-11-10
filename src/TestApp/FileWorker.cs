using System;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class FileWorker
{
    public static string ReadFile(string filePath)
	{
        StringBuilder data = new ();

        StreamReader reader = new StreamReader(filePath);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
           data.AppendLine(line);
        }
        return data.ToString ();
    }
}
