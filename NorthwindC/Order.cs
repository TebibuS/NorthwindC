//Tebibu Solomon
//8/26/2022
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Order
    {
        //class variables
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = -1;
        private double freight = 0;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        //gets and sets
        // public properties
        // encapsulation
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {

                    this.orderId = value;
                }
                else
                {
                    this.orderId = 0;
                }
            }
        }
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0;
                }
            }
        }
        public string OrderDate
        {

            get { return this.orderDate; }
            set { this.orderDate = value; }
        }
        public string RequiredDate
        {

            get { return this.requiredDate; }
            set { this.requiredDate = value; }
        }
        public string ShippedDate
        {

            get { return this.shippedDate; }
            set { this.shippedDate = value; }
        }
        public int ShipVia
        {

            get { return this.shipVia; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {

                    this.shipVia = value;
                }
                else
                {

                    this.shipVia = 0;
                }
            }

        }
        public double Freight
        {
            get { return this.freight; }
            set
            {

                //must be greater than or equal to 0
                if (value >= 0)
                {
                    this.freight = (int)value;
                }
                else
                {

                    this.freight = 0;
                }
            }
        }
        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }
        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }
        public string ShipCity
        {

            get { return this.shipCity; }
            set { this.shipCity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }


        public Order() : this(-1, "n/a", -1, "n/a", "n/a", "n/a", -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")

        {

            // Empty Constructor


        }
        // Methods
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aShipName,
            string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)



        {

            this.OrderId = aOrderId;
            this.CustomerId = aCustomerId;
            this.EmployeeId = aEmployeeId;
            this.OrderDate = aOrderDate;
            this.RequiredDate = aRequiredDate;
            this.ShippedDate = aShippedDate;
            this.ShipVia = aShipVia;
            this.Freight = aFreight;
            this.ShipName = aShipName;
            this.ShipAddress = aShipAddress;
            this.ShipCity = aShipCity;
            this.ShipRegion = aShipRegion;
            this.ShipPostalCode = aShipPostalCode;
            this.ShipCountry = aShipCountry;
        }
            

        // Methods Go Here
        public override string ToString()
        {
            string message = "";
            message = message + "OrderId: " + this.OrderId + "\n";
            message = message + "CustomerId: " + this.CustomerId + "\n";
            message = message + "EmployeeId: " + this.EmployeeId + "\n";
            message = message + "OrderDate: " + this.OrderDate + "\n";
            message = message + "RequiredDate: " + this.RequiredDate + "\n";
            message = message + "ShippedDate: " + this.ShippedDate + "\n";
            message = message + "ShipVia: " + this.ShipVia + "\n";
            message = message + "Freight: " + this.Freight + "\n";
            message = message + "ShipName: " + this.ShipName + "\n";
            message = message + "ShipAddress: " + this.ShipAddress + "\n";
            message = message + "ShipCity: " + this.ShipCity + "\n";
            message = message + "ShipRegion: " + this.ShipRegion + "\n";
            message = message + "ShipPostalCode: " + this.ShipPostalCode + "\n";
            message = message + "ShipCountry: " + this.ShipCountry + "\n";
            return message;



        }




















    }


}
