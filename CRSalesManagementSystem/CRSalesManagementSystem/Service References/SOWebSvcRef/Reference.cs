﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRSalesManagementSystem.SOWebSvcRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/SalesOrderWebSvc")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNo {
            get {
                return this.ContactNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNoField, value) != true)) {
                    this.ContactNoField = value;
                    this.RaisePropertyChanged("ContactNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CRental", Namespace="http://schemas.datacontract.org/2004/07/SalesOrderWebSvc")]
    [System.SerializableAttribute()]
    public partial class CRental : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfPickUpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfRentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TotalAmountField;
        
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
        public string DateOfPickUp {
            get {
                return this.DateOfPickUpField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfPickUpField, value) != true)) {
                    this.DateOfPickUpField = value;
                    this.RaisePropertyChanged("DateOfPickUp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateOfRent {
            get {
                return this.DateOfRentField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfRentField, value) != true)) {
                    this.DateOfRentField = value;
                    this.RaisePropertyChanged("DateOfRent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReferenceNo {
            get {
                return this.ReferenceNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceNoField, value) != true)) {
                    this.ReferenceNoField = value;
                    this.RaisePropertyChanged("ReferenceNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalAmountField, value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CSales", Namespace="http://schemas.datacontract.org/2004/07/SalesOrderWebSvc")]
    [System.SerializableAttribute()]
    public partial class CSales : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfPurchaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TotalAmountField;
        
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
        public string DateOfPurchase {
            get {
                return this.DateOfPurchaseField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfPurchaseField, value) != true)) {
                    this.DateOfPurchaseField = value;
                    this.RaisePropertyChanged("DateOfPurchase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReferenceNo {
            get {
                return this.ReferenceNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceNoField, value) != true)) {
                    this.ReferenceNoField = value;
                    this.RaisePropertyChanged("ReferenceNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalAmountField, value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="COrder", Namespace="http://schemas.datacontract.org/2004/07/SalesOrderWebSvc")]
    [System.SerializableAttribute()]
    public partial class COrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfOrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfPickUpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TotalAmountField;
        
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
        public string DateOfOrder {
            get {
                return this.DateOfOrderField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfOrderField, value) != true)) {
                    this.DateOfOrderField = value;
                    this.RaisePropertyChanged("DateOfOrder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateOfPickUp {
            get {
                return this.DateOfPickUpField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfPickUpField, value) != true)) {
                    this.DateOfPickUpField = value;
                    this.RaisePropertyChanged("DateOfPickUp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReferenceNo {
            get {
                return this.ReferenceNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceNoField, value) != true)) {
                    this.ReferenceNoField = value;
                    this.RaisePropertyChanged("ReferenceNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalAmountField, value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MadeToOrder", Namespace="http://schemas.datacontract.org/2004/07/SalesOrderWebSvc")]
    [System.SerializableAttribute()]
    public partial class MadeToOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfOrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfPickUpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfUseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double DownpaymentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PurposeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionIdField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfOrder {
            get {
                return this.DateOfOrderField;
            }
            set {
                if ((this.DateOfOrderField.Equals(value) != true)) {
                    this.DateOfOrderField = value;
                    this.RaisePropertyChanged("DateOfOrder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfPickUp {
            get {
                return this.DateOfPickUpField;
            }
            set {
                if ((this.DateOfPickUpField.Equals(value) != true)) {
                    this.DateOfPickUpField = value;
                    this.RaisePropertyChanged("DateOfPickUp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfUse {
            get {
                return this.DateOfUseField;
            }
            set {
                if ((this.DateOfUseField.Equals(value) != true)) {
                    this.DateOfUseField = value;
                    this.RaisePropertyChanged("DateOfUse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Downpayment {
            get {
                return this.DownpaymentField;
            }
            set {
                if ((this.DownpaymentField.Equals(value) != true)) {
                    this.DownpaymentField = value;
                    this.RaisePropertyChanged("Downpayment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Purpose {
            get {
                return this.PurposeField;
            }
            set {
                if ((object.ReferenceEquals(this.PurposeField, value) != true)) {
                    this.PurposeField = value;
                    this.RaisePropertyChanged("Purpose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReferenceNo {
            get {
                return this.ReferenceNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceNoField, value) != true)) {
                    this.ReferenceNoField = value;
                    this.RaisePropertyChanged("ReferenceNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((this.TotalAmountField.Equals(value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionId {
            get {
                return this.TransactionIdField;
            }
            set {
                if ((this.TransactionIdField.Equals(value) != true)) {
                    this.TransactionIdField = value;
                    this.RaisePropertyChanged("TransactionId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderedProduct", Namespace="http://schemas.datacontract.org/2004/07/SalesOrderWebSvc")]
    [System.SerializableAttribute()]
    public partial class OrderedProduct : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ChestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClothTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderProdIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double WaistField;
        
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
        public double Chest {
            get {
                return this.ChestField;
            }
            set {
                if ((this.ChestField.Equals(value) != true)) {
                    this.ChestField = value;
                    this.RaisePropertyChanged("Chest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClothType {
            get {
                return this.ClothTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ClothTypeField, value) != true)) {
                    this.ClothTypeField = value;
                    this.RaisePropertyChanged("ClothType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Length {
            get {
                return this.LengthField;
            }
            set {
                if ((this.LengthField.Equals(value) != true)) {
                    this.LengthField = value;
                    this.RaisePropertyChanged("Length");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderProdId {
            get {
                return this.OrderProdIdField;
            }
            set {
                if ((this.OrderProdIdField.Equals(value) != true)) {
                    this.OrderProdIdField = value;
                    this.RaisePropertyChanged("OrderProdId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionId {
            get {
                return this.TransactionIdField;
            }
            set {
                if ((this.TransactionIdField.Equals(value) != true)) {
                    this.TransactionIdField = value;
                    this.RaisePropertyChanged("TransactionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Waist {
            get {
                return this.WaistField;
            }
            set {
                if ((this.WaistField.Equals(value) != true)) {
                    this.WaistField = value;
                    this.RaisePropertyChanged("Waist");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOWebSvcRef.ISOWebSvc")]
    public interface ISOWebSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetInfo", ReplyAction="http://tempuri.org/ISOWebSvc/GetInfoResponse")]
        CRSalesManagementSystem.SOWebSvcRef.Customer GetInfo(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetRentals", ReplyAction="http://tempuri.org/ISOWebSvc/GetRentalsResponse")]
        CRSalesManagementSystem.SOWebSvcRef.CRental[] GetRentals(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetSales", ReplyAction="http://tempuri.org/ISOWebSvc/GetSalesResponse")]
        CRSalesManagementSystem.SOWebSvcRef.CSales[] GetSales(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetOrders", ReplyAction="http://tempuri.org/ISOWebSvc/GetOrdersResponse")]
        CRSalesManagementSystem.SOWebSvcRef.COrder[] GetOrders(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/SaveCustomer", ReplyAction="http://tempuri.org/ISOWebSvc/SaveCustomerResponse")]
        bool SaveCustomer(CRSalesManagementSystem.SOWebSvcRef.Customer cust);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/UpdateCustomer", ReplyAction="http://tempuri.org/ISOWebSvc/UpdateCustomerResponse")]
        bool UpdateCustomer(CRSalesManagementSystem.SOWebSvcRef.Customer cust);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetTransactionInfo", ReplyAction="http://tempuri.org/ISOWebSvc/GetTransactionInfoResponse")]
        CRSalesManagementSystem.SOWebSvcRef.MadeToOrder GetTransactionInfo(int transactionid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetInfoByRefNum", ReplyAction="http://tempuri.org/ISOWebSvc/GetInfoByRefNumResponse")]
        CRSalesManagementSystem.SOWebSvcRef.MadeToOrder GetInfoByRefNum(string referenceno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetCustomerOfTransId", ReplyAction="http://tempuri.org/ISOWebSvc/GetCustomerOfTransIdResponse")]
        CRSalesManagementSystem.SOWebSvcRef.Customer GetCustomerOfTransId(int transactionid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetProductOfTransId", ReplyAction="http://tempuri.org/ISOWebSvc/GetProductOfTransIdResponse")]
        CRSalesManagementSystem.SOWebSvcRef.OrderedProduct GetProductOfTransId(int transactionid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/SaveTransaction", ReplyAction="http://tempuri.org/ISOWebSvc/SaveTransactionResponse")]
        bool SaveTransaction(CRSalesManagementSystem.SOWebSvcRef.MadeToOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/UpdateTransaction", ReplyAction="http://tempuri.org/ISOWebSvc/UpdateTransactionResponse")]
        bool UpdateTransaction(CRSalesManagementSystem.SOWebSvcRef.MadeToOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/GetOrderedProductInfo", ReplyAction="http://tempuri.org/ISOWebSvc/GetOrderedProductInfoResponse")]
        CRSalesManagementSystem.SOWebSvcRef.OrderedProduct GetOrderedProductInfo(int transactionid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/SaveOrderedProductInfo", ReplyAction="http://tempuri.org/ISOWebSvc/SaveOrderedProductInfoResponse")]
        bool SaveOrderedProductInfo(CRSalesManagementSystem.SOWebSvcRef.OrderedProduct op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOWebSvc/UpdateOrderedProductInfo", ReplyAction="http://tempuri.org/ISOWebSvc/UpdateOrderedProductInfoResponse")]
        bool UpdateOrderedProductInfo(CRSalesManagementSystem.SOWebSvcRef.OrderedProduct op);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISOWebSvcChannel : CRSalesManagementSystem.SOWebSvcRef.ISOWebSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SOWebSvcClient : System.ServiceModel.ClientBase<CRSalesManagementSystem.SOWebSvcRef.ISOWebSvc>, CRSalesManagementSystem.SOWebSvcRef.ISOWebSvc {
        
        public SOWebSvcClient() {
        }
        
        public SOWebSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SOWebSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOWebSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOWebSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.Customer GetInfo(int customerid) {
            return base.Channel.GetInfo(customerid);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.CRental[] GetRentals(int customerid) {
            return base.Channel.GetRentals(customerid);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.CSales[] GetSales(int customerid) {
            return base.Channel.GetSales(customerid);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.COrder[] GetOrders(int customerid) {
            return base.Channel.GetOrders(customerid);
        }
        
        public bool SaveCustomer(CRSalesManagementSystem.SOWebSvcRef.Customer cust) {
            return base.Channel.SaveCustomer(cust);
        }
        
        public bool UpdateCustomer(CRSalesManagementSystem.SOWebSvcRef.Customer cust) {
            return base.Channel.UpdateCustomer(cust);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.MadeToOrder GetTransactionInfo(int transactionid) {
            return base.Channel.GetTransactionInfo(transactionid);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.MadeToOrder GetInfoByRefNum(string referenceno) {
            return base.Channel.GetInfoByRefNum(referenceno);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.Customer GetCustomerOfTransId(int transactionid) {
            return base.Channel.GetCustomerOfTransId(transactionid);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.OrderedProduct GetProductOfTransId(int transactionid) {
            return base.Channel.GetProductOfTransId(transactionid);
        }
        
        public bool SaveTransaction(CRSalesManagementSystem.SOWebSvcRef.MadeToOrder order) {
            return base.Channel.SaveTransaction(order);
        }
        
        public bool UpdateTransaction(CRSalesManagementSystem.SOWebSvcRef.MadeToOrder order) {
            return base.Channel.UpdateTransaction(order);
        }
        
        public CRSalesManagementSystem.SOWebSvcRef.OrderedProduct GetOrderedProductInfo(int transactionid) {
            return base.Channel.GetOrderedProductInfo(transactionid);
        }
        
        public bool SaveOrderedProductInfo(CRSalesManagementSystem.SOWebSvcRef.OrderedProduct op) {
            return base.Channel.SaveOrderedProductInfo(op);
        }
        
        public bool UpdateOrderedProductInfo(CRSalesManagementSystem.SOWebSvcRef.OrderedProduct op) {
            return base.Channel.UpdateOrderedProductInfo(op);
        }
    }
}
