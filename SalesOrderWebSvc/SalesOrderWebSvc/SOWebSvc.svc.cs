using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;


namespace SalesOrderWebSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SOWebSvc" in code, svc and config file together.
    public class SOWebSvc : ISOWebSvc
    {
        private MySqlConnection _conn = new MySqlConnection("Server=localhost;port=3306;database=crsms_db;username=root;password=;pooling = false; convert zero datetime=True");
        private DataTable _dTable;
        private MySqlDataAdapter _dataAdapter;

        #region Customer

        public Customer GetInfo(int customerid)
        {
            Customer cust = new Customer();
            cust.CustomerId = customerid;

            try
            {
                _conn.Open();
                _dTable = new DataTable();
                _dataAdapter = new MySqlDataAdapter("SELECT * FROM customers WHERE customerid=?customerid;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?customerid", customerid);

                _dataAdapter.Fill(_dTable);

                //_customerId = Int32.Parse(_dTable.Rows[0]["customerid"].ToString());
                cust.FirstName = _dTable.Rows[0]["fname"].ToString();
                cust.LastName = _dTable.Rows[0]["lname"].ToString();
                cust.Address = _dTable.Rows[0]["address"].ToString();
                cust.ContactNo = _dTable.Rows[0]["contactno"].ToString();
            }

            catch (Exception e)
            {
                //MessageBox.Show("Customer does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }
            return cust;
        }

        public List<CRental> GetRentals(int customerid)
        {
            List<CRental> rentals = new List<CRental>();
            try
            {
                _conn.Open();
                _dTable = new DataTable();
                _dataAdapter = new MySqlDataAdapter("SELECT referenceno as 'Reference No.',DATE_FORMAT(date_of_rental,'%d %b %y') as 'Date of Rent',DATE_FORMAT(date_of_pickup,'%d %b %y') as 'Pick-up Date',total_amount as 'Amount' FROM rentals WHERE customerid=?customerid;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?customerid", customerid);

                _dataAdapter.Fill(_dTable);

                
                for(int i=0 ; i<_dTable.Rows.Count ; i++)
                {
                    CRental cr = new CRental();
                    cr.ReferenceNo = _dTable.Rows[i][0].ToString();
                    cr.DateOfRent = _dTable.Rows[i][1].ToString();
                    cr.DateOfPickUp = _dTable.Rows[i][2].ToString();
                    cr.TotalAmount = _dTable.Rows[i][3].ToString();
                    rentals.Add(cr);
                }

            }

            catch (Exception e)
            {
                //MessageBox.Show("Customer does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }
            return rentals;
        }

        public List<CSales> GetSales(int customerid)
        {
            List<CSales> sales = new List<CSales>();
            try
            {
                _conn.Open();
                _dTable = new DataTable();
                _dataAdapter = new MySqlDataAdapter("SELECT salesreference as 'Reference No.',DATE_FORMAT(date_of_purchase,'%d %b %y') as 'Date of Purchase',amount as 'Amount' FROM sales WHERE customerid=?customerid;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?customerid", customerid);

                _dataAdapter.Fill(_dTable);

                for (int i = 0; i < _dTable.Rows.Count; i++)
                {
                    CSales cs = new CSales();
                    cs.ReferenceNo = _dTable.Rows[i][0].ToString();
                    cs.DateOfPurchase = _dTable.Rows[i][1].ToString();
                    cs.TotalAmount = _dTable.Rows[i][3].ToString();
                    sales.Add(cs);
                }
            }

            catch (Exception e)
            {
                //MessageBox.Show("Customer does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }
            return sales;
        }

        public List<COrder> GetOrders(int customerid)
        {
            List<COrder> orders = new List<COrder>();
            try
            {
                _conn.Open();
                _dTable = new DataTable();
                _dataAdapter = new MySqlDataAdapter("SELECT refnum as 'Reference No.',DATE_FORMAT(date_of_order,'%d %b %y') as 'Date Ordered',DATE_FORMAT(date_of_pickup,'%d %b %y') as 'Pick-up Date',total_amount as 'Amount' FROM orders WHERE customerid=?customerid;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?customerid", customerid);

                _dataAdapter.Fill(_dTable);

                for (int i = 0; i < _dTable.Rows.Count; i++)
                {
                    COrder co = new COrder();
                    co.ReferenceNo = _dTable.Rows[i][0].ToString();
                    co.DateOfOrder = _dTable.Rows[i][1].ToString();
                    co.DateOfPickUp = _dTable.Rows[i][2].ToString();
                    co.TotalAmount = _dTable.Rows[i][3].ToString();
                    orders.Add(co);
                }
            }

            catch (Exception e)
            {
                //MessageBox.Show("Customer does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }
            return orders;
        }

        public bool SaveCustomer(Customer cust)
        {
            bool success = false;
            try
            {
                _conn.Open();

                //preparing statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "INSERT INTO customers(fname,lname,address,contactno) VALUES(?fname,?lname,?address,?contactno);";
                cmd.Prepare();

                //binding parameters
                cmd.Parameters.AddWithValue("?fname", cust.FirstName);
                cmd.Parameters.AddWithValue("?lname", cust.LastName);
                cmd.Parameters.AddWithValue("?address", cust.Address);
                cmd.Parameters.AddWithValue("?contactno", cust.ContactNo);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Customer Added!");
                success = true;

            }
            catch (MySqlException ex)
            {
                //Trace.WriteLine("Error: {0}", ex.ToString());
                //MessageBox.Show("Error occurred in saving the customer.");
            }
            finally
            {
                _conn.Close();
            }
            return success;
        }

        public bool UpdateCustomer(Customer cust)
        {
            bool success = false;
            try
            {
                _conn.Open();

                //preparing statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText =
                    "UPDATE customers SET fname=?fname,lname=?lname,address=?address,contactno=?contactno WHERE customerid=?customerid;";
                cmd.Prepare();

                //binding parameters
                cmd.Parameters.AddWithValue("?customerid", cust.CustomerId);
                cmd.Parameters.AddWithValue("?fname", cust.FirstName);
                cmd.Parameters.AddWithValue("?lname", cust.LastName);
                cmd.Parameters.AddWithValue("?address", cust.Address);
                cmd.Parameters.AddWithValue("?contactno", cust.ContactNo);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Updated Successfully!");
                success = true;

            }
            catch (MySqlException ex)
            {
                //Trace.WriteLine("Error: {0}", ex.ToString());
                //MessageBox.Show("Error occurred in updating the customer.");
            }
            finally
            {
                _conn.Close();
            }
            return success;
        }

        #endregion

        #region Orders

        public MadeToOrder GetTransactionInfo(int transactionid)
        {
            MadeToOrder order = new MadeToOrder();
            try
            {
                _conn.Open();
                _dataAdapter = new MySqlDataAdapter("SELECT * FROM orders WHERE ordernum=?ordernum;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?ordernum", transactionid);
                _dTable = new DataTable();
                _dataAdapter.Fill(_dTable);

                order.TransactionId = transactionid;
                order.ReferenceNo = _dTable.Rows[0]["refnum"].ToString();
                order.CustomerId = Int32.Parse(_dTable.Rows[0]["customerid"].ToString());
                order.DateOfOrder = DateTime.Parse(_dTable.Rows[0]["date_of_order"].ToString());
                order.DateOfUse = DateTime.Parse(_dTable.Rows[0]["date_of_use"].ToString());
                order.DateOfPickUp = DateTime.Parse(_dTable.Rows[0]["date_of_pickup"].ToString());
                order.Purpose = _dTable.Rows[0]["purpose"].ToString();
                order.TotalAmount = Double.Parse(_dTable.Rows[0]["total_amount"].ToString());
                order.Downpayment = Double.Parse(_dTable.Rows[0]["downpayment"].ToString());
                order.Notes = _dTable.Rows[0]["notes"].ToString();

            }

            catch (Exception e)
            {
                //MessageBox.Show("Order Transaction does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }

            return order;
        }

        public MadeToOrder GetInfoByRefNum(string referenceno)
        {
            MadeToOrder order = new MadeToOrder();
            try
            {
                _conn.Open();
                _dataAdapter = new MySqlDataAdapter("SELECT * from orders where refnum=?refnum;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?refnum", referenceno);
                _dTable = new DataTable();
                _dataAdapter.Fill(_dTable);

                order.TransactionId = Int32.Parse(_dTable.Rows[0]["ordernum"].ToString());
                order.ReferenceNo = _dTable.Rows[0]["refnum"].ToString();
                order.CustomerId = Int32.Parse(_dTable.Rows[0]["customerid"].ToString());
                order.DateOfOrder = DateTime.Parse(_dTable.Rows[0]["date_of_order"].ToString());
                order.DateOfUse = DateTime.Parse(_dTable.Rows[0]["date_of_use"].ToString());
                order.DateOfPickUp = DateTime.Parse(_dTable.Rows[0]["date_of_pickup"].ToString());
                order.Purpose = _dTable.Rows[0]["purpose"].ToString();
                order.TotalAmount = Double.Parse(_dTable.Rows[0]["total_amount"].ToString());
                order.Downpayment = Double.Parse(_dTable.Rows[0]["downpayment"].ToString());
                order.Notes = _dTable.Rows[0]["notes"].ToString();

            }


            catch (Exception e)
            {
                //MessageBox.Show("Order Transaction does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }

            return order;
        }

        public Customer GetCustomerOfTransId(int transactionid)
        {
            Customer cust = new Customer();
            try
            {
                _conn.Open();
                _dTable = new DataTable();
                _dataAdapter = new MySqlDataAdapter("SELECT customerid as 'ID',fname as 'First Name',lname as 'Last Name',address as 'Address',contactno as 'Contact No.' FROM customers WHERE customerid = (SELECT customerid FROM orders WHERE ordernum=?ordernum);", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?ordernum", transactionid);

                _dataAdapter.Fill(_dTable);

                cust.CustomerId = Int32.Parse(_dTable.Rows[0]["ID"].ToString());
                cust.FirstName = _dTable.Rows[0]["First Name"].ToString();
                cust.LastName = _dTable.Rows[0]["Last Name"].ToString();
                cust.Address = _dTable.Rows[0]["Address"].ToString();
                cust.ContactNo = _dTable.Rows[0]["Contact No."].ToString();
            }

            catch (Exception e)
            {
                //MessageBox.Show("Rent Transaction not found.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }
            return cust;
        }

        public OrderedProduct GetProductOfTransId(int transactionid)
        {
            OrderedProduct op = new OrderedProduct();
            try
            {
                _conn.Open();
                string stmt = "SELECT clothtype as 'Cloth', details as 'Details', chest as 'Chest', waist as 'Waist', overall_length as 'Length' ";
                stmt += "FROM orderedproducts WHERE ordernum=?ordernum;";
                _dataAdapter = new MySqlDataAdapter(stmt, _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?ordernum", transactionid);
                _dTable = new DataTable();
                _dataAdapter.Fill(_dTable);

                op.ClothType = _dTable.Rows[0]["Cloth"].ToString();
                op.Details = _dTable.Rows[0]["Details"].ToString();
                op.Chest = Double.Parse(_dTable.Rows[0]["Chest"].ToString());
                op.Waist = Double.Parse(_dTable.Rows[0]["Waist"].ToString());
                op.Length = Double.Parse(_dTable.Rows[0]["Length"].ToString());

            }

            catch (Exception e)
            {
                //MessageBox.Show("Order Transaction not found.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }

            return op;
        }


        public bool SaveTransaction(MadeToOrder order)
        {
            bool success = false;
            try
            {
                _conn.Open();

                //preparing statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;

                string stmt = "INSERT INTO orders(refnum,customerid,date_of_order,date_of_use,date_of_pickup,purpose,total_amount,downpayment,notes) ";
                stmt += "VALUES(?referenceno,?customerid,?dateoforder,?dateofuse,?dateofpickup,?purpose,?amount,?downpayment,?notes);";

                cmd.CommandText = stmt;
                cmd.Prepare();

                //binding parameters
                cmd.Parameters.AddWithValue("?referenceno", order.ReferenceNo);
                cmd.Parameters.AddWithValue("?customerid", order.CustomerId);
                cmd.Parameters.AddWithValue("?dateoforder", order.DateOfOrder);
                cmd.Parameters.AddWithValue("?dateofuse", order.DateOfUse);
                cmd.Parameters.AddWithValue("?dateofpickup", order.DateOfPickUp);
                cmd.Parameters.AddWithValue("?purpose", order.Purpose);
                cmd.Parameters.AddWithValue("?amount", order.TotalAmount);
                cmd.Parameters.AddWithValue("?downpayment", order.Downpayment);
                cmd.Parameters.AddWithValue("?notes", order.Notes);

                cmd.ExecuteNonQuery();

                success = true;
                //MessageBox.Show("Order Transaction Saved!");

            }
            catch (MySqlException ex)
            {
                //Trace.WriteLine("Error: {0}", ex.ToString());
                //MessageBox.Show("Error occurred in saving the transaction.");
            }
            finally
            {
                _conn.Close();
            }
            return success;
        }

        public bool UpdateTransaction(MadeToOrder order)
        {
            bool success = false;
            try
            {
                _conn.Open();

                //preparing statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;

                string stmt = "UPDATE orders SET ";
                stmt += "customerid=?customerid,";
                //stmt += "date_of_order=?dateoforder,";
                stmt += "date_of_use=?dateofuse,";
                stmt += "date_of_pickup=?dateofpickup,";
                stmt += "purpose=?purpose,";
                stmt += "total_amount=?amount,";
                stmt += "downpayment=?downpayment,";
                stmt += "notes=?notes ";
                stmt += "WHERE ordernum=?ordernum;";

                cmd.CommandText = stmt;
                cmd.Prepare();

                //binding parameters
                cmd.Parameters.AddWithValue("?ordernum", order.TransactionId);
                cmd.Parameters.AddWithValue("?customerid", order.CustomerId);
                //cmd.Parameters.AddWithValue("?dateoforder", _dateOfOrder);
                cmd.Parameters.AddWithValue("?dateofuse", order.DateOfUse);
                cmd.Parameters.AddWithValue("?dateofpickup", order.DateOfPickUp);
                cmd.Parameters.AddWithValue("?purpose", order.Purpose);
                cmd.Parameters.AddWithValue("?amount", order.TotalAmount);
                cmd.Parameters.AddWithValue("?downpayment", order.Downpayment);
                cmd.Parameters.AddWithValue("?notes", order.Notes);

                cmd.ExecuteNonQuery();

                success = true;
                //MessageBox.Show("Updated Successfully!");

            }
            catch (MySqlException ex)
            {
                //Trace.WriteLine("Error: {0}", ex.ToString());
                //MessageBox.Show("Error occurred in updating the transaction.");
            }
            finally
            {
                _conn.Close();
            }
            return success;
        }

        public OrderedProduct GetOrderedProductInfo(int transactionid)
        {
            OrderedProduct op = new OrderedProduct();
            try
            {
                _conn.Open();
                _dataAdapter = new MySqlDataAdapter("SELECT * FROM orderedproducts WHERE ordernum=?ordernum;", _conn);
                _dataAdapter.SelectCommand.Parameters.AddWithValue("?ordernum", transactionid);
                _dTable = new DataTable();
                _dataAdapter.Fill(_dTable);

                op.OrderProdId = Int32.Parse(_dTable.Rows[0]["orderprodid"].ToString());
                op.TransactionId = Int32.Parse(_dTable.Rows[0]["ordernum"].ToString());
                op.ClothType = _dTable.Rows[0]["clothtype"].ToString();
                op.Details = _dTable.Rows[0]["details"].ToString();
                op.Chest = Double.Parse(_dTable.Rows[0]["chest"].ToString());
                op.Waist = Double.Parse(_dTable.Rows[0]["waist"].ToString());
                op.Length = Double.Parse(_dTable.Rows[0]["overall_length"].ToString());
            }

            catch (Exception e)
            {
                //MessageBox.Show("Product does not exist.");
                //Trace.WriteLine("Error:" + e.Message);
            }

            finally
            {
                _conn.Close();
            }
            return op;
        }


        public bool SaveOrderedProductInfo(OrderedProduct op)
        {
            bool success = false;
            try
            {
                _conn.Open();

                //preparing statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;

                string stmt = "INSERT INTO orderedproducts(ordernum,clothtype,details,chest,waist,overall_length) ";
                stmt += "VALUES(?ordernum,?clothtype,?details,?chest,?waist,?length);";

                cmd.CommandText = stmt;
                cmd.Prepare();

                //binding parameters
                cmd.Parameters.AddWithValue("?ordernum", op.TransactionId);
                cmd.Parameters.AddWithValue("?clothtype", op.ClothType);
                cmd.Parameters.AddWithValue("?details", op.Details);
                cmd.Parameters.AddWithValue("?chest", op.Chest);
                cmd.Parameters.AddWithValue("?waist", op.Waist);
                cmd.Parameters.AddWithValue("?length", op.Length);

                cmd.ExecuteNonQuery();

                success = true;
                //MessageBox.Show("Product Added!");

            }
            catch (MySqlException ex)
            {
                //Trace.WriteLine("Error: {0}", ex.ToString());
                //MessageBox.Show("Error occurred in processing the order.");
            }
            finally
            {
                _conn.Close();
            }
            return success;
        }

        public bool UpdateOrderedProductInfo(OrderedProduct op)
        {
            bool success = false;
            try
            {
                _conn.Open();

                //preparing statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;

                string stmt = "UPDATE orderedproducts SET ";
                stmt += "clothtype=?clothtype,";
                stmt += "details=?details,";
                stmt += "chest=?chest,";
                stmt += "waist=?waist,";
                stmt += "overall_length=?length ";
                stmt += "WHERE ordernum=?ordernum;";

                cmd.CommandText = stmt;
                cmd.Prepare();

                //binding parameters
                cmd.Parameters.AddWithValue("?ordernum", op.TransactionId);
                cmd.Parameters.AddWithValue("?clothtype", op.ClothType);
                cmd.Parameters.AddWithValue("?details", op.Details);
                cmd.Parameters.AddWithValue("?chest", op.Chest);
                cmd.Parameters.AddWithValue("?waist", op.Waist);
                cmd.Parameters.AddWithValue("?length", op.Length);

                cmd.ExecuteNonQuery();

                success = true;
                //MessageBox.Show("Updated Successfully!");

            }
            catch (MySqlException ex)
            {
                //Trace.WriteLine("Error: {0}", ex.ToString());
                //MessageBox.Show("Error occurred in updating the product.");
            }
            finally
            {
                _conn.Close();
            }

            return success;
        }

        #endregion

    }
}
