using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using autoria_back.Models;

namespace autoria_back.Controllers
{
    public class PutLikeDBController : ControllerBase
    {

        [HttpPut("DB/PutLikes")]
        public async Task<LikeDBcolsModel> PutLikeDBAsync([FromBody] LikeDBcolsModel likeDBcolsModel)
        {
            DataTable table = new DataTable();
            DBconnect dBconnect = new DBconnect();
            MySqlCommand command = new MySqlCommand("INSERT IGNORE INTO likes(user_id, adv_id, price) VALUES (@user_id, @adv_id, @price)", 
                dBconnect.GetConnection());

            command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = likeDBcolsModel.user_id;
            command.Parameters.Add("@adv_id", MySqlDbType.Int32).Value = likeDBcolsModel.adv_id;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = likeDBcolsModel.price;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return likeDBcolsModel;

        }
    }
}
