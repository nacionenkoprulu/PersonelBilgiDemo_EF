using System;
using System.Collections.Generic;

namespace PersonelBilgiProject.Entities;

public partial class Personel
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? KimlikNo { get; set; }

    public DateTime DogumTarih { get; set; }

    public virtual ICollection<Iletisim> Iletisim { get; set; } = new List<Iletisim>();

    public virtual ICollection<Maas> Maas { get; set; } = new List<Maas>();
}
