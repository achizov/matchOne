﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cell {
  private string _type;

  public Cell(string cellType) {
    _type = cellType;
  }

  public string Type {
    get { return _type; }
  }
}
