using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net9sample
{
    public class ViewModel
    {
        public string ColumnName { get; set; } = "CustomerName";

        public string Text { get; set; } = "Order Shipment Details";
        public string MappingName { get; set; } = "SalesDetails";

        public ObservableCollection<Model> _orders;
        //public ObservableCollection<string> CustomerNames { get; set; }
        public ObservableCollection<Model> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public Command TapCommand
        {
            get; set;
        }

        public ObservableCollection<string> CustomerNames { get; set; }
        public ViewModel()
        {
            Orders = new ObservableCollection<Model>();
            this.GenerateOrder();

        }


        public void GenerateOrder()
        {

            _orders.Add(new Model(1, "OID1001", "CID7001", false, "San", "India", "Chennai", true, new DateTime(2024, 07, 16), 23500, 32999));
            _orders.Add(new Model(1, "OID1001", "CID7001", false, "Sandy", "India", "Chennai", true, new DateTime(2024, 07, 16), 23500, 32999));
            _orders.Add(new Model(1, "OID1001", "CID7001", false, "Ben Stokes", "England", "Chennai", true, new DateTime(2024, 07, 16), 23500, 32999));
            _orders.Add(new Model(1, "OID1001", "CID7001", false, "Steve rodgers", "India", "Chennai", true, new DateTime(2024, 07, 16), 23500, 32999));
            _orders.Add(new Model(2, "OID1002", "CID7002", false, "Santa", "USA", "London", true, new DateTime(2024, 03, 06), 12345, 59999));
            _orders.Add(new Model(3, "OID1003", "CID7003", false, "Shyam", "India", "Mumbai", false, new DateTime(2022, 07, 26), 12450, 12999));
            _orders.Add(new Model(4, "OID1004", "CID7004", false, "Tameem", "India", "Chennai", true, new DateTime(2024, 07, 07), 19999, 29999));

            //_orders.Add(new Model(24, "OID1024", "image.png", "CID7024", false, "Bhairava", "India", "Chennai", true, new DateTime(2024, 12, 16), 21500, 22300));
            //_orders.Add(new Model(25, "OID1025", "dotnet_bot.png", "CID7025", false, "Sundar", "India", "Kerala", false, new DateTime(2024, 03, 26), 28999, 14500));
            //_orders.Add(new Model(26, "OID1026", "imagetwo.png", "CID7026", false, "Vetri", "India", "Goa", true, new DateTime(2024, 07, 06), 20999, 43200));
            //_orders.Add(new Model(27, "OID1027", "image.png", "CID7027", false, "Maaran", "India", "Chennai", true, new DateTime(2024, 09, 03), 34231, 23222));
            //_orders.Add(new Model(28, "OID1028", "imagetwo.png", "CID7028", false, "Joseph", "India", "Chennai", false, new DateTime(2024, 12, 29), 25400, 3000));

        }

        public void ItemsSourceRefresh()
        {
            _orders.Add(new Model(5, "OID1005", "CID7005", false, "Mani", "India", "Hydrabad", true, new DateTime(2024, 07, 16), 32121, 21121));
            _orders.Add(new Model(6, "OID1006", "CID7006", false, "Anandh", "India", "Chennai", false, new DateTime(2024, 04, 12), 21231, 43212));
            _orders.Add(new Model(7, "OID1007", "CID7007", false, "Sudarson", "India", "Goa", true, new DateTime(2024, 09, 11), 21122, 12134));
            _orders.Add(new Model(8, "OID1008", "CID7008", false, "Dhoni", "India", "Chennai", false, new DateTime(2024, 10, 16), 44398, 12543));
            _orders.Add(new Model(9, "OID1009", "CID7009", false, "Peter", "USA", "Queens", true, new DateTime(2024, 11, 10), 15000, 12000));
            _orders.Add(new Model(10, "OID1010", "CID7010", false, "Anandh", "USA", "Briain", false, new DateTime(2024, 07, 16), 25100, 4899));
            _orders.Add(new Model(11, "OID1011", "CID7011", false, "Guru", "India", "Chennai", true, new DateTime(2024, 07, 16), 19500, 21500));
            _orders.Add(new Model(12, "OID1012", "CID7012", false, "Abraham", "India", "Delhi", false, new DateTime(2024, 07, 16), 30100, 21000));
            _orders.Add(new Model(13, "OID1013", "CID7013", false, "Arun", "America", "Gotham", true, new DateTime(2024, 02, 16), 14230, 31999));
            _orders.Add(new Model(14, "OID1014", "CID7014", false, "Abraham", "India", "Chennai", true, new DateTime(2024, 09, 16), 30100, 21000));
            _orders.Add(new Model(15, "OID1015", "CID7015", false, "Abraham", "India", "Chennai", false, new DateTime(2024, 10, 16), 30100, 11222));
            _orders.Add(new Model(16, "OID1016", "CID7016", false, "Senthil", "India", "Chennai", true, new DateTime(2024, 12, 16), 21500, 22300));
            _orders.Add(new Model(17, "OID1017", "CID7017", false, "Rio", "India", "Kerala", false, new DateTime(2024, 03, 26), 28999, 14500));
            _orders.Add(new Model(18, "OID1018", "CID7018", false, "Kishore", "India", "Goa", true, new DateTime(2024, 07, 06), 10100, 43200));
            _orders.Add(new Model(19, "OID1019", "CID7019", false, "Tippu", "India", "Chennai", true, new DateTime(2024, 09, 03), 10100, 23222));
            _orders.Add(new Model(20, "OID1020", "CID7020", false, "Vicky", "India", "Chennai", false, new DateTime(2024, 12, 29), 35400, 3000));
            _orders.Add(new Model(21, "OID1021", "CID7021", false, "Rahul", "India", "Lucknow", true, new DateTime(2024, 02, 16), 14230, 21999));
            _orders.Add(new Model(22, "OID1022", "CID7022", false, "Arjun", "India", "Chennai", true, new DateTime(2024, 09, 16), 10100, 21000));
            _orders.Add(new Model(23, "OID1023", "CID7023", false, "Abraham", "India", "Chennai", false, new DateTime(2024, 10, 16), 29000, 20122));
        }

    }
}
