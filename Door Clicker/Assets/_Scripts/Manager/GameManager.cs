
using UnityEngine;

public class GameManager : MonoBehaviour {
    #region Singleton
    public static GameManager Instance;

    void Awake() {
        if(Instance) {
            Destroy(this);
            return;
        }
        Instance = this;
    }
    #endregion

    public bool purchasedWorker = false;


}
