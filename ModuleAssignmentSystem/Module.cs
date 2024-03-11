using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAssignmentSystem
{
    public class Module
    {
        public string moduleCode { get; set; }
        public string moduleName { get; set; }
        public int totalHours { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Tutor tutor {  get; set; }
    }
}
