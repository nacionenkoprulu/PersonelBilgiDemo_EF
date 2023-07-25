using System;
using System.Collections.Generic;

namespace PersonelBilgiProject.Entities;

public partial class Iletisim
{
    public int Id { get; set; }

    public int PersonelId { get; set; }

    public int SehirId { get; set; }

    public string CepTelefon { get; set; } = null!;

    public string? EvTelefon { get; set; }

    public string? Eposta { get; set; }

    public string? Adres { get; set; }

    public virtual Personel Personel { get; set; } = null!;

    public virtual Sehir Sehir { get; set; } = null!;
}
