using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusinessTier 
{
	public sealed class Registration 
    {
		#region Fields
		private int studentID;
		private string name;
		private DateTime dateOfBirth;
		private decimal gradePointAvg;
		private bool active;
		#endregion
		
		#region Constructors
	
		public Registration() 
        {
		}		
		
		public Registration(string name, DateTime dateOfBirth, decimal gradePointAvg, bool active) 
        {
			this.name = name;
			this.dateOfBirth = dateOfBirth;
			this.gradePointAvg = gradePointAvg;
			this.active = active;
		}		
		
		public Registration(int studentID, string name, DateTime dateOfBirth, decimal gradePointAvg, bool active) {
			this.studentID = studentID;
			this.name = name;
			this.dateOfBirth = dateOfBirth;
			this.gradePointAvg = gradePointAvg;
			this.active = active;
		}
		#endregion
		
		#region Properties
		public int StudentID {
			get { return studentID; }
			set { studentID = value; }
		}
				
		public string Name {
			get { return name; }
			set { name = value; }
		}
		
		public DateTime DateOfBirth {
			get { return dateOfBirth; }
			set { dateOfBirth = value; }
		}
		
		public decimal GradePointAvg {
			get { return gradePointAvg; }
			set { gradePointAvg = value; }
		}
		
		public bool Active {
			get { return active; }
			set { active = value; }
		}
		#endregion
		
		#region Methods
		public void Insert() {
 
			SqlConnection scon = Connection.GetConnection();
			SqlCommand scom = new SqlCommand("RegistrationInsert", scon);
			scom.CommandType = CommandType.StoredProcedure;
 
 
			scom.Parameters.Add("@Name", SqlDbType.VarChar,500);
			scom.Parameters.Add("@DateOfBirth", SqlDbType.DateTime,8);
			scom.Parameters.Add("@GradePointAvg", SqlDbType.Decimal,9);
			scom.Parameters.Add("@Active", SqlDbType.Bit,1);
 
			scom.Parameters["@Name"].Value = name;
			scom.Parameters["@DateOfBirth"].Value = dateOfBirth;
			scom.Parameters["@GradePointAvg"].Value = gradePointAvg;
			scom.Parameters["@Active"].Value = active;
 
 
			scon.Open();
			scom.ExecuteNonQuery();
			scon.Close();
		}
		
		public void Update() {
 
			SqlConnection scon = Connection.GetConnection();
			SqlCommand scom = new SqlCommand("RegistrationUpdate", scon);
			scom.CommandType = CommandType.StoredProcedure;


            scom.Parameters.Add("@StudentID", SqlDbType.Int, 4);
			scom.Parameters.Add("@Name", SqlDbType.VarChar,500);
			scom.Parameters.Add("@DateOfBirth", SqlDbType.DateTime,8);
			scom.Parameters.Add("@GradePointAvg", SqlDbType.Decimal,9);
			scom.Parameters.Add("@Active", SqlDbType.Bit,1);


            scom.Parameters["@StudentID"].Value = studentID;
			scom.Parameters["@Name"].Value = name;
			scom.Parameters["@DateOfBirth"].Value = dateOfBirth;
			scom.Parameters["@GradePointAvg"].Value = gradePointAvg;
			scom.Parameters["@Active"].Value = active;
 
 
			scon.Open();
			scom.ExecuteNonQuery();
			scon.Close();
		}
		
		public void Delete() {
 
			SqlConnection scon = Connection.GetConnection();
			SqlCommand scom = new SqlCommand("RegistrationDelete", scon);
			scom.CommandType = CommandType.StoredProcedure;
 
			scom.Parameters.Add("@StudentID", SqlDbType.Int,4);
			scom.Parameters["@StudentID"].Value = studentID;
 
 
			scon.Open();
			scom.ExecuteNonQuery();
			scon.Close();
		}
		
		public static Registration Select(int studentID_Incoming){

			Registration Registrationins = new Registration();
			SqlConnection scon = Connection.GetConnection();
			SqlCommand scom = new SqlCommand("RegistrationSelect", scon);
			scom.CommandType = CommandType.StoredProcedure;
			scon.Open();
 
			scom.Parameters.Add("@StudentID", SqlDbType.Int,4);
			scom.Parameters["@StudentID"].Value = studentID_Incoming;
			using (SqlDataReader dataReader = scom.ExecuteReader()){
				if (dataReader.Read()) {
					Registrationins = MakeRegistration(dataReader);
				} else {
					Registrationins = null;
				}
			}
			scon.Close();
			return Registrationins;
		}
		
		public static List<Registration> SelectAll() {
 
			SqlConnection scon = Connection.GetConnection();
			SqlCommand scom = new SqlCommand("RegistrationSelectAll", scon);
			scom.CommandType = CommandType.StoredProcedure;
			scon.Open();
 
				List<Registration> registrationList = new List<Registration>();
			using (SqlDataReader dataReader = scom.ExecuteReader()){
				while (dataReader.Read()) {
					Registration registration = MakeRegistration(dataReader);
					registrationList.Add(registration);
				}
			}
			scon.Close();
			return registrationList;
		}
		
		private static Registration MakeRegistration(SqlDataReader dataReader) {
			Registration registration = new Registration();
			
			if (dataReader.IsDBNull(0) == false) {
				registration.StudentID = dataReader.GetInt32(0);
			}
			if (dataReader.IsDBNull(1) == false) {
				registration.Name = dataReader.GetString(1);
			}
			if (dataReader.IsDBNull(2) == false) {
				registration.DateOfBirth = dataReader.GetDateTime(2);
			}
			if (dataReader.IsDBNull(3) == false) {
				registration.GradePointAvg = dataReader.GetDecimal(3);
			}
			if (dataReader.IsDBNull(4) == false) {
				registration.Active = dataReader.GetBoolean(4);
			}

			return registration;
		}
		
		public static DataTable CreateDataTable( Registration  registration   )
		{
		DataTable dt = new DataTable();
		
			DataColumn col_StudentID = new DataColumn("StudentID" , typeof(int));
			DataColumn col_Name = new DataColumn("Name" , typeof(string));
			DataColumn col_DateOfBirth = new DataColumn("DateOfBirth" , typeof(DateTime));
			DataColumn col_GradePointAvg = new DataColumn("GradePointAvg" , typeof(decimal));
			DataColumn col_Active = new DataColumn("Active" , typeof(bool));
		dt.Columns.AddRange(new DataColumn[] { col_StudentID,col_Name,col_DateOfBirth,col_GradePointAvg,col_Active,});		return dt;
		}
		
		public static void FillData(DataTable dt, Registration user) {
		DataRow drow = dt.NewRow();
		
			drow["StudentID"] = user.StudentID;
			drow["Name"] = user.Name;
			drow["DateOfBirth"] = user.DateOfBirth;
			drow["GradePointAvg"] = user.GradePointAvg;
			drow["Active"] = user.Active;
		dt.Rows.Add(drow);
		}
		#endregion
	}
}
