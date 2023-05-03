using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;

namespace Enum_homework;

    class Program
    {
    public enum Status
    {
       


        [Display(Name = "Aktif Kullanıcıları Listeler")]
        Active = 1,


        [Display(Name = "Pasif Kullanıcıları Listeler")]
        Passive,


        [Display(Name = "Silinmiş Kullanıcıları Listeler")]
        Deleted,


        [Display(Name = "Kaydını Dondurmuş Kullanıcıları Listeler")]
        Holiday
    }




    static void Main(string[] args) {

        Console.Write($"{Enum.GetName(typeof(Status), 0)}");

        //foreach (int i in Enum.GetValues(typeof(Status)))
        //{
        //    Console.WriteLine($" {i}");
        //}
        //foreach (Status i in Enum.GetValues(typeof(Status)))
        //{
        //    Console.WriteLine($" {i}");
        //}

        //foreach (string name in Enum.GetNames(typeof(Status)))
        //{
        //    Console.WriteLine(name);
        //}


        //var values = Enum.GetValues(typeof(Status));
        //Console.WriteLine(values.Length);

        foreach (Status status in Enum.GetValues(typeof(Status)))
        {
            ;
            foreach (var field in status.GetType().GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) as DisplayAttribute;

                if (attribute != null && attribute.Name != null && status.ToString() == field.Name)
                {
                    Console.WriteLine($"{status} = {attribute.Name}");
                    break;
                }
            }
        }


        Console.ReadKey();
        
   
}

    }