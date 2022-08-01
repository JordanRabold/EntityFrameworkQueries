using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new APContext(); // use whenever you want to interact with database

            // get list of vendor objects
            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList(); // puts all vendors from DB into List<vendor>

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       select v).ToList();
        }

        private void btnWhereQuery_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new(); // use whenever you want to interact with database

            // LINQ query syntax
            List<Vendor> vendorList = dbContext.Vendors
                                               .Where(v => v.VendorState == "CA")
                                               .OrderBy(v => v.VendorName)
                                               .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       where v.VendorState == "CA"
                                       orderby v.VendorName
                                       select v).ToList();

        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            // Anonymous type..creates new object containing select query
            List<VendorLocation> results = (from v in dbContext.Vendors
                           select new VendorLocation
                           {
                               VendorName = v.VendorName,
                               VendorState = v.VendorState,
                               VendorCity = v.VendorCity
                           }).ToList();

            StringBuilder displayString = new StringBuilder();
            foreach(var vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }

            MessageBox.Show(displayString.ToString());
        }
    }

    public class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorState { get; set; }

        public string VendorCity { get; set; }

    }
}