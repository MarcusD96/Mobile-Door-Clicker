
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DoorButton : MonoBehaviour {

    [HideInInspector] public int points;
    [HideInInspector] public Button button;
    [HideInInspector] public bool purchased = false;

    public TMP_Text unlockText;
    public TMP_Text pointsText;

    private void Start() {
        button = GetComponent<Button>();
    }

    private void LateUpdate() {
        pointsText.text = points.ToString();
    }

    public void Purchase() {

        purchased = true;
        Destroy(unlockText.gameObject);
        Destroy(pointsText.gameObject);
    }
}
