﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fincal.Userservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Wcffincal")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Userservice.IUserservice")]
    public interface IUserservice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/GetData", ReplyAction="http://tempuri.org/IUserservice/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/GetData", ReplyAction="http://tempuri.org/IUserservice/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IUserservice/GetDataUsingDataContractResponse")]
        Fincal.Userservice.CompositeType GetDataUsingDataContract(Fincal.Userservice.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IUserservice/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Fincal.Userservice.CompositeType> GetDataUsingDataContractAsync(Fincal.Userservice.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/insertUser", ReplyAction="http://tempuri.org/IUserservice/insertUserResponse")]
        int insertUser(string Username, string Password, string firstName, string surname, string Email, System.DateTime DoB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/insertUser", ReplyAction="http://tempuri.org/IUserservice/insertUserResponse")]
        System.Threading.Tasks.Task<int> insertUserAsync(string Username, string Password, string firstName, string surname, string Email, System.DateTime DoB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/Authenticate", ReplyAction="http://tempuri.org/IUserservice/AuthenticateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Fincal.Userservice.CompositeType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] Authenticate(string UserEmail, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/Authenticate", ReplyAction="http://tempuri.org/IUserservice/AuthenticateResponse")]
        System.Threading.Tasks.Task<object[]> AuthenticateAsync(string UserEmail, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/getUserDetailsManagement", ReplyAction="http://tempuri.org/IUserservice/getUserDetailsManagementResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Fincal.Userservice.CompositeType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] getUserDetailsManagement(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/getUserDetailsManagement", ReplyAction="http://tempuri.org/IUserservice/getUserDetailsManagementResponse")]
        System.Threading.Tasks.Task<object[]> getUserDetailsManagementAsync(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/updateUserInfo", ReplyAction="http://tempuri.org/IUserservice/updateUserInfoResponse")]
        int updateUserInfo(int ID, string firstName, string surname, System.DateTime DoB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/updateUserInfo", ReplyAction="http://tempuri.org/IUserservice/updateUserInfoResponse")]
        System.Threading.Tasks.Task<int> updateUserInfoAsync(int ID, string firstName, string surname, System.DateTime DoB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/deleteUser", ReplyAction="http://tempuri.org/IUserservice/deleteUserResponse")]
        int deleteUser(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserservice/deleteUser", ReplyAction="http://tempuri.org/IUserservice/deleteUserResponse")]
        System.Threading.Tasks.Task<int> deleteUserAsync(string ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserserviceChannel : Fincal.Userservice.IUserservice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserserviceClient : System.ServiceModel.ClientBase<Fincal.Userservice.IUserservice>, Fincal.Userservice.IUserservice {
        
        public UserserviceClient() {
        }
        
        public UserserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Fincal.Userservice.CompositeType GetDataUsingDataContract(Fincal.Userservice.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Fincal.Userservice.CompositeType> GetDataUsingDataContractAsync(Fincal.Userservice.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int insertUser(string Username, string Password, string firstName, string surname, string Email, System.DateTime DoB) {
            return base.Channel.insertUser(Username, Password, firstName, surname, Email, DoB);
        }
        
        public System.Threading.Tasks.Task<int> insertUserAsync(string Username, string Password, string firstName, string surname, string Email, System.DateTime DoB) {
            return base.Channel.insertUserAsync(Username, Password, firstName, surname, Email, DoB);
        }
        
        public object[] Authenticate(string UserEmail, string Password) {
            return base.Channel.Authenticate(UserEmail, Password);
        }
        
        public System.Threading.Tasks.Task<object[]> AuthenticateAsync(string UserEmail, string Password) {
            return base.Channel.AuthenticateAsync(UserEmail, Password);
        }
        
        public object[] getUserDetailsManagement(int userID) {
            return base.Channel.getUserDetailsManagement(userID);
        }
        
        public System.Threading.Tasks.Task<object[]> getUserDetailsManagementAsync(int userID) {
            return base.Channel.getUserDetailsManagementAsync(userID);
        }
        
        public int updateUserInfo(int ID, string firstName, string surname, System.DateTime DoB) {
            return base.Channel.updateUserInfo(ID, firstName, surname, DoB);
        }
        
        public System.Threading.Tasks.Task<int> updateUserInfoAsync(int ID, string firstName, string surname, System.DateTime DoB) {
            return base.Channel.updateUserInfoAsync(ID, firstName, surname, DoB);
        }
        
        public int deleteUser(string ID) {
            return base.Channel.deleteUser(ID);
        }
        
        public System.Threading.Tasks.Task<int> deleteUserAsync(string ID) {
            return base.Channel.deleteUserAsync(ID);
        }
    }
}
