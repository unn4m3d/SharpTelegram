
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the SharpTL compiler (https://github.com/Taggersoft/SharpTL).
//     Generated at 11/19/2014 12:51:25
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable 1591
// ReSharper disable UnusedMember.Global
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
namespace SharpMTProto.Schema
{
    using System.Threading.Tasks;
    using IRemoteProcedureCaller = SharpMTProto.IRemoteProcedureCaller;

    public partial class MTProtoAsyncMethods : IMTProtoAsyncMethods
    {
        private readonly IRemoteProcedureCaller _remoteProcedureCaller;

        public MTProtoAsyncMethods(IRemoteProcedureCaller remoteProcedureCaller)
        {
            _remoteProcedureCaller = remoteProcedureCaller;
            SetupRemoteProcedureCaller(remoteProcedureCaller);
        }

        partial void SetupRemoteProcedureCaller(IRemoteProcedureCaller remoteProcedureCaller);

        public Task<IResPQ> ReqPqAsync(ReqPqArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IResPQ>(args);
        }

        public Task<IServerDHParams> ReqDHParamsAsync(ReqDHParamsArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IServerDHParams>(args);
        }

        public Task<ISetClientDHParamsAnswer> SetClientDHParamsAsync(SetClientDHParamsArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<ISetClientDHParamsAnswer>(args);
        }

        public Task<IRpcDropAnswer> RpcDropAnswerAsync(RpcDropAnswerArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IRpcDropAnswer>(args);
        }

        public Task<IFutureSalts> GetFutureSaltsAsync(GetFutureSaltsArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IFutureSalts>(args);
        }

        public Task<IPong> PingAsync(PingArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IPong>(args);
        }

        public Task<IPong> PingDelayDisconnectAsync(PingDelayDisconnectArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IPong>(args);
        }

        public Task<IDestroySessionRes> DestroySessionAsync(DestroySessionArgs args)
        {
            return _remoteProcedureCaller.RpcAsync<IDestroySessionRes>(args);
        }

        public Task HttpWaitAsync(HttpWaitArgs args)
        {
            return _remoteProcedureCaller.SendAsync(args);
        }

    }
}
#pragma warning restore 1591
