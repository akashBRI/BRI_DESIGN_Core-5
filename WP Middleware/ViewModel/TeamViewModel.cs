using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class TeamViewModel
    {
        public string id { get; set; }
        public bool ignoreProductive { get; set; }
        public bool ignoreNeutral { get; set; }
        public bool ignoreUnproductive { get; set; }
        public bool ignoreUnreviewed { get; set; }
        public string name { get; set; }
        public string organizationId { get; set; }
        public bool @default { get; set; }
        public List<string> employees { get; set; }
        public List<string> projects { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public string modelName { get; set; }
    }
}
