using Serilog;
using System;
using System.Threading;

namespace AliyunDomainDns
{
    class Program
    {
        public const string SerilogOutputTemplate = "{NewLine}{NewLine}Date：{Timestamp:yyyy-MM-dd HH:mm:ss.fff}{NewLine}LogLevel：{Level}{NewLine}Message：{Message}{NewLine}{Exception}";

        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .Enrich.FromLogContext()
                .WriteTo.Async(c =>
                {
                    c.File(path: $"Logs/logs-.log",
                    outputTemplate: SerilogOutputTemplate,
                    fileSizeLimitBytes: 1024000,
                    rollOnFileSizeLimit: true,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 31);
                })
                .CreateLogger();
            DomainRecordOptions domainRecordOptions = new DomainRecordOptions();
            DomainRecord domainRecord = new DomainRecord(domainRecordOptions);
            while (true)
            {
                try
                {
                    domainRecord.CheckAndModify().Wait();
                }
                catch (Exception ex)
                {
                    Log.Logger.Error(ex, "CheckAndModify");
                }
                Thread.Sleep(30000);
            }
        }
    }
}
