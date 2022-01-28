
using UnityEngine;

public class WorkerShopV2 : MonoBehaviour {

    public GameObject panel;
    public WorkerButton[] workerButtons; 

    public void ToggleShop() {
        panel.SetActive(!panel.activeSelf);
    }
}
