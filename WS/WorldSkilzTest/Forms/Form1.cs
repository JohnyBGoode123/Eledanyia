using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSkilzTest.Forms;
using System.Data.SqlClient;
namespace WorldSkilzTest
{
	public partial class Main : Form
	{
		Son son = new Son();
		public Main()
		{
			InitializeComponent();
			son.Owner = this;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Start_Click(object sender, EventArgs e)
		{
			son.ShowDialog();
		}
	}
}
