using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Image))]
public class RainbowImage : MonoBehaviour {

    public float speed;

    Image image;

    private void Awake() {
        image = GetComponent<Image>();
    }

    private void Update() {
        Color.RGBToHSV(image.color, out float H, out float S, out float V);
        H += Time.deltaTime * speed;
        ;
        if(H > 1)
            H = 0;
        image.color = Color.HSVToRGB(H, S, V);
    }
}
