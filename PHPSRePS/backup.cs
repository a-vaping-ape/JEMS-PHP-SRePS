using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Configuration;

using MDRClient.DataAccess;

        private void btnBak_Click(object sender, EventArgs e) //backup
        {
            string saveAway = this.tbxBakLoad.Text.ToString().Trim();
            string cmdText = @"backup database " + System.Configuration.ConfigurationSettings.AppSettings["dbName"] + " to disk='" + saveAway + "'";
            BakReductSql(cmdText,true);            
        }
        private void btnReduct_Click(object sender, EventArgs e)  //recover
        {
            string openAway = this.tbxReductLoad.Text.ToString().Trim();//read the path
            string cmdText = @"restore database " + System.Configuration.ConfigurationSettings.AppSettings["dbName"] + " from disk='" + openAway + "'";            
            BakReductSql(cmdText,false);
        }
        /// <summary>
        /// backup and recover database via sql
        /// </summary>
        /// <param name="cmdText">backup or recover</param>
        /// <param name="isBak">it is for backup，true or false</param>
        private void BakReductSql(string cmdText,bool isBak)
        {
            SqlCommand cmdBakRst = new SqlCommand();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;uid=sa;pwd=;");
            try
            {
                conn.Open();
                cmdBakRst.Connection = conn;
                cmdBakRst.CommandType = CommandType.Text;
                if (!isBak)     //recover
                {
                    string setOffline = "Alter database GroupMessage Set Offline With rollback immediate ";
                    string setOnline = " Alter database GroupMessage Set Online With Rollback immediate";
                    cmdBakRst.CommandText = setOffline + cmdText + setOnline;
                }
                else
                {
                    cmdBakRst.CommandText = cmdText;
                }
                cmdBakRst.ExecuteNonQuery();
                if (!isBak)
                {
                    MessageBox.Show("the data is recovered", "System message");
                }
                else
                {
                    MessageBox.Show("You have backup the data", "System message");
                }
            }
            catch (SqlException sexc)
            {
                MessageBox.Show("fail" + sexc, "error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail：" + ex, "error");
            }
            finally
            {
                cmdBakRst.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

