using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WorldSkilzTest
{
	class ConectionString
	{
		public static SqlConnection
				 GetDBConnection()
		{
			//
			// Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
			//
			string connString = "Data Source=DESKTOP-B98238U\\SQLEXPRESS;Initial Catalog=WorldSkilz;Integrated Security=True";

			SqlConnection conn = new SqlConnection(connString);

			return conn;
		}
	}
}
