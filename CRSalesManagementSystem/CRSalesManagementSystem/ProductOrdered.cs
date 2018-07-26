﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRSalesManagementSystem.SOWebSvcRef;

namespace CRSalesManagementSystem
{
    public partial class ProductOrdered : Form
    {
        MadeToOrder order;
        OrderedProduct op;
        string type;
        SOWebSvcClient sowebsvc;

        public ProductOrdered(MadeToOrder o,string todo)
        {
            InitializeComponent();
            order = o;
            //op = new OrderedProduct();
            type = todo;
            if (type == "edit")
            {
                //op.TransactionId = o.TransactionId;
                sowebsvc = new SOWebSvcClient();
                //op.GetProductInfo();
                op = sowebsvc.GetOrderedProductInfo(o.TransactionId);
                sowebsvc.Close();
            }
            else
            {
                op = new OrderedProduct();
            }
        }

        public bool isDone { get; private set; }


        private void btnPOSave_Click(object sender, EventArgs e)
        {
            if (txtPOCloth.Text == "")
            {
                MessageBox.Show("Please provide cloth type.");
            }
            else if (txtPODet.Text == "")
            {
                MessageBox.Show("Please provide the details of the product.");
            }
            else
            {
                sowebsvc = new SOWebSvcClient();
                if (type == "add")
                {
                    //saves order transaction
                    
                    sowebsvc.SaveTransaction(order);
                    //order.SaveTransaction();

                    //gets the rent id 
                    SelectList slist = new SelectList();
                    slist.GetMaxOrdersID();
                    DataRow oRow = slist.DTable.Rows[0];

                    //gets the order number
                    order.TransactionId = Int32.Parse(oRow["Max"].ToString());

                    //gets inputs
                    op.TransactionId = order.TransactionId;
                    op.ClothType = txtPOCloth.Text;
                    op.Details = txtPODet.Text;
                    op.Chest = Double.Parse(txtPOChest.Text);
                    op.Waist = Double.Parse(txtPOWaist.Text);
                    op.Length = Double.Parse(txtPOLength.Text);
                    //op.SaveInfo();
                    if(sowebsvc.SaveOrderedProductInfo(op))
                        MessageBox.Show("Transaction Complete!");
                }
                else
                {
                    //gets inputs
                    op.TransactionId = order.TransactionId;
                    op.ClothType = txtPOCloth.Text;
                    op.Details = txtPODet.Text;
                    op.Chest = Double.Parse(txtPOChest.Text);
                    op.Waist = Double.Parse(txtPOWaist.Text);
                    op.Length = Double.Parse(txtPOLength.Text);
                   // op.UpdateInfo();
                    if(sowebsvc.UpdateOrderedProductInfo(op))
                        MessageBox.Show("Ordered Product Updated!");
                }
                
                sowebsvc.Close();
                
                isDone = true;
                this.Close();

            }
        }

        private void ProductOrdered_Load(object sender, EventArgs e)
        {
            //loads the product details to the text boxes
            if (type == "edit")
            {
                txtPOCloth.Text = op.ClothType;
                txtPODet.Text = op.Details;
                txtPOChest.Text = op.Chest.ToString();
                txtPOWaist.Text = op.Waist.ToString();
                txtPOLength.Text = op.Length.ToString();

            }
        }
    }
}
