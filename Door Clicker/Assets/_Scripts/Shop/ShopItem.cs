
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItem : MonoBehaviour {

    public Button button;
    public int cost;
    public TMP_Text costText;

    protected int numPurchased = 0;
    protected DoorManager doorManager;

    public virtual void Start() {
        doorManager = FindObjectOfType<DoorManager>();
        costText.text = "(" + cost + ")";
        button.onClick.AddListener(delegate {
            BuyItem();
        });
    }

    public virtual void LateUpdate() {
        CheckAvailable();
    }

    public virtual void CheckAvailable() {
        //if(doorManager.spawnedDoors[0].doorID < cost)
        //    button.interactable = false;
        //else
        //    button.interactable = true;
    }

    public virtual void BuyItem() {
        ScoreManager.Instance.RemoveScore(doorManager.spawnedDoors[0].doorID, cost);

        numPurchased++;
        cost = Mathf.RoundToInt(cost * 1.3f / 5f) * 5;
        costText.text = "(" + cost + ")";
    }

}
