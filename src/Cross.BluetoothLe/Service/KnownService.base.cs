﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.BluetoothLe.Service
{
  public struct KnownService
  {
    public string Name { get; }
    public Guid Id { get; }

    public KnownService(string name, Guid id)
    {
      Name = name;
      Id = id;
    }

    public override string ToString()
    {
      return $"{Name} - {Id}";
    }
  }
}