
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    public DoorType doorID;

    public int purchaseCost;
    public int scoreWorth = 1;
    public Sprite openSprite, closedSprite;

    public int pointsGenerated = 0;

    Image spriteRenderer;

    public bool Open { get; set; } = false;

    private void Start() {
        spriteRenderer = GetComponent<Image>();
    }

    public void InteractWithDoor() {
        Open = !Open;

        if(Open == true)
            spriteRenderer.sprite = openSprite;
        else {
            spriteRenderer.sprite = closedSprite;
            pointsGenerated += scoreWorth; //times shop multiplier
            ScoreManager.Instance.UpdateScore(doorID);
        }
    }
}
