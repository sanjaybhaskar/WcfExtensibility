﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZipCodeClient.localhost
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ZipCodeClient.localhost.IZipCodeService")]
    public interface IZipCodeService
    {
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZipCodeService/Lookup", ReplyAction="http://tempuri.org/IZipCodeService/LookupResponse")]
        string Lookup(string zipcode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IZipCodeServiceChannel : ZipCodeClient.localhost.IZipCodeService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ZipCodeServiceClient : System.ServiceModel.ClientBase<ZipCodeClient.localhost.IZipCodeService>, ZipCodeClient.localhost.IZipCodeService
    {
        
        public ZipCodeServiceClient()
        {
        }
        
        public ZipCodeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ZipCodeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ZipCodeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ZipCodeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string Lookup(string zipcode)
        {
            return base.Channel.Lookup(zipcode);
        }
    }
}
