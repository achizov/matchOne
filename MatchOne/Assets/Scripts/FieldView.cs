using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts {
  public class FieldView : MonoBehaviour {
    private FieldController _fieldController;

    public void Start() {
      _fieldController = new FieldController(10, 10);

      AddField();
    }

    private void AddField() {
      SpriteRenderer pref = Resources.Load<SpriteRenderer>("BallPref");
      Cell cell;

      for(int i = 0; i < _fieldController.Width; i++) {
        for(int j = 0; j < _fieldController.Height; j++) {
          cell = _fieldController.GetCell(i, j);

          var image = Resources.Load<Sprite>("Jelly_7");
          pref.sprite = image;
          Instantiate(pref);
          return;
        }
      }
    }

    //private voi

  }
}
