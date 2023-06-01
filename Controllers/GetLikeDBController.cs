using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using autoria_back.Models;

namespace autoria_back.Controllers
{

    public class GetLikeDBController
    {
        [HttpGet("DB/GetLikes/{user_id}")]
        public async Task<List<LikeDBcolsModel>> GetLikesAsync(int user_id)
        {
            List<LikeDBcolsModel> list = new List<LikeDBcolsModel>();
            DBconnect dBconnect = new DBconnect();
            using (MySqlConnection connection = dBconnect.GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT user_id, adv_id, price FROM likes WHERE user_id = @user_id", connection);

                command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = user_id;

                await connection.OpenAsync();

                MySqlDataReader dataReader = await command.ExecuteReaderAsync();

                if (dataReader.HasRows)
                {
                    while (await dataReader.ReadAsync())
                    {
                        var record = new LikeDBcolsModel
                        {
                            user_id = dataReader.GetInt32(0),
                            adv_id = dataReader.GetInt32(1),
                            price = dataReader.GetInt32(2)
                        };
                        list.Add(record);
                    }
                }

                connection.Close();
            }

            return list;
        }
    }

}
