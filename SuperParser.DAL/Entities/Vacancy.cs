using Newtonsoft.Json;
using System.Collections.Generic;

namespace SuperParser.DAL.Entities
{
    public class Vacancy
    {
        public string Name { get; set; }
        public Salary Salary { get; set; }
        public Address Address { get; set; }
        public Area Area { get; set; }
        public Experience Experience { get; set; }
        public Schedule Schedule { get; set; }
        public Employment Employment { get; set; }
        public object Contacts { get; set; }
        public string Description { get; set; }
 
        public string Requirements { get; set; } = "-стрессоустойчивость\n-коммуникабельность\n-пунктуальность\n-обучаемость\n";
        public string Responsebilities { get; set; } = "-выполнение трудовых обязанностей\n-соблюдение трудовой дисциплины\n-соблюдать требования по безопасности и охране труда\n";
        public string Offers { get; set; } = "-Достойную и своевременную заработную плату, премии и бонусы\n-Удобный график работы\n-полный социальный пакет по ТК РБ\n";

        public string SubCategory { get; set; } = "Специалист";

        public List<Specialization> Specializations { get; set; }
        public Employer Employer { get; set; }

        [JsonProperty("branded_description")]
        public object BrandedDescription { get; set; }

        [JsonProperty("key_skills")]
        public List<KeySkill> KeySkills { get; set; }
    }
}
