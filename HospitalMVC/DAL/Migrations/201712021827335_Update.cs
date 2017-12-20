namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appoinments", "Date", c => c.DateTime());
            AlterColumn("dbo.Appoinments", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Appoinments", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Appoinments", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Patients", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Patients", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Patients", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Patients", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Towns", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Towns", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Towns", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Cities", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Cities", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Cities", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Policlinics", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Policlinics", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Policlinics", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Hospitals", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Hospitals", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Hospitals", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Staffs", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Staffs", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Staffs", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Staffs", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Titles", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Titles", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Titles", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.PatientHistories", "HistoryDate", c => c.DateTime());
            AlterColumn("dbo.PatientHistories", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.PatientHistories", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.PatientHistories", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.Users", "InsertDate", c => c.DateTime());
            AlterColumn("dbo.Users", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Users", "DeleteDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PatientHistories", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PatientHistories", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PatientHistories", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.PatientHistories", "HistoryDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Titles", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Titles", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Titles", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Staffs", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Staffs", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Staffs", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Staffs", "BirthDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Hospitals", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Hospitals", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Hospitals", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Policlinics", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Policlinics", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Policlinics", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Cities", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Cities", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Cities", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Towns", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Towns", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Towns", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "BirthDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Appoinments", "DeleteDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Appoinments", "UpdateDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Appoinments", "InsertDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Appoinments", "Date", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
