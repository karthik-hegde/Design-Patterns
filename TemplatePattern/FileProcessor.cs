using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class FileProcessor
    {
        public void ProcessFile()
        {
            ValidateFile();
            ParseFile();
            TransformData();
            SaveData();
        }

        public abstract void ValidateFile();
        public abstract void ParseFile();
        public abstract void TransformData();
        public abstract void SaveData();
    }
}