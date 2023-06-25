using OganiMaster.MVC.DAL.Entities;

namespace OganiMaster.MVC.ViewModels
{
    public class ContactViewModel
    {
        public List<Department>? Departments { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}
