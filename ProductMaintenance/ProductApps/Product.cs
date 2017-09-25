﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;
       

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        public decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        public decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }
      
 

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
        

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
          
        }
        public void calTotalChargeAfterDelivery() {
            Delivery = TotalPayment + 25;
        }
        public void calTotalChargeAfterWrap()
        {
            Wrapping = TotalPayment + 25 + 5;
        }
    }
}
