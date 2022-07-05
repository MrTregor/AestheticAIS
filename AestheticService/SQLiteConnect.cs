﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows;

namespace DBConnect
{
    public class SQLiteConnect
    {
        private static string dbName = "aesthetic";
        SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbName + ".db");

        public SQLiteConnect()
        {
            try
            {
                Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        ~SQLiteConnect()
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
            }
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

        public void Command(string sql)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable GetTable(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }
    }
}