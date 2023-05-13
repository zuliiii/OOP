using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GetData;

public class GetData
{

    public class VCard
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Firstname} {Surname}\nEmail: {Email}\nPhone: {Phone}\nLocation: {City}, {Country}\n";
        }
    }

    public static class VCardConverter
    {
        public static async Task<List<VCard>> ConvertFromRandomUser(int count = 3)
        {
            var url = $"https://randomuser.me/api?results={count}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var result = JsonSerializer.Deserialize<RandomUserResult>(json, options);
            var vcards = new List<VCard>();
            if (result != null && result.Results != null)
            {
                foreach (var user in result.Results)
                {
                    var vcard = new VCard
                    {
                        Id = user.login_uuid,
                        Firstname = user.name_first,
                        Surname = user.name_last,
                        Email = user.email,
                        Phone = user.phone,
                        Country = user.location_country,
                        City = user.location_city
                    };
                    vcards.Add(vcard);
                }
            }
            else
            {
                Console.WriteLine("null");
            }
            return vcards;
        }



    }

    public class RandomUserResult
    {
        public List<RandomUser> Results { get; set; }
    }

    public class RandomUser
    {
        public string login_uuid { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string location_country { get; set; }
        public string location_city { get; set; }
    }

}