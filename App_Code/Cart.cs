using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class Cart
    {
        private int id;
        private int phoneId;
        private int quantity;
        private double price;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int PhoneId
        {
            get
            {
                return phoneId;
            }

            set
            {
                phoneId = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
