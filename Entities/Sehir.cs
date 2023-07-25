using System;
using System.Collections.Generic;

namespace PersonelBilgiProject.Entities;

public partial class Sehir
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public virtual ICollection<Iletisim> Iletisim { get; set; } = new List<Iletisim>();
}
