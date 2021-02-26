using Aliyun.Acs.Alidns.Model.V20150109;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using System;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using System.Collections.Generic;
using static Aliyun.Acs.Alidns.Model.V20150109.DescribeDomainRecordsResponse;

namespace AliyunDomainDns
{
    public class DomainRecord
    {
        /// <summary>
        /// 阿里云现在的dns
        /// </summary>
        public string aliDomainDns=string.Empty;
        public List<DescribeDomainRecords_Record> describeDomainRecords_Records;
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

            var response = client.GetAcsResponse(request);
            describeDomainRecords_Records = response.DomainRecords;
        }

        public async Task CheckAndModify()
        {
            string ip = await IPHelper.GetIP_Amazon();
            if (string.IsNullOrEmpty(ip))
            {
                throw new Exception("Get Local IP error:GetIP_Amazon()");
            }
            foreach (var item in describeDomainRecords_Records)
            {
                if (Options.MonitorHosts.Contains(item.RR) && item._Value != ip)
                {
                    //比对不相同的时候更新本地ip到服务器
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
                        //更新本地存储的dns,方便下次对比，保证和服务端一致
                        item._Value = ip;
                        Log.Logger.Information($"更新主机记录：{item.RR},更新前IP:{item._Value},更新后IP:{ip}，");
                    }
                }
            }
        }
    }
}
