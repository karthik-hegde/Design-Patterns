// Construct file system
using VisitorPattern;
using File = VisitorPattern.File;

var file1 = new File("file1.txt", 120);
var file2 = new File("file2.txt", 80);
var file3 = new File("file3.txt", 200);

var subFolder = new Folder("SubFolder");
subFolder.Add(file3);

var rootFolder = new Folder("Root");
rootFolder.Add(file1);
rootFolder.Add(file2);
rootFolder.Add(subFolder);

// Apply Visitors
var sizeCalculator = new SizeCalculator();
rootFolder.Accept(sizeCalculator);
Console.WriteLine($"Total size: {sizeCalculator.TotalSize} bytes");

var contentLister = new ContentLister();
rootFolder.Accept(contentLister);
