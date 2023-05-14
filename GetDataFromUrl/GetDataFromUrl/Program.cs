using System;
using static GetData.GetData;
using GetData;
using System.IO;
using Microsoft.VisualStudio.TextTemplating;

class Program
{
    public static class vCardExtention
    {

        static void Main(string[] args)
        {
          


            var vcards = VCardConverter.ConvertFromRandomUser().Result;
            foreach (var vcard in vcards)
            {
                string MainvCard = $"""
                BEGIN:VCARD
                VERSION:4.1
                Name:{vcard.Firstname}
                LastName:{vcard.Surname}
                Phone:{vcard.Phone}
                Email:{vcard.Email}
                Country:{vcard.Country}
                City:{vcard.City}
                END:VCARD
                """;
                string path = @"C:\Users\99451\Desktop\OOP\GetDataFromUrl\VCard.csv";
                File.WriteAllText(path, MainvCard);

                Console.WriteLine(vcard);
            }
            

        }

    }
}
