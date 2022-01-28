
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorManager : MonoBehaviour {

    public Door[] doors;

    public List<Door> spawnedDoors = new List<Door>();

    private void Start() {
        CreateNewDoor(0);
    }

    public void CreateNewDoor(int level_) {
        Door d = Instantiate(doors[level_], transform);
        spawnedDoors.Add(d);
        Button b = d.GetComponent<Button>();
        b.onClick.AddListener(delegate {
            OnClickDoor();
        });
        SyncronizeDoors();
    }

    void OnClickDoor() {
        foreach(var d in spawnedDoors) {
            d.InteractWithDoor();
        }
    }

    void SyncronizeDoors() {
        bool open_ = spawnedDoors[0].Open;
        foreach(var d in spawnedDoors) {
            d.Open = open_;
        }
    }
}

public enum DoorType {
    WOOD = 0,
    BRONZE,
    SILVER,
    GOLD,
    PLATINUM,
    RUBY,
    EMERALD,
    DIAMOND,
    PRISMATIC
}
