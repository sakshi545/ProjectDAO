//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectDAO
{
    using System;
    
    public partial class procViewPendingLeaveRequests_Result
    {
        public int LeaveID { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Remaining_leaves { get; set; }
        public Nullable<int> Alloted_Leaves { get; set; }
    }
}
