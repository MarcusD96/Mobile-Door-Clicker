
using UnityEngine;

public class DoorShop : MonoBehaviour {

    public GameObject doorShop;
    public DoorButton[] doorButtons;

    int levelUnlocked = 0;
    DoorManager doorManager;

    private void Awake() {
        doorManager = FindObjectOfType<DoorManager>();
    }

    private void Start() {
        doorShop.SetActive(false);
        for(int i = 0; i < doorButtons.Length; i++) {
            doorButtons[i].points = doorManager.doors[i + 1].purchaseCost;
        }
    }

    private void LateUpdate() {
        for(int i = 0; i < doorButtons.Length; i++) {
            if(doorButtons[i].purchased) {
                doorButtons[i].button.interactable = false;
            }

            else if(i == levelUnlocked) {
                if(doorManager.spawnedDoors[i].pointsGenerated >= doorButtons[i].points)
                    doorButtons[i].button.interactable = true;
                else
                    doorButtons[i].button.interactable = false;
            }
            else
                doorButtons[i].button.interactable = false;
        }
    }

    public void ToggleShop() {
        doorShop.SetActive(!doorShop.activeSelf);
    }

    public void PurchaseDoor() {
        ScoreManager.Instance.RemoveScore((DoorType) levelUnlocked, doorButtons[levelUnlocked].points);
        doorButtons[levelUnlocked].Purchase();
        levelUnlocked++;
        doorManager.CreateNewDoor(levelUnlocked);
    }
}
