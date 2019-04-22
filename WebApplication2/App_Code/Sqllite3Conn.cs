using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApplication2
{
    public class Sqllite3Conn
    {
        //数据库连接
        SQLiteConnection m_dbConnection;

        public string sqlitetest()
        {
            try
            {
                createNewDatabase();
                connectToDatabase();
                createTable();
                fillTable();
                return printHighscores();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        //创建一个空的数据库
        void createNewDatabase()
        {
            SQLiteConnection.CreateFile("e:\\MyDatabase.sqlite");
        }

        //创建一个连接到指定数据库
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=e:\\MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        //在指定数据库中创建一个table
        void createTable()
        {
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //插入一些数据
        void fillTable()
        {
            string sql = "insert into highscores (name, score) values ('Me', 3000)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('Myself', 6000)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('And I', 9001)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //使用sql查询语句，并显示结果
        string printHighscores()
        {
            StringBuilder sb = new StringBuilder();
            string sql = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                sb.Append("Name: " + reader["name"] + "\tScore: " + reader["score"] + "\n");
            return sb.ToString();
        }
    }
}