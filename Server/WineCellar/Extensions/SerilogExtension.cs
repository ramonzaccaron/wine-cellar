using Serilog;
using Serilog.Sinks.Elasticsearch;

namespace WineCellar.Extensions
{
    public static class SerilogExtension
    {
        public static void AddSerilog(WebApplicationBuilder builder)
        {
            var elasticsearchConfiguration = builder.Configuration.GetSection("Elasticsearch").Get<ElasticsearchConfiguration>();

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Elasticsearch(
                    options:
                        new ElasticsearchSinkOptions(
                            new Uri(elasticsearchConfiguration.Uri))
                        {
                            AutoRegisterTemplate = true,
                            AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv7,
                            IndexFormat = "apiwinecellar-{0:yyyy.MM}"
                        })
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}
