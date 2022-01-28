
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour {

    public Image currentImg, nextImg;

    public float transitionTime = 3f;
    public float intervalTime = 30f;
    public Sprite[] backgrounds;

    int bgNum;
    float nextTransitionTime;

    private void Start() {
        bgNum = Random.Range(0, backgrounds.Length);
        currentImg.sprite = backgrounds[bgNum];
        nextTransitionTime = Time.time + intervalTime;
    }

    private void Update() {
        TransitionBackground();
    }

    void TransitionBackground() {
        if(Time.time < nextTransitionTime)
            return;

        //determine next background
        bgNum++;
        if(bgNum >= backgrounds.Length)
            bgNum = 0;

        nextImg.sprite = backgrounds[bgNum];

        nextTransitionTime = Time.time + intervalTime;
        StartCoroutine(FadeBackgrounds());
    }

    IEnumerator FadeBackgrounds() {
        //fade out current background
        //fade in current background

        Color next = nextImg.color, current = currentImg.color;

        while(true) {
            if(nextImg.color.a >= 1f)
                break;
            float t = Time.deltaTime / transitionTime;

            next.a += t;
            nextImg.color = next;

            current.a -= t;
            currentImg.color = current;

            yield return null;
        }

        //make next background current
        currentImg.sprite = nextImg.sprite;

        //swap alphas
        currentImg.color = next;
        nextImg.color = current;

        nextImg.sprite = null;
    }

}
