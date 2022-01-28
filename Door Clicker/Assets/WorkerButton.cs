
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkerButton : MonoBehaviour
{
    [HideInInspector] public int points;
    [HideInInspector] public Button button;

    public DoorType doorID;
    public TMP_Text pointsText;

    private void Start() {
        button = GetComponent<Button>();
    }

    public void Purchase() {
        ScoreManager.Instance.RemoveScore(doorID, points);
        pointsText.text = points.ToString();
    }
}
