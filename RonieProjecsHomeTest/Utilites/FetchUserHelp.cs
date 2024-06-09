using RonieProjecsHomeTest.Users;
using System;

namespace RonieProjecsHomeTest.Utilites
{
    public static class FetchUserHelp
    {
/*        public static List<User> ConvertToUserList(ReqresUserResponse userResponse)
        {
            var users = new List<User>();
            if (userResponse?.Data != null)
            {
                foreach (var result in userResponse.Data)
                {
                    users.Add(new User(result.FirstName, result.LastName, result.Email, result.Id));
                }
            }
            return users;
        }
        public static async Task<List<User>> FetchReqresUsersAsync(string apiUrl)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(apiUrl);
            var userResponse = JsonSerializer.Deserialize<ReqresUserResponse>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return ConvertToUserList(userResponse);
        }*/
    }


}
