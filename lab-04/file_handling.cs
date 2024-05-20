namespace lab_1;


class FileHandling
{
    static void Main(string[] args)
    {
        string drive = "C:";
        string folderPath = Path.Combine(drive, "NCC");
        string filePath = Path.Combine(folderPath, "test.txt");

        if(!Directory.Exists(folderPath)){
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Created new folder NCC");
        }

        File.WriteAllText(filePath, "NET Centric Computing");
        Console.WriteLine("File 'test.txt' created or updated");

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("File content:\n{0}", fileContent);
    }
}
