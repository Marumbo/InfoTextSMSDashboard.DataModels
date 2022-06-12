using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTextSMSDashboard.DataModels.Models
{
    public class GroupContactListDTO
    {
        public int? GroupContactId { get; set; }
        public int? GroupId { get; set; }
        public List<int> ContactIds { get; set; }
    }
}
