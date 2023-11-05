using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.App_Class
{
    internal class DataBase
    {
        public string Schema { get; set; }
        public string Name { get; set; }
        public string Table { get; set; }
        //
        public DataBase(string Schema, string Name)
        {
            this.Schema = Schema;
            this.Name = Name;
            Table = $"{this.Schema}.{this.Name}";
        }
        static string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        // Paramters as (TheKey,TheValue,Numriacl or not,.....)
        public bool Insert(params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Inserted = false;
            try
            {
                string Keys = "";
                string Values = "";
                for (int i = 0; i < Inputs.Length; i += 3)
                {
                    Keys += $"{Inputs[i]} ,";
                    if (Inputs[i + 2].ToLower() == "true")
                    {
                        Values += $"{Inputs[i + 1]} ,";
                    }
                    else
                    {
                        Values += $"N'{Inputs[i + 1]}' ,";
                    }
                }
                Keys = Keys.Remove(Keys.Length - 1);
                Values = Values.Remove(Values.Length - 1);
                string Query = $"INSERT INTO {this.Table}({Keys}) VALUES ({Values})";
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                int Rows = cmd.ExecuteNonQuery();
                if (Rows > 0)
                {
                    Inserted = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Inserted;
        }
        // Paramters as (TheKey,TheValue,Numrcail or Not , ..... ) first 3 index for primary key
        public bool Update(params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Updated = false;
            try
            {
                string Selected = "";
                for (int i = 3; i < Inputs.Length; i += 3)
                {
                    if (Inputs[i + 2].ToLower() == "true")
                    {
                        Selected += $"{Inputs[i]} = {Inputs[i + 1]} ,";
                    }
                    else
                    {
                        Selected += $"{Inputs[i]} = N'{Inputs[i + 1]}' ,";
                    }
                }
                Selected = Selected.Remove(Selected.Length - 1);
                if (Inputs[2].ToLower() == "true")
                {
                    string Query = $"update {this.Table} set {Selected} where {Inputs[0]} = {Inputs[1]}";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
                else
                {
                    string Query = $"update {this.Table} set {Selected} where {Inputs[0]} = '{Inputs[1]}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Updated;
        }
        // Update Update Values Using 2 Condtions , Starts The Params With The 2 Condtions 
        public bool XUpdate(params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Updated = false;
            try
            {
                string Selected = "";
                for (int i = 6; i < Inputs.Length; i += 3)
                {
                    if (Inputs[i + 2].ToLower() == "true")
                    {
                        Selected += $"{Inputs[i]} = {Inputs[i + 1]} ,";
                    }
                    else
                    {
                        Selected += $"{Inputs[i]} = N'{Inputs[i + 1]}' ,";
                    }
                }
                Selected = Selected.Remove(Selected.Length - 1);
                if (Inputs[2].ToLower() == "true" && Inputs[5].ToLower() == "true")
                {
                    string Query = $"update {this.Table} set {Selected} where {Inputs[0]} = {Inputs[1]} AND {Inputs[3]} = {Inputs[4]}";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
                else if (Inputs[2].ToLower() == "false" && Inputs[5].ToLower() == "false")
                {
                    string Query = $"update {this.Table} set {Selected} where {Inputs[0]} = N'{Inputs[1]}' AND {Inputs[3]} = N'{Inputs[4]}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
                else if (Inputs[2].ToLower() == "true" && Inputs[5].ToLower() == "false")
                {
                    string Query = $"update {this.Table} set {Selected} where {Inputs[0]} = {Inputs[1]} AND {Inputs[3]} = N'{Inputs[4]}'";
                    MessageBox.Show(Query);
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
                else if (Inputs[2].ToLower() == "false" && Inputs[5].ToLower() == "true")
                {
                    string Query = $"update {this.Table} set {Selected} where {Inputs[0]} = N'{Inputs[1]}' AND {Inputs[3]} = {Inputs[4]}";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Updated;
        }
        // Update All Column of the table where this condtion
        public bool UpdateAll(string Key, string Value, string Numrical)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Updated = false;
            try
            {
                if (Numrical.ToLower() == "true")
                {
                    string Query = $"update {this.Table} set {Key} = {Value} ";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
                else
                {
                    string Query = $"update {this.Table} set {Key} = N'{Value}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Updated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Updated;
        }
        //
        public bool CustomUpdate(string S)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Updated = false;
            try
            {
                string Query = S;
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                int Rows = cmd.ExecuteNonQuery();
                if (Rows > 0)
                {
                    Updated = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Updated;
        }
        // Paramters as (TheKey,TheValue,Numriacl or not,.....) 
        public bool Delete(params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Deleted = false;
            try
            {
                if (Inputs[2].ToLower() == "true")
                {
                    if (Inputs.Length == 4)
                    {
                        string Query = $"DELETE FROM {this.Table} WHERE {Inputs[0]} = {Inputs[1]}";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        int Rows = cmd.ExecuteNonQuery();
                        if (Rows > 0)
                        {
                            Deleted = true;
                        }
                    }
                    else
                    {
                        string SelectedItems = "";
                        for (int i = 3; i < Inputs.Length; i++)
                        {
                            SelectedItems += $"{Inputs[i]} ,";
                        }
                        string Query = $"DELETE {SelectedItems} FROM {this.Table} WHERE {Inputs[0]} = {Inputs[1]} ";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        int Rows = cmd.ExecuteNonQuery();
                        if (Rows > 0)
                        {
                            Deleted = true;
                        }
                    }
                }
                else
                {
                    if (Inputs.Length == 4)
                    {
                        string Query = $"DELETE FROM {this.Table} WHERE {Inputs[0]} = '{Inputs[1]}' ";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        int Rows = cmd.ExecuteNonQuery();
                        if (Rows > 0)
                        {
                            Deleted = true;
                        }
                    }
                    else
                    {
                        string SelectedItems = "";
                        for (int i = 3; i < Inputs.Length; i++)
                        {
                            SelectedItems += $"{Inputs[i]} ,";
                        }
                        SelectedItems = SelectedItems.Remove(SelectedItems.Length - 1);
                        string Query = $"DELETE {SelectedItems} FROM {this.Table} WHERE {Inputs[0]} = '{Inputs[1]}'";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        int Rows = cmd.ExecuteNonQuery();
                        if (Rows > 0)
                        {
                            Deleted = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Deleted;
        }
        public bool CustomDelete(string S)
        {
            SqlConnection conn = new SqlConnection(connection);
            bool Deleted = false;
            try
            {
                string Query = S;
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                int Rows = cmd.ExecuteNonQuery();
                if (Rows > 0)
                {
                    Deleted = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Deleted;
        }
        // Paramters as (all or Custom Columns)
        public DataTable Select(params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable dt = new DataTable();
            try
            {
                if (Inputs.Length == 1 && Inputs[0].ToLower() == "all")
                {
                    string Query = $"SELECT * FROM {this.Table}";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    string SelectedItems = "";
                    foreach (var Item in Inputs)
                    {
                        SelectedItems += $"{Item} ,";
                    }
                    SelectedItems = SelectedItems.Remove(SelectedItems.Length - 1);
                    string Query = $"SELECT {SelectedItems} FROM {this.Table}";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        // Paramters as (The Key , The Value , Numrical , null or Custom Columns)
        public DataTable SelectOne(params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable dt = new DataTable();
            try
            {
                if (Inputs.Length > 3)
                {
                    string Selected = "";
                    for (int i = 3; i < Inputs.Length; i++)
                    {
                        Selected += $"{Inputs[i]} ,";
                    }
                    Selected = Selected.Remove(Selected.Length - 1);
                    if (Inputs[2].ToLower() == "true")
                    {
                        string Query = $"SELECT {Selected} FROM {this.Table} WHERE {Inputs[0]} = {Inputs[1]}";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        conn.Open();
                        adapter.Fill(dt);
                    }
                    else
                    {
                        string Query = $"SELECT {Selected} FROM {this.Table} WHERE {Inputs[0]} = N'{Inputs[1]}'";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
                else
                {
                    if (Inputs[2].ToLower() == "true")
                    {
                        string Query = $"SELECT * FROM {this.Table} WHERE {Inputs[0]} = {Inputs[1]}";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        conn.Open();
                        adapter.Fill(dt);
                    }
                    else
                    {
                        string Query = $"SELECT * FROM {this.Table} WHERE {Inputs[0]} = '{Inputs[1]}'";
                        MessageBox.Show(Query);
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //
        public DataTable SelectLike(string S, params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable dt = new DataTable();
            try
            {
                if (Inputs.Length > 1)
                {
                    string Selected = "";
                    for (int i = 0; i < Inputs.Length; i++)
                    {
                        Selected += $"{Inputs[i]} ,";
                    }
                    Selected = Selected.Remove(Selected.Length - 1);
                    string Query = $"SELECT {Selected} FROM {this.Table} WHERE {Inputs[0]} LIKE N '%{S}%' ";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    string Query = $"SELECT * FROM {this.Table} WHERE {Inputs[0]} LIKE N'%{S}%'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //
        public DataTable CustomSelect(string S)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable dt = new DataTable();
            try
            {
                string Query = S;
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //
        public DataTable GetData(string Key)
        {
            DataTable dt = SelectOne("Category", Key, "false", "Value");
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        //
        public DataTable MulitpeSelect(string S, params string[] Inputs)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable dt = new DataTable();
            string Q = "";
            if (Inputs.Length > 1)
            {
                for (int i = 0; i < Inputs.Length; i += 3)
                {
                    if (Inputs[i + 2].ToLower() == "false")
                        Q += $"{Inputs[i]} = N'{Inputs[i + 1]}' AND ";
                    else
                        Q += $"{Inputs[i]} = {Inputs[i + 1]} AND ";
                }
                Q = Q.Remove(Q.Length - 4);
            }
            try
            {
                string Query = "";
                if (Q.Length > 0)
                {
                    Query = $"SELECT {S} FROM {this.Table} WHERE {Q}";
                }
                else
                {
                    Query = $"SELECT {S} FROM {this.Table}";
                }
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Error IS: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
