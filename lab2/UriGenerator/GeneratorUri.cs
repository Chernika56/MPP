using FakerLab.Generators.StringGenerators;

namespace FakerLab.Generators.UrlGenerator
{
    public class GeneratorUri : IGenerator<Uri>
    {
        public Uri GetValue()
        {
            var generator = new GeneratorString();

            var builder = new UriBuilder
            {
                Scheme = "http",
                Host = "localhost",
                Path = generator.GetValue()
            };

            return builder.Uri;
        }
    }
}
