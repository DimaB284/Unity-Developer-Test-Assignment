using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeSpeed = 1f;

    void Start()
    {
        canvasGroup.alpha = 0;
    }

    void Update()
    {
        if (canvasGroup.alpha < 1)
            canvasGroup.alpha += Time.deltaTime * fadeSpeed;
    }
}
