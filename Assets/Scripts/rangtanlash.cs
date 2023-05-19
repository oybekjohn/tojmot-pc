using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangtanlash : MonoBehaviour
{
    public Transform box;
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
    public void oqdonatanlandi()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        asosiykod.p1 = "oq";
        asosiykod.p1image.sprite = asosiykod.playeroq;
        if (asosiykod.p2=="pc")
        {
            asosiykod.p2image.sprite = asosiykod.pcqora;
        }
        else
        {
            asosiykod.p2image.sprite = asosiykod.playerqora;
        }
        

        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
        asosiykod.loaddonalar();
        asosiykod.loadyashillar();
        asosiykod.doskatozala();
        asosiykod.loaddoska();

        //imageObject.GetComponent<Image>().color = tempColor;
    }
    public void qoradonatanlandi()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        asosiykod.p1 = "qora";
        asosiykod.p1image.sprite = asosiykod.playerqora;
        if (asosiykod.p2 == "pc")
        {
            asosiykod.p2image.sprite = asosiykod.pcoq;
        }
        else
        {
            asosiykod.p2image.sprite = asosiykod.playeroq;
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
        asosiykod.selectedplayer = "p2";
        asosiykod.loaddonalar();
        asosiykod.loadyashillar();
        asosiykod.doskatozala();
        asosiykod.loaddoska();
        if (asosiykod.p2 == "pc")
        {
            Donalar donalarkod = GameObject.Find("Canvas").GetComponent<Donalar>();
            
            donalarkod.avtopilot();
        }

    }
}
