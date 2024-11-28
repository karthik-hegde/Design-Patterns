// Instantiate concrete processors
using TemplatePattern;

FileProcessor csvProcessor = new CsvProcessor();
FileProcessor jsonProcessor = new JsonProcessor();

// Test CSV processing
Console.WriteLine("Testing CSV Processor:");
csvProcessor.ProcessFile();

// Test JSON processing
Console.WriteLine("\nTesting JSON Processor:");
jsonProcessor.ProcessFile();