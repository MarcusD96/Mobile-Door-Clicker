
using UnityEngine;

public class WorkerShop : ShopItem {

    public float startWorkRate;

    float nextWork, currentWorkRate;

    override public void Start() {
        base.Start();
        currentWorkRate = startWorkRate;
    }

    public override void BuyItem() {
        base.BuyItem();
        GameManager.Instance.purchasedWorker = true;
    }

    public override void LateUpdate() {
        base.LateUpdate();

        nextWork -= Time.deltaTime;

        if(nextWork <= 0) {
            foreach(var d in doorManager.spawnedDoors) {
                //ScoreManager.Instance.UpdateScore(numPurchased * d.scoreWorth); 
            }
            nextWork = 1 / currentWorkRate;
        }

    }

    public void EarnFaster(int effNum_) {
        currentWorkRate = startWorkRate * (1 + (0.1f * effNum_));
    }
}
