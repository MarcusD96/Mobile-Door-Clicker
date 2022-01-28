
using UnityEngine;
using UnityEngine.UI;

public class ScalableGridLayout : MonoBehaviour {

    public DoorManager doorManager;
    public GridLayoutGroup gridLayout;

    private void Update() {
        int cellSize_ = 0;
        switch(doorManager.spawnedDoors.Count) {
            case 1:
                cellSize_ = 350;
                break;

            case 2:
                cellSize_ = 350;
                break;

            case 3:
                cellSize_ = 300;
                break;

            case 4:
                cellSize_ = 300;
                break;

            case 5:
                cellSize_ = 225;
                break;

            case 6:
                cellSize_ = 225;
                break;

            case 7:
                cellSize_ = 200;
                break;

            case 8:
                cellSize_ = 200;
                break;

            case 9:
                cellSize_ = 200;
                break;

            default:
                break;
        }
        gridLayout.cellSize = new Vector2(cellSize_, cellSize_);
    }

}
