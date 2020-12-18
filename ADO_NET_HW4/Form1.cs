using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_HW4
{
    public partial class Form1 : Form
    {
        DbConnection conn = null;
        DbProviderFactory fact = null;
        string connectionString = "";
        public Form1()
        {
            InitializeComponent();
            btn_Select.Enabled = false;
            if (txbx_Querry.Text.Length > 5)
            {
                btn_Select.Enabled = true;
            }
            else btn_Select.Enabled = false;
        }

        private async void btn_Select_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connectionString;

            await conn.OpenAsync();

            DbCommand comm = conn.CreateCommand();
            comm.CommandText = "Waitfor delay '00:00:05'";

            comm.CommandText += txbx_Querry.Text.ToString();
            DataTable table = new DataTable();
            using(DbDataReader reader = await comm.ExecuteReaderAsync())
            {
                bool head = true;
                do
                {
                    while(await reader.ReadAsync())
                    {
                        if (head)
                        {
                            for(int i = 0; i < reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.GetName(i));
                            }
                            head = false;
                        }
                        DataRow row = table.NewRow();
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = await reader.GetFieldValueAsync<object>(i);
                        }
                        table.Rows.Add(row);
                    }
                }
                while (reader.NextResult());

            }
            conn.Close();
            fill_ComboboxAsync();

            dataGridView1.DataSource = table;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fact = DbProviderFactories.GetFactory("System.Data.SqlClient");
            conn = fact.CreateConnection();
            connectionString = GetConnectionStringByProvider("System.Data.SqlClient");

            if (connectionString == null)
            {
                MessageBox.Show("There isn't requaired connection string in the file");
            }
        }
        static string GetConnectionStringByProvider(string providerName)
        {
            string returnValue = null;
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ProviderName == providerName)
                    {
                        returnValue = cs.ConnectionString;
                        break;
                    }
                }
            }
            return returnValue;
        }

        void txbx_Querry_TextChanged(object sender, EventArgs e)
        {
            if (txbx_Querry.Text.Length > 5)
            {
                btn_Select.Enabled = true;
            }
            else btn_Select.Enabled = false;
        }

        private async void fill_ComboboxAsync()
        {
            await conn.OpenAsync();
            DbCommand command = conn.CreateCommand();
            command.CommandText = "Select firstname + ' ' + lastname as [full name] from Authors";

            using(DbDataReader reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {

                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        object item = await reader.GetFieldValueAsync<object>(i);
                        cmbx_Writers.Items.Add(item as string);
                    }
                }
            }

        }
    }
  
}
