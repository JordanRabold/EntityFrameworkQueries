using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;

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
    }
}