// 创建人：李鸢
// 创建时间：2020/05/18 10:38

using System.Collections.Generic;
using System.Collections.Immutable;
using Grpc.Core;

namespace AspNetMvc.Grpc.utils
{
    public class GrpcClientUtil
    {
        //真实环境下，可以从redis取值
        private static IDictionary<string, string> macHostMap = ImmutableDictionary<string, string>.Empty.Add("201912176604","127.0.0.1");

        private const int Port = 50051;
        
        public static ClientBase GetGrpcClient(string mac)
        {
            string host = null;
            macHostMap.TryGetValue(mac, out host);
            var url = host + ":" + Port;
            var channel = new Channel(url, ChannelCredentials.Insecure);
            var client = new CtrlService.CtrlServiceClient(channel);
            return client;
        }
    }
}