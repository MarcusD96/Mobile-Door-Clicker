
using UnityEngine;

public class WorkerEffShop : ShopItem {

    WorkerShop workerShop;

    public override void Start() {
        base.Start();
        workerShop = FindObjectOfType<WorkerShop>();
    }

    public override void CheckAvailable() {
        if(GameManager.Instance.purchasedWorker == false) {
            button.interactable = false;
            costText.text = "(purchase worker first)";
            return;
        }
        else {
            costText.text = "(" + cost.ToString() + ")";
        }
        base.CheckAvailable();
    }

    public override void BuyItem() {
        base.BuyItem();
        workerShop.EarnFaster(numPurchased);
    }
}
