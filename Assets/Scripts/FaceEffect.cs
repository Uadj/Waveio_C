using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FaceEffect : MonoBehaviour
{
    [SerializeField]
    private float fadeTime;
    private TextMeshProUGUI textFade;

    // Start is called before the first frame update
    void Start()
    {
        textFade = GetComponent<TextMeshProUGUI>();
        StartCoroutine("FadeInOut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator FadeInOut()
    {
        while (true)
        {
            yield return StartCoroutine(Fade(1, 0));
            yield return StartCoroutine(Fade(0, 1));
        }
    }
    private IEnumerator Fade(float start, float end)
    {
        float current = 0;
        float percent = 0;
        while(percent < 1)
        {
            current += Time.deltaTime;
            percent = current / fadeTime;
            Color color = textFade.color;
            color.a = Mathf.Lerp(start, end, percent);
            textFade.color = color;
            yield return null;
        }
    }
}
