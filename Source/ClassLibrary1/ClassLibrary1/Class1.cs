using System;
using System.Collections.Generic;
using System.Data.SqlClient; // 追加
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        int a = 1;

        public Class1()
        {
            Console.WriteLine(a.ToString());
        }

        // SQL Serverからデータを取得するメソッド
        public List<string> GetData()
        {
            var results = new List<string>();
            // 適切な接続文字列に置き換えてください
            string connectionString = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;";
            string query = "SELECT ISNull(列名,'') 列名 FROM テーブル名";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(reader.GetString(0)); // 1列目がstring型の場合
                    }
                }
            }
            return results;
        }
    }
}
