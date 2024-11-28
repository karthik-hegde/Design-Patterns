namespace TemplatePattern
{
    public class CsvProcessor : FileProcessor
    {
        public override void ParseFile()
        {
            Console.WriteLine("Parsing csv file");
        }

        public override void SaveData()
        {
            Console.WriteLine("saving csv file");
        }

        public override void TransformData()
        {
            Console.WriteLine("transforming csv file");
        }

        public override void ValidateFile()
        {
            Console.WriteLine("validating csv file");
        }
    }
}