using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SalesOrderWebSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISOWebSvc" in both code and config file together.
    [ServiceContract]
    public interface ISOWebSvc
    {

        [OperationContract]
        Customer GetInfo(int customerid);

        [OperationContract]
        List<CRental> GetRentals(int customerid);

        [OperationContract]
        List<CSales> GetSales(int customerid);

        [OperationContract]
        List<COrder> GetOrders(int customerid);

        [OperationContract]
        bool SaveCustomer(Customer cust);

        [OperationContract]
        bool UpdateCustomer(Customer cust);

        [OperationContract]
        MadeToOrder GetTransactionInfo(int transactionid);

        [OperationContract]
        MadeToOrder GetInfoByRefNum(string referenceno);

        [OperationContract]
        Customer GetCustomerOfTransId(int transactionid);

        [OperationContract]
        OrderedProduct GetProductOfTransId(int transactionid);

        [OperationContract]
        bool SaveTransaction(MadeToOrder order);

        [OperationContract]
        bool UpdateTransaction(MadeToOrder order);

        [OperationContract]
        OrderedProduct GetOrderedProductInfo(int transactionid);

        [OperationContract]
        bool SaveOrderedProductInfo(OrderedProduct op);

        [OperationContract]
        bool UpdateOrderedProductInfo(OrderedProduct op);
        
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Customer
    {

        private int _customerId;
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _contactNo;

        [DataMember]
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [DataMember]
        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

    }

    [DataContract]
    public class CRental
    {

        private string _referenceNo;
        private string _dateOfRent;
        private string _dateOfPickUp;
        private string _totalAmount;

        [DataMember]
        public string ReferenceNo
        {
            get { return _referenceNo; }
            set { _referenceNo = value; }
        }

        [DataMember]
        public string DateOfRent
        {
            get { return _dateOfRent; }
            set { _dateOfRent = value; }
        }

        [DataMember]
        public string DateOfPickUp
        {
            get { return _dateOfPickUp; }
            set { _dateOfPickUp = value; }
        }

        [DataMember]
        public string TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }


    }

    [DataContract]
    public class CSales
    {

        private string _referenceNo;
        private string _dateOfPurchase;
        private string _totalAmount;

        [DataMember]
        public string ReferenceNo
        {
            get { return _referenceNo; }
            set { _referenceNo = value; }
        }

        [DataMember]
        public string DateOfPurchase
        {
            get { return _dateOfPurchase; }
            set { _dateOfPurchase = value; }
        }

        [DataMember]
        public string TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
    }

    [DataContract]
    public class COrder
    {

        private string _referenceNo;
        private string _dateOfOrder;
        private string _dateOfPickUp;
        private string _totalAmount;

        [DataMember]
        public string ReferenceNo
        {
            get { return _referenceNo; }
            set { _referenceNo = value; }
        }

        [DataMember]
        public string DateOfOrder
        {
            get { return _dateOfOrder; }
            set { _dateOfOrder = value; }
        }

        [DataMember]
        public string DateOfPickUp
        {
            get { return _dateOfPickUp; }
            set { _dateOfPickUp = value; }
        }

        [DataMember]
        public string TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
    }

    [DataContract]
    public class MadeToOrder
    {
        private int _transactionId;
        private string _referenceNo;
        private int _customerId;
        private double _totalAmount;
        private double _downpayment;
        private string _notes;
        private DateTime _dateOfOrder;
        private DateTime _dateOfUse;
        private DateTime _dateOfPickUp;
        private string _purpose;
        

        [DataMember]
        public int TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }

        [DataMember]
        public string ReferenceNo
        {
            get { return _referenceNo; }
            set { _referenceNo = value; }
        }

        [DataMember]
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember]
        public Double TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        [DataMember]
        public Double Downpayment
        {
            get { return _downpayment; }
            set { _downpayment = value; }
        }

        [DataMember]
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        [DataMember]
        public DateTime DateOfOrder
        {
            get { return _dateOfOrder; }
            set { _dateOfOrder = value; }
        }

        [DataMember]
        public DateTime DateOfUse
        {
            get { return _dateOfUse; }
            set { _dateOfUse = value; }
        }

        [DataMember]
        public DateTime DateOfPickUp
        {
            get { return _dateOfPickUp; }
            set { _dateOfPickUp = value; }
        }

        [DataMember]
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }

    [DataContract]
    public class OrderedProduct
    {
        private int _transactionId;
        private int _orderProdId;
        private string _clothType;
        private string _details;
        private double _chest;
        private double _waist;
        private double _length;
        
        [DataMember]
        public int TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }

        [DataMember]
        public int OrderProdId
        {
            get { return _orderProdId; }
            set { _orderProdId = value; }
        }

        [DataMember]
        public string ClothType
        {
            get { return _clothType; }
            set { _clothType = value; }
        }

        [DataMember]
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        [DataMember]
        public double Chest
        {
            get { return _chest; }
            set { _chest = value; }
        }

        [DataMember]
        public double Waist
        {
            get { return _waist; }
            set { _waist = value; }
        }

        [DataMember]
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

    }
}
