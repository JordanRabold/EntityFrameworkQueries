using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SELECT Query
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

        // WHERE Query 
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

        // SELECT SPECIFIC COLUMNS Query
        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            // Anonymous type..creates new object containing select query
            // creates new list using VendorLocation class that we made
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

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            // Check if a vendor exists in Washington
            bool doesExist = (from v in dbContext.Vendors
                              where v.VendorState == "WA"
                              select v).Any();

            // Get number of Invoices
            int invoiceCount = (from invoice in dbContext.Invoices
                               select invoice).Count();

            // query a simgle vendor
            Vendor singleVendor = (from v in dbContext.Vendors
                                   where v.VendorName == "IBM"
                                   select v).Single();

            if(singleVendor != null)
            {
                // Do something with the vendor object
            }
        }

        // JOIN Query 
        private void btnVendorsAndInvoices_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            // Vendors LEFT JOIN Invoices
            List<Vendor> allVendors = dbContext.Vendors.Include(v => v.Invoices).ToList();

            // Unfinished code, this pulls a vendor object for each individual invoice, vendors
            // are also pulled back if they have no invoices
           /* List<Vendor> allVendors = (from v in dbContext.Vendors
                                      join inv in dbContext.Invoices
                                        on v.VendorId equals inv.VendorId  into grouping
                                      from inv in grouping.DefaultIfEmpty()
                                      select v).ToList();*/

            StringBuilder results = new();
            foreach(Vendor v in allVendors)
            {
                results.Append(v.VendorName);
                foreach(Invoice inv in v.Invoices)
                {
                    results.Append(", " + inv.InvoiceNumber);
                }
                results.AppendLine();
            }

            MessageBox.Show(results.ToString());
        }
    }

    public class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorState { get; set; }

        public string VendorCity { get; set; }

    }
}