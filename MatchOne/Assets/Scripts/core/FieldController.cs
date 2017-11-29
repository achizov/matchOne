using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController {
  private const int DEFAULT_WIDTH = 10;
  private const int DEFAULT_HEIGHT = 10;

  private List<List<Cell>> _field;
  private int _width;
  private int _height;

  public FieldController(int width = DEFAULT_WIDTH, int height = DEFAULT_HEIGHT) {
    _width = width;
    _height = height;

    InitField();
  }

  private void InitField() {
    _field = new List<List<Cell>>();

    List<Cell> line;

    for(int i = 0; i < _height; i++) {
      line = new List<Cell>();
      for(int j = 0; j < _width; j++) {
        line.Add( GenerateCell() );
      }
      _field.Add(line);
    }
  }

  public Cell GetCell(int x, int y) {
    if(x < 0 || x >= Width) {
      return null;
    }
    if(y < 0 || y >= Height) {
      return null;
    }

    return _field[x][y];
  }

  public int Width {
    get { return _width; }
  }

  public int Height {
    get { return _height; }
  }


  private Cell GenerateCell() {
    int numType = Random.Range(0, 7);
    string strType = "";

    switch (numType) {
      case 1:
        strType = CellType.BALL_1;
        break;
      case 2:
        strType = CellType.BALL_2;
        break;
      case 3:
        strType = CellType.BALL_3;
        break;
      case 4:
        strType = CellType.BALL_4;
        break;
      case 5:
        strType = CellType.BALL_5;
        break;
      case 6:
        strType = CellType.BALL_6;
        break;
    }

    return new Cell(strType);
  }
}
