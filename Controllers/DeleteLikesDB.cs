using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace autoria_back.Controllers
{
    public class DeleteLikesDB : ControllerBase
    {
        [HttpDelete("/DB/DeleteLike")]
        public async Task<int> DeleteLikeDBAsync(int user_id)
        {
            DBconnect dBconnect = new DBconnect();
            using (MySqlConnection connection = dBconnect.GetConnection())
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM likes WHERE user_id = @user_id", connection);


                command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = user_id;

                await connection.OpenAsync();

                int deletedRows = await command.ExecuteNonQueryAsync();

                connection.Close();

                return deletedRows; // Returns the number of affected rows.
            }
        }
    }
}
