using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Avro;
using Brew.Models;
using Microsoft.Extensions.Logging;

namespace Brew.Avro
{
    public class AvroSchemaToModels : IBrew
    {
        private readonly ILogger<AvroSchemaToModels> logger;

        public AvroSchemaToModels(ILogger<AvroSchemaToModels> logger)
        {
            this.logger = logger;
        }

        public void Execute()
        {
            var schemas = new List<string>()
            {
                @"
	            {
	              ""type"": ""enum"",
	              ""name"": ""Suit"",
	              ""namespace"": ""datadomain"",
	              ""symbols"" : [""SPADES"", ""HEARTS"", ""DIAMONDS"", ""CLUBS""]
	            }
	            ",
                            @"
	            {
	                  ""type"": ""record"",
	                  ""name"": ""Person"",
		              ""namespace"": ""datadomain"",
	                  ""fields"" : [
	      	            { ""name"": ""Name"", ""type"": ""string""},
	                    { ""name"": ""Age"", ""type"": ""long"" }
	                  ]
	                  }
	            "
            };

            CodeGen gen = new ();
            schemas.ForEach(json => gen.AddSchema(Schema.Parse(json)));
            var compileUnit = gen.GenerateCode();
            var path = Path.Combine(@"C:\Users\patri\OneDrive\Projects\brew\Brew.Models\", "datadomain.cs");

            logger.LogInformation($"Writing C# Models to: {path}");
			
			gen.WriteCompileUnit(path);


		}
	}
}
