using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit.Sdk;

namespace EAI_Internal_API.XunitAttributes
{
    /// <inheritdoc />
    public class JsonDataSourceAttribute : DataAttribute
     {
        private readonly string filePath;
        private readonly string format;

        public JsonDataSourceAttribute(string filePath, string format)
        {
            this.filePath = filePath;
            this.format = format;
        }

        /// <inheritdoc />
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null) { throw new ArgumentNullException(nameof(testMethod)); }

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(this.filePath)
                ? this.filePath
                : $"{Directory.GetCurrentDirectory()}\\{this.filePath}";

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }

            // Load the file
            var fileData = File.ReadAllText(this.filePath);
            var jsonReader = new JsonTextReader(new StringReader(fileData)){DateParseHandling = DateParseHandling.None};

            // This will not work: dynamic testDataObjects = JArray.Parse(fileData);
            // because JArray.Parse() will parse valid dates as Date objects which
            // print with default format which is not what we want.
            dynamic testDataObjects = JArray.Load(jsonReader);

            var objectArrayList = new List<object[]>();

            switch (this.format)
            {
                case "replace":
                    foreach (var testDataObject in testDataObjects)
                    {
                        objectArrayList.Add(new[]
                        {
                            testDataObject.title,
                            testDataObject.replacekey,
                            testDataObject.replacevalue,
                            testDataObject.expectedHttpStatusCode
                        });
                    }
                    break;
                case "replaceAndResponse":
                    foreach (var testDataObject in testDataObjects)
                    {
                        objectArrayList.Add(new[]
                        {
                            testDataObject.title,
                            testDataObject.replacekey,
                            testDataObject.replacevalue,
                            testDataObject.expectedHttpStatusCode,
                            testDataObject.expectedResponse
                        });
                    }
                    break;
                case "parameter":
                    foreach (var testDataObject in testDataObjects)
                    {
                        objectArrayList.Add(new[]
                        {
                            testDataObject.title,
                            testDataObject.parameter,
                            testDataObject.expectedHttpStatusCode
                        });
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(this.format));
            }

            return objectArrayList;
        }
    }
}
