using System;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace jschema
{
    class Program
    {
        public async void test(string path){
            string schemaData = System.IO.File.ReadAllText(path);
            var schema = await JsonSchema4.FromJsonAsync(schemaData);
            var generator = new CSharpGenerator(schema);
            var file = generator.GenerateFile();
             System.IO.File.WriteAllText("D:/Result.cs", file);
        }
        static void Main(string[] args)
        {
            Person per = new Person{ MiddleName = "pradeep"};

            Program pgm = new Program();
            pgm.test(args[0]);
        }
    }
}
