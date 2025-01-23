using Directory = CompositePattern.Directory;
using File = CompositePattern.File;


// Create root directory
Directory root = new Directory("root");

// Create files
var file1 = new File("file1.txt", 100);
var file2 = new File("file2.txt", 200);

// Create subdirectory
var subDir = new Directory("subDir");
var subFile = new File("subFile.txt", 150);
subDir.Add(subFile);

// Add files and subdirectory to root
root.Add(file1);
root.Add(file2);
root.Add(subDir);

// Display the structure
root.Display("  ");

// Get total size
Console.WriteLine($"Total size: {root.GetSize()} bytes");