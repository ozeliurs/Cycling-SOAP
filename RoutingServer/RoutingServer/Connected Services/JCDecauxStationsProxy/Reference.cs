﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoutingServer.JCDecauxStationsProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OSMRoutingClient.Position positionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OSMRoutingClient.Position position {
            get {
                return this.positionField;
            }
            set {
                if ((object.ReferenceEquals(this.positionField, value) != true)) {
                    this.positionField = value;
                    this.RaisePropertyChanged("position");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JCDecauxStationsProxy.IJCDStationsProxy")]
    public interface IJCDStationsProxy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJCDStationsProxy/GetallStations", ReplyAction="http://tempuri.org/IJCDStationsProxy/GetallStationsResponse")]
        RoutingServer.JCDecauxStationsProxy.Station[] GetallStations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJCDStationsProxy/GetallStations", ReplyAction="http://tempuri.org/IJCDStationsProxy/GetallStationsResponse")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxStationsProxy.Station[]> GetallStationsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJCDStationsProxyChannel : RoutingServer.JCDecauxStationsProxy.IJCDStationsProxy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JCDStationsProxyClient : System.ServiceModel.ClientBase<RoutingServer.JCDecauxStationsProxy.IJCDStationsProxy>, RoutingServer.JCDecauxStationsProxy.IJCDStationsProxy {
        
        public JCDStationsProxyClient() {
        }
        
        public JCDStationsProxyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JCDStationsProxyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JCDStationsProxyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JCDStationsProxyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RoutingServer.JCDecauxStationsProxy.Station[] GetallStations() {
            return base.Channel.GetallStations();
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxStationsProxy.Station[]> GetallStationsAsync() {
            return base.Channel.GetallStationsAsync();
        }
    }
}
