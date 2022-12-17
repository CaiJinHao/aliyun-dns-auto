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
            Log.Logger.Information("正在启动。。。");
            DomainRecordOptions domainRecordOptions = new DomainRecordOptions();
            DomainRecord domainRecord = new DomainRecord(domainRecordOptions);
            Log.Logger.Information("启动成功");
            while (true)
            {
                try
                {
                    //Log.Logger.Information("开始检测");
                    domainRecord.CheckAndModify().Wait();
                }
                catch (Exception ex)
                {
                    Log.Logger.Error(ex, "CheckAndModify Error");
                }
                Thread.Sleep(30000);
            }
        }
    }
}
