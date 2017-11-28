using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController {
  private const int DEFAULT_WIDTH = 10;
  private const int DEFAULT_HEIGHT = 10;

  private List<List<int>> _field;
  private int _width;
  private int _height;

  public FieldController(int width = DEFAULT_WIDTH, int height = DEFAULT_HEIGHT) {
    _width = width;
    _height = height;

    InitField();
  }

  private void InitField() {
    _field = new List<List<int>>();

    for(int i = 0; i < _height; i++) {
      for(int j = 0; j < _width; j++) {

      }
    }
  }
}
