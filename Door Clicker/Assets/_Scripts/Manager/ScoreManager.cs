
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    #region Singleton

    public static ScoreManager Instance;

    private void Awake() {
        if(Instance) {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    #endregion

    public TMP_Text[] scoreTexts;

    DoorManager doorManager;

    public int TargetScore { get; set; } = 0;

    private void Start() {
        doorManager = FindObjectOfType<DoorManager>();
        foreach(var s in scoreTexts) {
            s.text = "0";
        }
    }

    public void UpdateScore(DoorType type_) {
        scoreTexts[(int) type_].text = doorManager.spawnedDoors[(int) type_].pointsGenerated.ToString();
    }

    public void RemoveScore(DoorType type_, int score_) {
        doorManager.spawnedDoors[(int) type_].pointsGenerated -= score_;
        UpdateScore(type_);
    }
}