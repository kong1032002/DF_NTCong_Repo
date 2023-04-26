using System;
using System.Collections.Generic;

namespace DF_NTCong_Repo_Core.Models;

public partial class Sinhvien
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public int Tuoi { get; set; }

    public string? Khoahoc { get; set; }

    public decimal? Hocphi { get; set; }
}
