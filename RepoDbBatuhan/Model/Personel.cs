using System.ComponentModel.DataAnnotations;

namespace RepoDbBatuhan.Model
{
    public class Personel
    {
        public Guid Id { get; set; }
        public string AdıveİkinciAdı { get; set; }
        public string Soyadı { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
    }
}
