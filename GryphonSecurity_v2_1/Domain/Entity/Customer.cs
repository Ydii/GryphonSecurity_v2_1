﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryphonSecurity_v2_1.Domain.Entity
{
    public class Customer
    {
        String customerName;
        long customerNumber;
        String streetHouseNumber;
        int zipCode;
        String city;
        long phonenumber;
        String zone;

        public Customer(String customerName, long customerNumber, String streetHouseNumber, int zipCode, String city, long phonenumber, String zone)
        {
            this.customerName = customerName;
            this.customerNumber = customerNumber;
            this.streetHouseNumber = streetHouseNumber;
            this.zipCode = zipCode;
            this.city = city;
            this.phonenumber = phonenumber;
            this.zone = zone;
        }

        public String CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public long CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }

        public String StreetHouseNumber
        {
            get { return streetHouseNumber; }
            set { streetHouseNumber = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public String City
        {
            get { return city; }
            set { city = value; }
        }

        public long Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public String Zone
        {
            get { return zone; }
            set { zone = value; }
        }
    }
}
