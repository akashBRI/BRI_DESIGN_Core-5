using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class EmployeeViewModel
    {
        public string id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string teamId { get; set; }
        public string sharedSettingsId { get; set; }
        public string accountId { get; set; }
        public string identifier { get; set; }
        public string type { get; set; }
        public string organizationId { get; set; }
        public List<object> projects { get; set; }
        public long deactivated { get; set; }
        public long invited { get; set; }
        public long createdAt { get; set; }
    }
}
