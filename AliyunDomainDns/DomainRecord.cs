using Aliyun.Acs.Alidns.Model.V20150109;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using System;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace AliyunDomainDns
{
    public class DomainRecord
    {
        DomainRecordOptions Options { get; }
        
        IAcsClient client = null;

        DescribeDomainRecordsRequest request = null;

        public DomainRecord(DomainRecordOptions options)
        {
            Options = options;
            var profile = DefaultProfile.GetProfile(Options.RegionId, Options.AccessKeyId, Options.AccessKeySecret);
            client = new DefaultAcsClient(profile);
            request = new DescribeDomainRecordsRequest();

            //request.Url = "http://domain.aliyuncs.com/";
            request.DomainName = Options.DomainName;
            request.TypeKeyWord = Options.DomainType;
            //request.ActionName = "DescribeDomainRecords";
        }

        public async Task CheckAndModify()
        {
            string ip = await IPHelper.GetIP_Amazon();
            if (string.IsNullOrEmpty(ip))
            {
                throw new Exception("Get Local IP error");
            }
            var response = client.GetAcsResponse(request);
            foreach (var item in response.DomainRecords)
            {
                if (Options.MonitorHosts.Contains(item.RR) && item._Value != ip)
                {
                    var updateRequest = new UpdateDomainRecordRequest();
                    updateRequest.RecordId = item.RecordId;
                    updateRequest.RR = item.RR;
                    updateRequest.Type = item.Type;
                    updateRequest._Value = ip;
                    var updateResponse = client.GetAcsResponse(updateRequest);
                    if (!updateResponse.HttpResponse.isSuccess())
                    {
                        Log.Logger.Error($"主机记录：{item.RR},IP:{ip}，更新ip失败");
                    }
                    else
                    {
                        Log.Logger.Information($"主机记录：{item.RR},IP:{ip}，更新成功");
                    }
                }
            }
        }
    }
}
