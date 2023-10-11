using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Anket
{
    [Serializable]
    internal class Anket_Class
    {
        [JsonPropertyName("Name: ")]
        public string anket_name { get; set; }

        [JsonPropertyName("Surname: ")]
        public string anket_surname { get; set; }

        [JsonPropertyName("Father Name: ")]
        public string anket_father_name { get; set; }

        [JsonPropertyName("Country: ")]
        public string anket_country { get; set; }

        [JsonPropertyName("City: ")]
        public string anket_city { get; set; }

        [JsonPropertyName("Phone: ")]
        public string anket_phone { get; set; }

        [JsonPropertyName("Birthday: ")]
        public string anket_birthday { get; set; }

        [JsonPropertyName("Gender: ")]
        public string anket_gender { get; set; }

        public Anket_Class()
        {

        }

        public Anket_Class(string anket_name, string anket_surname, string anket_father_name, string anket_country, string anket_city, string anket_phone, string anket_birthday, string anket_gender)
        {
            this.anket_name = anket_name;
            this.anket_surname = anket_surname;
            this.anket_father_name = anket_father_name;
            this.anket_country = anket_country;
            this.anket_city = anket_city;
            this.anket_phone = anket_phone;
            this.anket_birthday = anket_birthday;
            this.anket_gender = anket_gender;
        }
    }
}
