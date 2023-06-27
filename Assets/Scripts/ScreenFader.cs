using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
    public Image image;
    public float fadeTime = 1;

    void Start(){
        FadeFromBlack();
    }
    
    bool fading = false;
    public void FadeFromBlack(){
        if(fading){
            return;
        }
        fading = true;
        StartCoroutine(FadeFromBlackRoutine());
        IEnumerator FadeFromBlackRoutine(){
            float timer = 0;
            while(timer < fadeTime){
                timer += Time.deltaTime;
                image.color = new Color(0,0,0,1-(timer/fadeTime));
                yield return null;
            }
            image.color = Color.clear;
            yield return null;
            fading = false;
        }
    }

    public void FadeToBlack(string sceneName){
        if(fading){
            return;
        }
        fading = true;
        StartCoroutine(FadeToBlackRoutine());
        IEnumerator FadeToBlackRoutine(){
            float timer = 0;
            while(timer < fadeTime){
                timer += Time.deltaTime;
                image.color = new Color(0,0,0,(timer/fadeTime));
                yield return null;
            }
            image.color = Color.black;
            SceneManager.LoadScene(sceneName);
            yield return null;
        }
        fading = false;
    }
}
