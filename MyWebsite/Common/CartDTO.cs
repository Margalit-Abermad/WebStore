﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class CartDTO
{
    public string Name { get; set; }

    public float Price { get; set; }

    public string Department { get; set; }//AutoMapper -> FullName = $"{item.DonatesName}"
}
