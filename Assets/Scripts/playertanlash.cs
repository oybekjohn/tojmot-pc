using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertanlash : MonoBehaviour
{
    public Transform box,boxrangtanlash;
    public CanvasGroup background;

    private void OnEnable()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 0.5f);
        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, 0.5f).setEaseInExpo().delay = 0.1f;

    }
    public void closedialog()
    {
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
    }
    public void pctanlandi()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        asosiykod.p2 = "pc";
        asosiykod.p1image.sprite = asosiykod.playeroq;
        asosiykod.p2image.sprite = asosiykod.pcqora;
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
        boxrangtanlash.gameObject.SetActive(true);
    }
    public void usertanlandi()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        asosiykod.p2 = "user";
        asosiykod.p1image.sprite = asosiykod.playeroq;
        asosiykod.p2image.sprite = asosiykod.playerqora;
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
        boxrangtanlash.gameObject.SetActive(true);
    }
}
