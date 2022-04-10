﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Sprint_dbEntities1 : DbContext
    {
        public Sprint_dbEntities1()
            : base("name=Sprint_dbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceRequest> AttendanceRequests { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Leaf> Leaves { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
    
        public virtual int prcEmployeeUpdate(Nullable<int> empID, string firstName, string lastName, string address, string contact, Nullable<int> status, Nullable<System.DateTime> dob, string gender, string designation, Nullable<System.DateTime> doj, Nullable<int> alloted_leaves, string eusername, string epassword)
        {
            var empIDParameter = empID.HasValue ?
                new ObjectParameter("EmpID", empID) :
                new ObjectParameter("EmpID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var designationParameter = designation != null ?
                new ObjectParameter("designation", designation) :
                new ObjectParameter("designation", typeof(string));
    
            var dojParameter = doj.HasValue ?
                new ObjectParameter("doj", doj) :
                new ObjectParameter("doj", typeof(System.DateTime));
    
            var alloted_leavesParameter = alloted_leaves.HasValue ?
                new ObjectParameter("alloted_leaves", alloted_leaves) :
                new ObjectParameter("alloted_leaves", typeof(int));
    
            var eusernameParameter = eusername != null ?
                new ObjectParameter("Eusername", eusername) :
                new ObjectParameter("Eusername", typeof(string));
    
            var epasswordParameter = epassword != null ?
                new ObjectParameter("Epassword", epassword) :
                new ObjectParameter("Epassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcEmployeeUpdate", empIDParameter, firstNameParameter, lastNameParameter, addressParameter, contactParameter, statusParameter, dobParameter, genderParameter, designationParameter, dojParameter, alloted_leavesParameter, eusernameParameter, epasswordParameter);
        }
    
        public virtual int procAddAdmin(string adminName, string address, string contact, Nullable<System.DateTime> dob, string gender, string designation, Nullable<System.DateTime> doj, string aUserName, string aPassword)
        {
            var adminNameParameter = adminName != null ?
                new ObjectParameter("adminName", adminName) :
                new ObjectParameter("adminName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(string));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var designationParameter = designation != null ?
                new ObjectParameter("designation", designation) :
                new ObjectParameter("designation", typeof(string));
    
            var dojParameter = doj.HasValue ?
                new ObjectParameter("doj", doj) :
                new ObjectParameter("doj", typeof(System.DateTime));
    
            var aUserNameParameter = aUserName != null ?
                new ObjectParameter("AUserName", aUserName) :
                new ObjectParameter("AUserName", typeof(string));
    
            var aPasswordParameter = aPassword != null ?
                new ObjectParameter("APassword", aPassword) :
                new ObjectParameter("APassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAddAdmin", adminNameParameter, addressParameter, contactParameter, dobParameter, genderParameter, designationParameter, dojParameter, aUserNameParameter, aPasswordParameter);
        }
    
        public virtual int procAddAttendance(Nullable<int> empId, Nullable<int> projectId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("projectId", projectId) :
                new ObjectParameter("projectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAddAttendance", empIdParameter, projectIdParameter);
        }
    
        public virtual int procAddEmployee(string firstName, string lastName, string address, string contact, Nullable<System.DateTime> dob, string gender, string designation, Nullable<System.DateTime> doj, Nullable<int> allLeaves, string eUsername, string password, Nullable<int> allotedProjectId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(string));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var designationParameter = designation != null ?
                new ObjectParameter("designation", designation) :
                new ObjectParameter("designation", typeof(string));
    
            var dojParameter = doj.HasValue ?
                new ObjectParameter("doj", doj) :
                new ObjectParameter("doj", typeof(System.DateTime));
    
            var allLeavesParameter = allLeaves.HasValue ?
                new ObjectParameter("allLeaves", allLeaves) :
                new ObjectParameter("allLeaves", typeof(int));
    
            var eUsernameParameter = eUsername != null ?
                new ObjectParameter("eUsername", eUsername) :
                new ObjectParameter("eUsername", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var allotedProjectIdParameter = allotedProjectId.HasValue ?
                new ObjectParameter("allotedProjectId", allotedProjectId) :
                new ObjectParameter("allotedProjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAddEmployee", firstNameParameter, lastNameParameter, addressParameter, contactParameter, dobParameter, genderParameter, designationParameter, dojParameter, allLeavesParameter, eUsernameParameter, passwordParameter, allotedProjectIdParameter);
        }
    
        public virtual int procAddLeave(Nullable<int> empid, string reason, Nullable<System.DateTime> dateTo, Nullable<System.DateTime> dateFrom)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            var reasonParameter = reason != null ?
                new ObjectParameter("reason", reason) :
                new ObjectParameter("reason", typeof(string));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("dateTo", dateTo) :
                new ObjectParameter("dateTo", typeof(System.DateTime));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("dateFrom", dateFrom) :
                new ObjectParameter("dateFrom", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAddLeave", empidParameter, reasonParameter, dateToParameter, dateFromParameter);
        }
    
        public virtual int procAddProject(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAddProject", titleParameter);
        }
    
        public virtual ObjectResult<procAllReadLeave_Result> procAllReadLeave()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procAllReadLeave_Result>("procAllReadLeave");
        }
    
        public virtual int procApproveAttendanceRequest(Nullable<int> attReqId)
        {
            var attReqIdParameter = attReqId.HasValue ?
                new ObjectParameter("attReqId", attReqId) :
                new ObjectParameter("attReqId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procApproveAttendanceRequest", attReqIdParameter);
        }
    
        public virtual int procApproveLeave(Nullable<int> leaveId)
        {
            var leaveIdParameter = leaveId.HasValue ?
                new ObjectParameter("leaveId", leaveId) :
                new ObjectParameter("leaveId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procApproveLeave", leaveIdParameter);
        }
    
        public virtual int procAssignProject(Nullable<int> empId, Nullable<int> projectId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAssignProject", empIdParameter, projectIdParameter);
        }
    
        public virtual int procDeleteAdmin(Nullable<int> adminid)
        {
            var adminidParameter = adminid.HasValue ?
                new ObjectParameter("adminid", adminid) :
                new ObjectParameter("adminid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procDeleteAdmin", adminidParameter);
        }
    
        public virtual int procDeleteAttendanceRequest(Nullable<int> reqId, Nullable<int> empid)
        {
            var reqIdParameter = reqId.HasValue ?
                new ObjectParameter("reqId", reqId) :
                new ObjectParameter("reqId", typeof(int));
    
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procDeleteAttendanceRequest", reqIdParameter, empidParameter);
        }
    
        public virtual int procDeleteAttendence(Nullable<int> empId, Nullable<int> projectId, Nullable<System.DateTime> date)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("projectId", projectId) :
                new ObjectParameter("projectId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procDeleteAttendence", empIdParameter, projectIdParameter, dateParameter);
        }
    
        public virtual int procDeleteEmployee(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procDeleteEmployee", empIdParameter);
        }
    
        public virtual int procDeleteProject(Nullable<int> projectID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procDeleteProject", projectIDParameter);
        }
    
        public virtual int procGenerateAttendanceRequest(Nullable<int> empId, Nullable<System.DateTime> date)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procGenerateAttendanceRequest", empIdParameter, dateParameter);
        }
    
        public virtual ObjectResult<procLoginAdmin_Result> procLoginAdmin(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procLoginAdmin_Result>("procLoginAdmin", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<procLoginEmployee_Result> procLoginEmployee(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procLoginEmployee_Result>("procLoginEmployee", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<procReadAdminById_Result> procReadAdminById(Nullable<int> adminId)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("adminId", adminId) :
                new ObjectParameter("adminId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procReadAdminById_Result>("procReadAdminById", adminIdParameter);
        }
    
        public virtual ObjectResult<procReadAllAdmin_Result> procReadAllAdmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procReadAllAdmin_Result>("procReadAllAdmin");
        }
    
        public virtual ObjectResult<procReadAllProject_Result> procReadAllProject()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procReadAllProject_Result>("procReadAllProject");
        }
    
        public virtual ObjectResult<procReadLeave_Result> procReadLeave(Nullable<int> leaveId)
        {
            var leaveIdParameter = leaveId.HasValue ?
                new ObjectParameter("leaveId", leaveId) :
                new ObjectParameter("leaveId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procReadLeave_Result>("procReadLeave", leaveIdParameter);
        }
    
        public virtual ObjectResult<procReadProject_Result> procReadProject(Nullable<int> projectID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procReadProject_Result>("procReadProject", projectIDParameter);
        }
    
        public virtual int procRejectAttendanceRequest(Nullable<int> attReqId)
        {
            var attReqIdParameter = attReqId.HasValue ?
                new ObjectParameter("attReqId", attReqId) :
                new ObjectParameter("attReqId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procRejectAttendanceRequest", attReqIdParameter);
        }
    
        public virtual int procRejectLeave(Nullable<int> leaveId)
        {
            var leaveIdParameter = leaveId.HasValue ?
                new ObjectParameter("leaveId", leaveId) :
                new ObjectParameter("leaveId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procRejectLeave", leaveIdParameter);
        }
    
        public virtual ObjectResult<procRetriveAllEmployee_Result> procRetriveAllEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procRetriveAllEmployee_Result>("procRetriveAllEmployee");
        }
    
        public virtual ObjectResult<procRetriveEmployee_Result> procRetriveEmployee(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procRetriveEmployee_Result>("procRetriveEmployee", empIdParameter);
        }
    
        public virtual ObjectResult<procShowPendingRequest_Result> procShowPendingRequest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procShowPendingRequest_Result>("procShowPendingRequest");
        }
    
        public virtual int procUpdateAdminById(Nullable<int> adminId, string adminName, string address, string contact, Nullable<System.DateTime> dob, string gender, string designation, Nullable<System.DateTime> doj, string aUserName, string aPassword)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("adminId", adminId) :
                new ObjectParameter("adminId", typeof(int));
    
            var adminNameParameter = adminName != null ?
                new ObjectParameter("adminName", adminName) :
                new ObjectParameter("adminName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(string));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var designationParameter = designation != null ?
                new ObjectParameter("designation", designation) :
                new ObjectParameter("designation", typeof(string));
    
            var dojParameter = doj.HasValue ?
                new ObjectParameter("doj", doj) :
                new ObjectParameter("doj", typeof(System.DateTime));
    
            var aUserNameParameter = aUserName != null ?
                new ObjectParameter("AUserName", aUserName) :
                new ObjectParameter("AUserName", typeof(string));
    
            var aPasswordParameter = aPassword != null ?
                new ObjectParameter("APassword", aPassword) :
                new ObjectParameter("APassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procUpdateAdminById", adminIdParameter, adminNameParameter, addressParameter, contactParameter, dobParameter, genderParameter, designationParameter, dojParameter, aUserNameParameter, aPasswordParameter);
        }
    
        public virtual int procUpdateAttendance(Nullable<int> empId, Nullable<int> projectId, Nullable<System.DateTime> date, Nullable<int> status)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("projectId", projectId) :
                new ObjectParameter("projectId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procUpdateAttendance", empIdParameter, projectIdParameter, dateParameter, statusParameter);
        }
    
        public virtual int procUpdateAttendanceRequest(Nullable<int> reqId, Nullable<int> empid, Nullable<System.DateTime> newDate)
        {
            var reqIdParameter = reqId.HasValue ?
                new ObjectParameter("reqId", reqId) :
                new ObjectParameter("reqId", typeof(int));
    
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            var newDateParameter = newDate.HasValue ?
                new ObjectParameter("newDate", newDate) :
                new ObjectParameter("newDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procUpdateAttendanceRequest", reqIdParameter, empidParameter, newDateParameter);
        }
    
        public virtual int procUpdateLeave(Nullable<int> leaveId, Nullable<bool> status)
        {
            var leaveIdParameter = leaveId.HasValue ?
                new ObjectParameter("leaveId", leaveId) :
                new ObjectParameter("leaveId", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procUpdateLeave", leaveIdParameter, statusParameter);
        }
    
        public virtual int procupdateProject(Nullable<int> projectID, string title)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procupdateProject", projectIDParameter, titleParameter);
        }
    
        public virtual ObjectResult<procViewPendingLeaveRequests_Result> procViewPendingLeaveRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procViewPendingLeaveRequests_Result>("procViewPendingLeaveRequests");
        }
    
        public virtual ObjectResult<Project> procupdateProject1(Nullable<int> projectID, string title)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procupdateProject1", projectIDParameter, titleParameter);
        }
    
        public virtual ObjectResult<Project> procupdateProject1(Nullable<int> projectID, string title, MergeOption mergeOption)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procupdateProject1", mergeOption, projectIDParameter, titleParameter);
        }
    
        public virtual ObjectResult<Project> procReadProject1(Nullable<int> projectID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procReadProject1", projectIDParameter);
        }
    
        public virtual ObjectResult<Project> procReadProject1(Nullable<int> projectID, MergeOption mergeOption)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procReadProject1", mergeOption, projectIDParameter);
        }
    
        public virtual ObjectResult<Project> procReadAllProject1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procReadAllProject1");
        }
    
        public virtual ObjectResult<Project> procReadAllProject1(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procReadAllProject1", mergeOption);
        }
    
        public virtual ObjectResult<Project> procDeleteProject1(Nullable<int> projectID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procDeleteProject1", projectIDParameter);
        }
    
        public virtual ObjectResult<Project> procDeleteProject1(Nullable<int> projectID, MergeOption mergeOption)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procDeleteProject1", mergeOption, projectIDParameter);
        }
    
        public virtual ObjectResult<Project> procAddProject1(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procAddProject1", titleParameter);
        }
    
        public virtual ObjectResult<Project> procAddProject1(string title, MergeOption mergeOption)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Project>("procAddProject1", mergeOption, titleParameter);
        }
    
        public virtual ObjectResult<Admin> procAssignProject1(Nullable<int> empId, Nullable<int> projectId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Admin>("procAssignProject1", empIdParameter, projectIdParameter);
        }
    
        public virtual ObjectResult<Admin> procAssignProject1(Nullable<int> empId, Nullable<int> projectId, MergeOption mergeOption)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Admin>("procAssignProject1", mergeOption, empIdParameter, projectIdParameter);
        }
    }
}
