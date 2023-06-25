using OganiMaster.MVC.DAL.Entities;

namespace OganiMaster.MVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Shop>? Shops { get; set; }
        public List<Department>? Departments { get; set; }
    }
}
