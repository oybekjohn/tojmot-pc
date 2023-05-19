using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donatanlash : MonoBehaviour
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
    public void tanlandi9()
    {
        
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n9.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n9";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n9.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n9";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }

    public void tanlandi2()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n2.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n2";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n2.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n2";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }

    public void tanlandi8()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n8.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n8";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n8.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n8";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }
    public void tanlandi6()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n6.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n6";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n6.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n6";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }
    public void tanlandi5()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n5.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n5";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n5.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n5";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }
    public void tanlandi4()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n4.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n4";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n4.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n4";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }
    public void tanlandi3()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1n3.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1n3";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2n3.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2n3";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }
    public void tanlandif()
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayeralmashadi == "p1")
        {
            asosiykod.almashtirdona.sprite = asosiykod.p1fe.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p1fe";
                }
            }
        }
        else
        {
            asosiykod.almashtirdona.sprite = asosiykod.p2fe.sprite;
            for (int k = 1; k <= 38; k++)
            {
                if (asosiykod.donaevent[k, 1] == asosiykod.almashtirdona.name)
                {
                    asosiykod.donaevent[k, 2] = "p2fe";
                }
            }
        }
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();

    }

}
