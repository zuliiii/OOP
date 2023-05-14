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
            return $"ID: {Id}\nName: {Firstname}\nLastname: {Surname}\nEmail: {Email}\nPhone: {Phone}\nCountry: {Country}\nCity: {City}\n";
        }
    }

    public static class VCardConverter
    {
        public static async Task<List<VCard>> ConvertFromRandomUser()
        {
            var url = $"https://randomuser.me/api?results=3";
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
                        Id = user.uuid,
                        Firstname = user.name.first,
                        Surname = user.name.last,
                        Email = user.email,
                        Phone = user.phone.mobile,
                        Country = user.location.country,
                        City = user.location.city
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
        public string uuid { get; set; }
        public string email { get; set; }
        public Phone phone { get; set; }
        public Name name { get; set; }
        public Location location { get; set; }
    }

    public class Name
    {
        public string first { get; set; }
        public string last { get; set; }
    }

    public class Phone
    {
        public string mobile { get; set; }
    }

    public class Location
    {
        public string country { get; set; }
        public string city { get; set; }
    }


}