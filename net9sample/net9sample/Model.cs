using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net9sample
{
    public class Model : INotifyPropertyChanged
    {
        public string OrderID { get; set; } = string.Empty;
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
        public bool IsShipped { get; set; }
        public bool IsCheck { get; set; }
        public DateTime ShippedDate { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double SNo { get; set; }

        private ImageSource? _empImage;

        public ImageSource? EmpImage
        {
            get { return this._empImage; }
            set
            {
                this._empImage = value;
                this.RaisePropertyChanged("EmpImage");
            }
        }
        public Model(double sNo, string orderID, string customerID, bool isCheck, string customerName, string shipCountry, string shipCity, bool isShipped, DateTime shippedDate, double price1, double price2)
        {
            SNo = sNo;
            OrderID = orderID;
            CustomerID = customerID;
            CustomerName = customerName;
            ShipCountry = shipCountry;
            ShipCity = shipCity;
            IsShipped = isShipped;
            IsCheck = isCheck;
            ShippedDate = shippedDate;
            Price1 = price1;
            Price2 = price2;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
