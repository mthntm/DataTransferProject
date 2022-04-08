using DataTransferProject.MssqlModels;
using DataTransferProject.PostresqlModels;
using System;
using System.Linq;

namespace DataTransferProject
{
    class Program
    {
        static StockContext contextMssql = new StockContext();
        static PostgresqlContext contextPostgresql = new PostgresqlContext();

        static void Main(string[] args)
        {
            GetCategory();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetCurrency();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetCustomerGroup();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetCustomerCompany();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetCustomerStation();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetDeviceReader();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetGsm();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetStock();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetPackage();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetTasks();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            GetUsers();
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("------------");

            AddCategory();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddCurrency();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddCustomerGroup();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddCustomerCompany();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddCustomerStation();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddDeviceReader();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddGsm();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddStock();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddPackage();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddTasks();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------");
            AddUsers();
            Console.ReadLine();
        }
        public static void GetCategory()
        {
            var categoryList = contextMssql.Category.ToList();
            foreach (var item in categoryList)
            {
                Console.WriteLine(item.CategoryName);
            }
        }
        public static void AddCategory()
        {
            var Postgresql = new PostresqlModels.Category();
            var categoryList = contextMssql.Category.ToList();
            foreach (var item in categoryList)
            {
                Postgresql.CategoryId = item.CategoryId;
                Postgresql.CategoryName = item.CategoryName;
                Postgresql.ItemInStock = item.ItemInStock;
                Postgresql.ProductInThePackage = item.ProductInThePackage;
                contextPostgresql.Category.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Categories Added");
        }
        public static void GetCurrency()
        {
            var CurrencList = contextMssql.DboCurrency.ToList();
            foreach (var item in CurrencList)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void AddCurrency()
        {
            var Postgresql = new PostresqlModels.Currency();
            var currencyList = contextMssql.DboCurrency.ToList();
            foreach (var item in currencyList)
            {
                Postgresql.CurrencyId = item.CurrencyId;
                Postgresql.Name = item.Name;
                contextPostgresql.Currency.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Currency added");
        }
        public static void GetCustomerGroup()
        {
            var CustomerGroupList = contextMssql.CustomerGroup.ToList();
            foreach (var item in CustomerGroupList)
            {
                Console.WriteLine(item.GroupName);
            }
        }
        public static void AddCustomerGroup()
        {
            var Postgresql = new PostresqlModels.CustomerGroup();
            var CustomerGroupList = contextMssql.CustomerGroup.ToList();
            foreach (var item in CustomerGroupList)
            {
                Postgresql.GroupId = item.GroupId;
                Postgresql.GroupName = item.GroupName;
                contextPostgresql.CustomerGroup.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Groups Added");
        }
        public static void GetCustomerCompany()
        {
            var CustomerCompanyList = contextMssql.CustomerCompany.ToList();
            foreach (var item in CustomerCompanyList)
            {
                Console.WriteLine(item.CompanyName);
            }
        }
        public static void AddCustomerCompany()
        {
            var Postgresql = new PostresqlModels.CustomerCompany();
            var CustomerCompanyList = contextMssql.CustomerCompany.ToList();
            foreach (var item in CustomerCompanyList)
            {
                Postgresql.CompanyId = item.CompanyId;
                Postgresql.CompanyName = item.CompanyName;
                Postgresql.Group = item.Group;
                contextPostgresql.CustomerCompany.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Companies Added");
        }
        public static void GetCustomerStation()
        {
            var CustomerStationList = contextMssql.CustomerStation.ToList();
            foreach (var item in CustomerStationList)
            {
                Console.WriteLine(item.StationName);
            }
        }
        public static void AddCustomerStation()
        {
            var Postgresql = new PostresqlModels.CustomerStation();
            var CustomerStationList = contextMssql.CustomerStation.ToList();
            foreach (var item in CustomerStationList)
            {
                Postgresql.StationId = item.StationId;
                Postgresql.StationName = item.StationName;
                Postgresql.Company = item.Company;
                Postgresql.StationOfficer = item.StationOfficer;
                Postgresql.Contact = item.Contact;
                Postgresql.PowerPlant = item.PowerPlant;
                contextPostgresql.CustomerStation.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Stations have been added");
        }

        public static void GetDeviceReader()
        {
            var DeviceReaderList = contextMssql.DeviceReader.ToList();
            foreach (var item in DeviceReaderList)
            {
                Console.WriteLine(item.DeviceReaderName);
            }
        }
        public static void AddDeviceReader()
        {
            var Postgresql = new PostresqlModels.DeviceReader();
            var DeviceReaderList = contextMssql.DeviceReader.ToList();
            foreach (var item in DeviceReaderList)
            {
                Postgresql.Id = item.Id;
                Postgresql.DeviceReaderName = item.DeviceReaderName;
                contextPostgresql.DeviceReader.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Added Device Readers");
        }
        public static void GetGsm()
        {
            var GsmList = contextMssql.Gsm.ToList();
            foreach (var item in GsmList)
            {
                Console.WriteLine(item.GsmNumber);
            }
        }
        public static void AddGsm()
        {
            var Postgresql = new PostresqlModels.Gsm();
            var GsmList = contextMssql.Gsm.ToList();
            foreach (var item in GsmList)
            {
                Postgresql.GsmId = item.GsmId;
                Postgresql.GsmNumber = item.GsmNumber;
                Postgresql.GsmLocation = item.GsmLocation;
                Postgresql.GsmQuota = item.GsmQuota;
                Postgresql.GsmCompany = item.GsmCompany;
                Postgresql.StationName = item.StationName;
                contextPostgresql.Gsm.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Added Gsms");
        }
        public static void GetStock()
        {
            var StockList = contextMssql.Stock.ToList();
            foreach (var item in StockList)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        public static void AddStock()
        {
            var Postgresql = new PostresqlModels.Stock();
            var StockList = contextMssql.Stock.ToList();
            foreach (var item in StockList)
            {
                Postgresql.ProductId = item.ProductId;
                Postgresql.ProductName = item.ProductName;
                Postgresql.Brand = item.Brand;
                Postgresql.Category = item.Category;
                Postgresql.Price = item.Price;
                Postgresql.DateOfPurchase = item.DateOfPurchase;
                Postgresql.Status = item.Status;
                Postgresql.StockSerialNo = item.StockSerialNo;
                Postgresql.PackageNo = item.PackageNo;
                Postgresql.CurrencyType = item.CurrencyType;
                Postgresql.Explanation = item.Explanation;
                contextPostgresql.Stock.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Stocks Added");
        }
        public static void GetPackage()
        {
            var customerCompanyList = contextMssql.Package.ToList();
            foreach (var item in customerCompanyList)
            {
                Console.WriteLine(item.PackageNo);
            }
        }
        public static void AddPackage()
        {
            var Postgresql = new PostresqlModels.Package();
            var PackageList = contextMssql.Package.ToList();
            foreach (var item in PackageList)
            {
                Postgresql.Id = item.Id;
                Postgresql.PackageNo = item.PackageNo;
                Postgresql.CustomerId = item.CustomerId;
                Postgresql.DeviceReaderId = item.DeviceReaderId;
                Postgresql.SellingDate = item.SellingDate;
                Postgresql.CargoNumber = item.CargoNumber;
                Postgresql.IsActive = item.IsActive;
                contextPostgresql.Package.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Packages Added");
        }
        public static void GetTasks()
        {
            var TasksList = contextMssql.Tasks.ToList();
            foreach (var item in TasksList)
            {
                Console.WriteLine(item.TaskDescription);
            }
        }
        public static void AddTasks()
        {
            var Postgresql = new PostresqlModels.Tasks();
            var TasksList = contextMssql.Tasks.ToList();
            foreach (var item in TasksList)
            {
                Postgresql.TaskId = item.TaskId;
                Postgresql.TaskDescription = item.TaskDescription;
                Postgresql.Date = item.Date;
                contextPostgresql.Tasks.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("Missions Added");
        }
        public static void GetUsers()
        {
            var UsersList = contextMssql.Users.ToList();
            foreach (var item in UsersList)
            {
                Console.WriteLine(item.UserName);
            }
        }
        public static void AddUsers()
        {
            var Postgresql = new PostresqlModels.Users();
            var UsersList = contextMssql.Users.ToList();
            foreach (var item in UsersList)
            {
                Postgresql.Id = item.Id;
                Postgresql.UserName = item.UserName;
                Postgresql.Password = item.Password;
                Postgresql.Role = item.Role;
                contextPostgresql.Users.Add(Postgresql);
                contextPostgresql.SaveChanges();
            }
            Console.WriteLine("User added");
        }
    }
}
