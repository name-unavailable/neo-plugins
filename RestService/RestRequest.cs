using Neo.Network.RPC.Models;

namespace Neo.Plugins
{
    public class InvokeFunctionParameter
    {
        public string ScriptHash { get; set; }
        public string Operation { get; set; }
        public RpcStack[] Params { get; set; }
    }

    public class InvokeScriptParameter
    {
        public string Script { get; set; }
        public string[] Hashes { get; set; }
    }
}
