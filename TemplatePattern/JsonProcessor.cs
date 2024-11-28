using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class JsonProcessor : FileProcessor
    {
        public override void ParseFile()
        {
            Console.WriteLine("Parsing json file");
        }

        public override void SaveData()
        {
            Console.WriteLine("saving json file");
        }

        public override void TransformData()
        {
            Console.WriteLine("transforming json file");
        }

        public override void ValidateFile()
        {
            Console.WriteLine("validating json file");
        }
    }
}