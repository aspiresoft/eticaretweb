using System;

    public class Phone
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private string brand;
        private string os;
        private int memory;
        private double length;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
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

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public string Os
        {
            get
            {
                return os;
            }

            set
            {
                os = value;
            }
        }

        public int Memory
        {
            get
            {
                return memory;
            }

            set
            {
                memory = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }
    }