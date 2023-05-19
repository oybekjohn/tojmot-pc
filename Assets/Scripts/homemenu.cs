using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class homemenu : MonoBehaviour
{
    public Slider myslider;
    public void startgame()
    {
        int a;
        a = Random.Range(1,50);
        myslider.value = a;
        StartCoroutine(ExecuteAfterTime(1));
        a = Random.Range(a, a+50);
        myslider.value = a;
        StartCoroutine(ExecuteAfterTime(2));

        SceneManager.LoadScene("Asosiy");
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
    }
    public void exitgame()
    {
        Application.Quit();
        Debug.Log("O`yindan chiqdi");
    }
}
