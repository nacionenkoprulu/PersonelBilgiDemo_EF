using System;
using System.Collections.Generic;

namespace PersonelBilgiProject.Entities;

public partial class Maas
{
    public int Id { get; set; }

    public int PersonelId { get; set; }

    public decimal Ucret { get; set; }

    public string Yil { get; set; } = null!;

    public virtual Personel Personel { get; set; } = null!;
}
