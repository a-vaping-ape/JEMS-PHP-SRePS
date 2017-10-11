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

public static class SQLBackup
    {

        public static void StartCmd(String workingDirectory, String command)
        {
　　　　　　　　using (Process p = new Process())
            　　　　　　　　{
                　　　　　　　　　　p.StartInfo.FileName = "cmd.exe";
                　　　　　　　　　　p.StartInfo.WorkingDirectory = workingDirectory;
                　　　　　　　　　　p.StartInfo.UseShellExecute = false;
                　　　　　　　　　　p.StartInfo.RedirectStandardInput = true;
                　　　　　　　　　　p.StartInfo.RedirectStandardOutput = true;
                　　　　　　　　　　p.StartInfo.RedirectStandardError = true;
                　　　　　　　　　　p.StartInfo.CreateNoWindow = true;
                　　　　　　　　　　//p.EnableRaisingEvents = true;
                　　　　　　　　　　p.Start();
                　　　　　　　　　　p.StandardInput.WriteLine(command);
                　　　　　　　　　　p.StandardInput.WriteLine("exit");
                　　　　　　　　　　//p.StandardInput.Flush();
                　　　　　　　　　　string error = p.StandardError.ReadToEnd();
                　　　　　　　　　　p.WaitForExit();
                　　　　　　　　　　if (!string.IsNullOrEmpty(error) && (error.ToLower().Contains("error")))
                    　　　　　　　　　　　　throw new System.Data.DataException(error);
            　　　　　　　　　}
        }
        /// backup


        public static void Backup(string ip, string port, string dbName, string userName, string userPsw, string filepath, string characterset = "utf8")
        {
            try
            {
         
                string command = string.Format("mysqldump --quick --host=" + ip + " --default-character-set=" + characterset + " --lock-tables --verbose  --force --port=" + port + " --user=" + userName + " --password=" + userPsw + " " + dbName + " -r \"{0}\"", filepath);

                String appDirecroty = System.Windows.Forms.Application.StartupPath + "\\";
                StartCmd(appDirecroty, command);
            }
            catch (Exception ex)
            {
                throw new Exception("backuo fail！\r\n" + ex.ToString());
            }
        }
        /// recover

        public static void Restore(string ip, string port, string dbName, string userName, string userPsw, string filepath, string characterset = "utf8")
        {
            try
            {
                string command = string.Format("mysql --host=" + ip + " --default-character-set=" + characterset + " --port=" + port + " --user=" + userName + " --password=" + userPsw + " " + dbName + "<\"{0}\"", filepath);

                //require distory
                String appDirecroty = System.Windows.Forms.Application.StartupPath + "\\";
                StartCmd(appDirecroty, command);
            }
            catch (Exception ex)
            {
                throw new Exception("fail！\r\n" + ex.ToString());
            }

        }
    }
