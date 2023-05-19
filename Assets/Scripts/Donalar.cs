using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Donalar : MonoBehaviour
{
    public GameObject imageObject;
    public string obyektnomi;
    public string joybor;
    public int[,] avtopilotyurishlari = new int[500,2];
    public string[,] avtopilotyurishlari2 = new string[500, 2];
    public int avtopilotyurishsoni;
    public string selecteddonanomi;
    public bool tojbor,p2tojbor,p1tojbor, shohtekshir;
    public string til;

    private IEnumerator birozkutish(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
        }
    }
    public void avtopilot()
    {
        StartCoroutine(birozkutish(5.0f));
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        avtopilotyurishsoni = 0;
        int a;
        bool bor, yutqazdi;
        bor = false;
        yutqazdi = false;
        asosiykod.yurdi.Play();

        while (avtopilotyurishsoni==0 && yutqazdi==false)
        {
            //Debug.Log(p2tojbor);
            for (int i = 0; i <= 17; i++)
            {
                for (int j = 0; j <= 14; j++)
                {
                    if (asosiykod.doska[i, j] == "p2r2" || asosiykod.doska[i, j] == "p2r3" || asosiykod.doska[i, j] == "p2r4" || asosiykod.doska[i, j] == "p2r5" || asosiykod.doska[i, j] == "p2r6" || asosiykod.doska[i, j] == "p2r8" || asosiykod.doska[i, j] == "p2r9" || asosiykod.doska[i, j] == "p2n2" || asosiykod.doska[i, j] == "p2n3" || asosiykod.doska[i, j] == "p2n4" || asosiykod.doska[i, j] == "p2n5" || asosiykod.doska[i, j] == "p2n6" || asosiykod.doska[i, j] == "p2n8" || asosiykod.doska[i, j] == "p2n9" || asosiykod.doska[i, j] == "p2x1" || asosiykod.doska[i, j] == "p2x2" || asosiykod.doska[i, j] == "p2fe")
                    {
                        bor = true;
                    }

                }
            }
            if (bor == true)
            {
                bor = false;


                if (p2tojbor == true)
                {
                    a = 18;
                }
                else
                {
                    a = Random.Range(1, 19);
                }
                switch (a)
                {
                    case 1:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r9")
                                {
                                    bor = true;
                                }

                            }
                        }
                        if (bor)
                        {
                            p2r9click();
                        }

                        break;
                    case 2:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r2click();
                        }
                        //p2r2click();
                        break;
                    case 3:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r5")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r5click();
                        }
                        //p2r5click();
                        break;
                    case 4:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r8")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r8click();
                        }
                        //p2r8click();
                        break;
                    case 5:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r6")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r6click();
                        }
                        //p2r6click();
                        break;
                    case 6:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r4")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r4click();
                        }
                        //p2r4click();
                        break;
                    case 7:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r3")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r3click();
                        }
                        //p2r3click();
                        break;
                    case 8:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n9")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n9click();
                        }
                        //p2n9click();
                        break;
                    case 9:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n2click();
                        }
                        //p2n2click();
                        break;
                    case 10:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n5")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n5click();
                        }
                        //p2n5click();
                        break;
                    case 11:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n8")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n8click();
                        }
                        //p2n8click();
                        break;
                    case 12:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n6")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n6click();
                        }
                        //p2n6click();
                        break;
                    case 13:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n4")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n4click();
                        }
                        //p2n4click();
                        break;
                    case 14:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n3")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n3click();
                        }
                        //p2n3click();
                        break;
                    case 15:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2x1")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2x1click();
                        }
                        //p2x1click();
                        break;
                    case 16:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2x2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2x2click();
                        }
                        //p2x2click();
                        break;
                    case 17:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2fe")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2feclick();
                        }
                        //p2feclick();
                        break;
                    case 18:
                        Debug.Log("P2 shoh yurdi");
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2sh")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            //p2tojbor = false;
                            p2shclick();
                        }
                        if (bor == false && p2tojbor == true)
                        {
                            //Debug.Log("P2 yutqazdi");
                            yutqazdi = true;
                            asosiykod.winnerbox.gameObject.SetActive(true);
                            //Application.Quit();
                        }
                        if (p2tojbor==true)
                        {
                            Debug.Log(avtopilotyurishsoni);
                        }
                        if (avtopilotyurishsoni == 0 && p2tojbor == true)
                        {
                            //Debug.Log("P2 yutqazdi");
                            yutqazdi = true;
                            asosiykod.winnerbox.gameObject.SetActive(true);
                        }
                        else
                        {
                            p2tojbor = false;
                        }
                        //p2shclick();
                        break;
                }
            }
            else
            {
                //Debug.Log("P2 yutqazdi");
                yutqazdi = true;
                asosiykod.winnerbox.gameObject.SetActive(true);
            }
        }
        
        if (yutqazdi==false)
        { 
            int b = Random.Range(1, avtopilotyurishsoni);
            switch (avtopilotyurishlari[b,1])
            {
                case 1:
                    movedona("a" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 2:
                    movedona("b" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 3:
                    movedona("c" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 4:
                    movedona("d" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 5:
                    movedona("e" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 6:
                    movedona("f" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 7:
                    movedona("g" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 8:
                    movedona("h" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 9:
                    movedona("i" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 10:
                    movedona("j" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 11:
                    movedona("k" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 12:
                    movedona("l" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 13:
                    movedona("m" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
                case 14:
                    movedona("n" + avtopilotyurishlari[b, 0].ToString(), avtopilotyurishlari[b, 0], avtopilotyurishlari[b, 1]);
                    break;
            }
        }

    }


    public void checkshoh()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        shohtekshir = true;
        tojbor = false;
        bool bor;
        bor = false;
        //Debug.Log(asosiykod.selectedplayer);
        if (asosiykod.selectedplayer == "p2")
        {
            asosiykod.selectedplayer = "p1";
        }
        else
        {
            asosiykod.selectedplayer = "p2";
        }
        for (int a = 1; a < 18; a++)
        {
            if (asosiykod.selectedplayer == "p2")
            {
                switch (a)
                {
                    case 1:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r9")
                                {
                                    bor = true;
                                }

                            }
                        }
                        if (bor)
                        {
                            p2r9click();
                        }

                        break;
                    case 2:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r2click();
                        }
                        //p2r2click();
                        break;
                    case 3:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r5")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r5click();
                        }
                        //p2r5click();
                        break;
                    case 4:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r8")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r8click();
                        }
                        //p2r8click();
                        break;
                    case 5:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r6")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r6click();
                        }
                        //p2r6click();
                        break;
                    case 6:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r4")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r4click();
                        }
                        //p2r4click();
                        break;
                    case 7:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2r3")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2r3click();
                        }
                        //p2r3click();
                        break;
                    case 8:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n9")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n9click();
                        }
                        //p2n9click();
                        break;
                    case 9:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n2click();
                        }
                        //p2n2click();
                        break;
                    case 10:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n5")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n5click();
                        }
                        //p2n5click();
                        break;
                    case 11:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n8")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n8click();
                        }
                        //p2n8click();
                        break;
                    case 12:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n6")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n6click();
                        }
                        //p2n6click();
                        break;
                    case 13:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n4")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n4click();
                        }
                        //p2n4click();
                        break;
                    case 14:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2n3")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2n3click();
                        }
                        //p2n3click();
                        break;
                    case 15:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2x1")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2x1click();
                        }
                        //p2x1click();
                        break;
                    case 16:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2x2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2x2click();
                        }
                        //p2x2click();
                        break;
                    case 17:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2fe")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2feclick();
                        }
                        //p2feclick();
                        break;
                    case 18:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p2sh")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p2shclick();
                        }
                        //p2shclick();
                        break;
                }
            }
            else
            {
                switch (a)
                {
                    case 1:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r9")
                                {
                                    bor = true;
                                }

                            }
                        }
                        if (bor)
                        {
                            p1r9click();
                        }

                        break;
                    case 2:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1r2click();
                        }
                        //p2r2click();
                        break;
                    case 3:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r5")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1r5click();
                        }
                        //p2r5click();
                        break;
                    case 4:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r8")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1r8click();
                        }
                        //p2r8click();
                        break;
                    case 5:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r6")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1r6click();
                        }
                        //p2r6click();
                        break;
                    case 6:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r4")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1r4click();
                        }
                        //p2r4click();
                        break;
                    case 7:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1r3")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1r3click();
                        }
                        //p2r3click();
                        break;
                    case 8:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n9")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n9click();
                        }
                        //p2n9click();
                        break;
                    case 9:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n2click();
                        }
                        //p2n2click();
                        break;
                    case 10:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n5")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n5click();
                        }
                        //p2n5click();
                        break;
                    case 11:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n8")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n8click();
                        }
                        //p2n8click();
                        break;
                    case 12:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n6")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n6click();
                        }
                        //p2n6click();
                        break;
                    case 13:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n4")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n4click();
                        }
                        //p2n4click();
                        break;
                    case 14:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1n3")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1n3click();
                        }
                        //p2n3click();
                        break;
                    case 15:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1x1")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1x1click();
                        }
                        //p2x1click();
                        break;
                    case 16:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1x2")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1x2click();
                        }
                        //p2x2click();
                        break;
                    case 17:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1fe")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1feclick();
                        }
                        //p2feclick();
                        break;
                    case 18:
                        for (int i = 0; i <= 17; i++)
                        {
                            for (int j = 0; j <= 14; j++)
                            {
                                if (asosiykod.doska[i, j] == "p1sh")
                                {
                                    bor = true;
                                }
                            }
                        }
                        if (bor)
                        {
                            p1shclick();
                        }
                        //p2shclick();
                        break;
                }
            }
        }
        if (asosiykod.selectedplayer == "p2")
        {
            asosiykod.selectedplayer = "p1";
        }
        else
        {
            asosiykod.selectedplayer = "p2";
        }
        shohtekshir = false;
        if (tojbor==true && asosiykod.selectedplayer=="p2")
        {
            Debug.Log("P2 da Toj bor");
            p2tojbor=true;
            
        }
        if (tojbor == true && asosiykod.selectedplayer == "p1")
        {
            Debug.Log("P1 da Toj bor");
            p1tojbor = true;
        }
        


    }


    public void p1r2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer=="p1")
        {
            asosiykod.selecteddona = asosiykod.p1r2;
            joynianiqlash("p1r2");
        }
    }
    public void p1r3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1r3;
            joynianiqlash("p1r3");
        }
    }
    public void p1r4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1r4;
            joynianiqlash("p1r4");
        }
    }
    public void p1r5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1r5;
            joynianiqlash("p1r5");
        }
    }
    public void p1r6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1r6;
            joynianiqlash("p1r6");
        }
    }
    public void p1r8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1r8;
            joynianiqlash("p1r8");
        }
    }
    public void p1r9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1r9;
            joynianiqlash("p1r9");
        }
    }
    public void p1n2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n2;
            joynianiqlash("p1n2");
        }
    }
    public void p1n3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n3;
            joynianiqlash("p1n3");
        }
    }
    public void p1n4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n4;
            joynianiqlash("p1n4");
        }
    }
    public void p1n5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n5;
            joynianiqlash("p1n5");
        }
    }
    public void p1n6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n6;
            joynianiqlash("p1n6");
        }
    }
    public void p1n8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n8;
            joynianiqlash("p1n8");
        }
    }
    public void p1n9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1n9;
            joynianiqlash("p1n9");
        }
    }
    public void p1x1click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1x1;
            joynianiqlash("p1x1");
        }
    }
    public void p1x2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1x2;
            joynianiqlash("p1x2");
        }
    }
    public void p1feclick()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1fe;
            joynianiqlash("p1fe");
        }
    }
    public void p1shclick()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p1")
        {
            asosiykod.selecteddona = asosiykod.p1sh;
            joynianiqlash("p1sh");
        }
    }

    public void p2r2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r2;
            joynianiqlash("p2r2");
        }
    }
    public void p2r3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r3;
            joynianiqlash("p2r3");
        }
    }
    public void p2r4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r4;
            joynianiqlash("p2r4");
        }
    }
    public void p2r5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r5;
            joynianiqlash("p2r5");
        }
    }
    public void p2r6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r6;
            joynianiqlash("p2r6");
        }
    }
    public void p2r8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r8;
            joynianiqlash("p2r8");
        }
    }
    public void p2r9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2r9;
            joynianiqlash("p2r9");
        }
    }
    public void p2n2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n2;
            joynianiqlash("p2n2");
        }
    }
    public void p2n3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n3;
            joynianiqlash("p2n3");
        }
    }
    public void p2n4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n4;
            joynianiqlash("p2n4");
        }
    }
    public void p2n5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n5;
            joynianiqlash("p2n5");
        }
    }
    public void p2n6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n6;
            joynianiqlash("p2n6");
        }
    }
    public void p2n8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n8;
            joynianiqlash("p2n8");
        }
    }
    public void p2n9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2n9;
            joynianiqlash("p2n9");
        }
    }
    public void p2x1click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2x1;
            joynianiqlash("p2x1");
        }
    }
    public void p2x2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2x2;
            joynianiqlash("p2x2");
        }
    }
    public void p2feclick()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2fe;
            joynianiqlash("p2fe");
        }
    }
    public void p2shclick()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.timer1 == false && asosiykod.timer2 == false && asosiykod.selectedplayer == "p2")
        {
            asosiykod.selecteddona = asosiykod.p2sh;
            joynianiqlash("p2sh");
        }
    }

    void joynianiqlash(string nom)
    {
        //asosiykod.selectedplayer = "p1";
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();

        if (asosiykod.selectedplayer == string.Concat(nom[0], nom[1]))
        {


            if (asosiykod.timer1 == false)
            {
                asosiykod.x = 0;
                asosiykod.y = 0;
                for (int i = 1; i <= 17; i++)
                {
                    for (int j = 1; j <= 14; j++)
                    {
                        if (asosiykod.doska[i, j] == nom)
                        {

                            asosiykod.x = i;
                            asosiykod.y = j;
                            j = 14;
                            i = 17;
                        }
                    }
                }
                asosiykod.selectedsatr = asosiykod.x;
                asosiykod.selectedustun = asosiykod.y;
                yurishjoylari(nom, asosiykod.x, asosiykod.y);


                //yashilchiqar(asosiykod.x, asosiykod.y);
            }
        }

    }

    void yurishjoylari(string nom, int satr, int ustun)
    {
        tojbor = false;
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        asosiykod.doskatozala();
        int tempsatr, tempustun;
        joybor = "no";
        for (int i = 1; i <= 38; i++)
        {
            if (asosiykod.donaevent[i, 1] == nom)
            {
                nom = asosiykod.donaevent[i, 2];
            }
        }
        selecteddonanomi = nom;
        char qarshitomon;
        if (asosiykod.selectedplayer == "p1")
        {
            qarshitomon = '2';
        }
        else
        {
            qarshitomon = '1';
        }
        switch (nom)
        {
            case "p1r9": case "p1r2": case "p1r5": case "p1r8": case "p1r6": case "p1r4": case "p1r3": case "p1x1": case "p1x2":
                if (satr-1 > 0 && ustun-1 > 0)
                {
                    yashilchiqar(satr - 1, ustun - 1);
                }
                if (satr-1 > 0 && ustun+1 < 15)
                {
                    yashilchiqar(satr - 1, ustun + 1);
                }
                break;

            case "p1n9": case "p2n9":
                if (satr - 1 > 0 && ustun - 1 > 0)
                {
                    yashilchiqar(satr - 1, ustun - 1);
                }
                if (satr -1 > 0 && ustun +1 < 15)
                {
                    yashilchiqar(satr - 1, ustun + 1);
                }
                if (satr +1 < 18 && ustun -1 > 0)
                {
                    yashilchiqar(satr + 1, ustun - 1);
                }
                if (satr +1 < 18 && ustun +1 < 15)
                {
                    yashilchiqar(satr + 1, ustun + 1);
                }

                if (satr > 2)
                {
                    yashilchiqar(satr - 2, ustun);
                }
                if (satr< 16)
                {
                    yashilchiqar(satr + 2, ustun);
                }
                if (ustun > 2)
                {
                    yashilchiqar(satr, ustun - 2);
                }
                if (ustun< 13)
                {
                    yashilchiqar(satr, ustun + 2);
                }
                break;

            case "p1n2": case "p2n2":
                if (satr< 13)
                {
                    for (int i = satr+2; i <= satr+4; i = i + 2)
                    {
                        if (asosiykod.doska[i, ustun] == "empty" || asosiykod.doska[i, ustun][1] == qarshitomon)
                        {
                            yashilchiqar(i, ustun);
                            if (asosiykod.doska[i, ustun][1] == qarshitomon)
                            {
                                i = 15;
                            }
                        }
                        else
                        {
                            i = 15;
                        }
                    }
                }
                if (satr > 4)
                {
                    for (int i = satr - 2; i >= satr - 4; i = i - 2)
                    {
                        if (asosiykod.doska[i, ustun] == "empty" || asosiykod.doska[i, ustun][1] == qarshitomon)
                        {
                            yashilchiqar(i, ustun);
                            if (asosiykod.doska[i, ustun][1] == qarshitomon)
                            {
                                i = 3;
                            }
                        }
                        else
                        {
                            i = 3;
                        }
                    }
                }
                if (ustun < 12)
                {
                    for (int i = ustun + 2; i <= ustun + 4; i = i + 2)
                    {
                        if (asosiykod.doska[satr, i] == "empty" || asosiykod.doska[satr, i][1] == qarshitomon)
                        {
                            yashilchiqar(satr, i);
                            if (asosiykod.doska[satr, i][1] == qarshitomon)
                            {
                                i = 14;
                            }
                        }
                        else
                        {
                            i = 14;
                        }
                    }
                }
                if (ustun > 4)
                {
                    for (int i = ustun - 2; i >= ustun - 4; i = i - 2)
                    {
                        if (asosiykod.doska[satr, i] == "empty" || asosiykod.doska[satr, i][1] == qarshitomon)
                        {
                            yashilchiqar(satr, i);
                            if (asosiykod.doska[satr, i][1] == qarshitomon)
                            {
                                i = 1;
                            }
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                }
                break;

            case "p1n5": case "p2n5":
                if (satr -2 > 0 && ustun -2 > 0)
                {
                    yashilchiqar(satr - 2, ustun - 2);
                }
                if (satr -2 > 0 && ustun +2 < 15)
                {
                    yashilchiqar(satr - 2, ustun + 2);
                }
                if (satr +2 < 17 && ustun -2 > 0)
                {
                    yashilchiqar(satr + 2, ustun - 2);
                }
                if (satr +2 < 17 && ustun +2 < 15)
                {
                    yashilchiqar(satr + 2, ustun + 2);
                }
                break;

            case "p1n8": case "p2n8":
                tempsatr = satr;
                tempustun = ustun;
                if (satr >= 3)
                {
                    for (int i = satr - 1; i >= 1; i = i - 1)
                    {
                        tempustun = tempustun - 1;
                        if (tempustun > 0)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 1;
                                }
                            }
                            else
                            {
                                i = 1;
                            }
                        }
                    }
                }
                tempustun = ustun;
                if (satr >= 3)
                {
                    for (int i = satr - 1; i >= 1; i = i - 1)
                    {
                        tempustun = tempustun + 1;
                        if (tempustun < 15)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 1;
                                }
                            }
                            else
                            {
                                i = 1;
                            }
                        }
                    }
                }
                tempustun = ustun;
                if (satr < 14)
                {
                    for (int i = satr + 1; i <= 14; i++)
                    {
                        tempustun = tempustun - 1;
                        if (tempustun >0)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 17;
                                }
                            }
                            else
                            {
                                i = 17;
                            }
                        }
                    }
                }
                tempustun = ustun;
                if (satr < 14)
                {
                    for (int i = satr + 1; i <= 14; i++)
                    {
                        tempustun = tempustun + 1;
                        if (tempustun <15)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 17;
                                }
                            }
                            else
                            {
                                i = 17;
                            }
                        }
                    }
                }
                break;

            case "p1n6": case "p2n6":
                if (satr - 4 > 0 && ustun - 2 > 0)
                {
                    yashilchiqar(satr - 4, ustun - 2);
                }
                if (satr -4 > 0 && ustun +2 < 15)
                {
                    yashilchiqar(satr - 4, ustun + 2);
                }
                if (satr +4 < 16 && ustun -2 > 0)
                {
                    yashilchiqar(satr + 4, ustun - 2);
                }
                if (satr +4 < 16 && ustun +2 < 15)
                {
                    yashilchiqar(satr + 4, ustun + 2);
                }

                if (satr -2 > 0 && ustun -4 > 0)
                {
                    yashilchiqar(satr - 2, ustun - 4);
                }
                if (satr -2 > 0 && ustun +4 < 15)
                {
                    yashilchiqar(satr - 2, ustun + 4);
                }
                if (satr +2 < 16 && ustun -4 > 0)
                {
                    yashilchiqar(satr + 2, ustun - 4);
                }
                if (satr +2 < 16 && ustun +4 < 15)
                {
                    yashilchiqar(satr + 2, ustun + 4);
                }
                break;

            case "p1n4": case "p2n4":
                if (satr< 13)
                {
                    for (int i = satr + 2; i <= 14; i=i+2)
                    {
                        if (asosiykod.doska[i, ustun] == "bir" || asosiykod.doska[i, ustun] == "empty" || asosiykod.doska[i, ustun][1] == qarshitomon)
                        {
                            yashilchiqar(i, ustun);
                            if (asosiykod.doska[i, ustun][1] == qarshitomon)
                            {
                                i = 15;
                            }
                        }
                        else
                        {
                            i = 15;
                        }
                    }
                }
                if (satr >=3)
                {
                    for (int i = satr - 2; i >= 1; i = i - 2)
                    {
                        if (asosiykod.doska[i, ustun] == "bir" || asosiykod.doska[i, ustun] == "empty" || asosiykod.doska[i, ustun][1] == qarshitomon)
                        {
                            yashilchiqar(i, ustun);
                            if (asosiykod.doska[i, ustun][1] == qarshitomon)
                            {
                                i = 1;
                            }
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                }
                if (ustun < 13)
                {
                    for (int i = ustun + 2; i <= 14; i = i + 2)
                    {
                        if (asosiykod.doska[satr, i] == "bir" || asosiykod.doska[satr, i] == "empty" || asosiykod.doska[satr, i][1] == qarshitomon)
                        {
                            yashilchiqar(satr, i);
                            if (asosiykod.doska[satr, i][1] == qarshitomon)
                            {
                                i = 15;
                            }
                        }
                        else
                        {
                            i = 15;
                        }
                    }
                }
                if (ustun >3)
                {
                    for (int i = ustun - 2; i >= 1; i = i - 2)
                    {
                        if (asosiykod.doska[satr, i] == "bir" || asosiykod.doska[satr, i] == "empty" || asosiykod.doska[satr, i][1] == qarshitomon)
                        {
                            yashilchiqar(satr, i);
                            if (asosiykod.doska[satr, i][1] == qarshitomon)
                            {
                                i = 1;
                            }
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                }
                break;

            case "p1n3": case "p2n3":
                if (satr -3 > 0 && ustun -1 > 0)
                {
                    yashilchiqar(satr - 3, ustun - 1);
                }
                if (satr -3 > 0 && ustun +1 < 15)
                {
                    yashilchiqar(satr - 3, ustun + 1);
                }
                if (satr +3 < 16 && ustun -1 > 0)
                {
                    yashilchiqar(satr + 3, ustun - 1);
                }
                if (satr +3 < 16 && ustun +1 < 15)
                {
                    yashilchiqar(satr + 3, ustun + 1);
                }

                if (satr -1 > 0 && ustun -3 > 0)
                {
                    yashilchiqar(satr - 1, ustun - 3);
                }
                if (satr -1 > 0 && ustun +3 < 15)
                {
                    yashilchiqar(satr - 1, ustun + 3);
                }
                if (satr +1 < 16 && ustun -3 > 0)
                {
                    yashilchiqar(satr + 1, ustun - 3);
                }
                if (satr +1 < 16 && ustun +3 < 15)
                {
                    yashilchiqar(satr + 1, ustun + 3);
                }
                break;

            case "p1sh": case "p2sh":
                if (satr -1 > 0 && ustun -1 > 0)
                {
                    yashilchiqar(satr - 1, ustun - 1);
                }
                if (satr -1 > 0 && ustun +1 < 15)
                {
                    yashilchiqar(satr - 1, ustun + 1);
                }
                if (satr +1 < 18 && ustun -1 > 0)
                {
                    yashilchiqar(satr + 1, ustun - 1);
                }
                if (satr +1 < 18 && ustun +1 < 15)
                {
                    yashilchiqar(satr + 1, ustun + 1);
                }

                if (satr > 2)
                {
                    yashilchiqar(satr - 2, ustun);
                }
                if (satr< 16)
                {
                    yashilchiqar(satr + 2, ustun);
                }
                if (ustun > 2)
                {
                    yashilchiqar(satr, ustun - 2);
                }
                if (ustun< 13)
                {
                    yashilchiqar(satr, ustun + 2);
                }
                break;

            case "p1fe": case "p2fe":
                tempsatr = satr;
                tempustun = ustun;
                if (satr >= 3)
                {
                    for (int i = satr - 1; i >= 1; i = i - 1)
                    {
                        tempustun = tempustun - 1;
                        if (tempustun > 0)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 1;
                                }
                            }
                            else
                            {
                                i = 1;
                            }
                        }
                    }
                }
                tempustun = ustun;
                if (satr >= 3)
                {
                    for (int i = satr - 1; i >= 1; i = i - 1)
                    {
                        tempustun = tempustun + 1;
                        if (tempustun <15)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 1;
                                }
                            }
                            else
                            {
                                i = 1;
                            }
                        }
                    }
                }
                tempustun = ustun;
                if (satr <14)
                {
                    for (int i = satr + 1; i <= 14; i = i + 1)
                    {
                        tempustun = tempustun - 1;
                        if (tempustun >0)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 17;
                                }
                            }
                            else
                            {
                                i = 17;
                            }
                        }
                    }
                }
                tempustun = ustun;
                if (satr < 14)
                {
                    for (int i = satr + 1; i <= 14; i = i + 1)
                    {
                        tempustun = tempustun + 1;
                        if (tempustun <15)
                        {
                            if (asosiykod.doska[i, tempustun] == "bir" || asosiykod.doska[i, tempustun] == "empty" || asosiykod.doska[i, tempustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, tempustun);
                                if (asosiykod.doska[i, tempustun][1] == qarshitomon)
                                {
                                    i = 17;
                                }
                            }
                            else
                            {
                                i = 17;
                            }
                        }
                    }
                }
                if (satr < 13)
                {
                    for (int i = satr + 2; i <= 15; i = i + 2)
                    {
                        if (asosiykod.doska[i, ustun] == "bir" || asosiykod.doska[i, ustun] == "empty" || asosiykod.doska[i, ustun][1] == qarshitomon)
                            {
                                yashilchiqar(i, ustun);
                                if (asosiykod.doska[i, ustun][1] == qarshitomon)
                                {
                                    i = 15;
                                }
                        }
                            else
                            {
                                i = 15;
                            }
                    }
                }
                if (satr >=3)
                {
                    for (int i = satr - 2; i >= 1; i = i - 2)
                    {
                        if (asosiykod.doska[i, ustun] == "bir" || asosiykod.doska[i, ustun] == "empty" || asosiykod.doska[i, ustun][1] == qarshitomon)
                        {
                            yashilchiqar(i, ustun);
                            if (asosiykod.doska[i, ustun][1] == qarshitomon)
                            {
                                i = 1;
                            }
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                }
                if (ustun < 13)
                {
                    for (int i = ustun + 2; i <= 14; i = i + 2)
                    {
                        if (asosiykod.doska[satr, i] == "bir" || asosiykod.doska[satr, i] == "empty" || asosiykod.doska[satr, i][1] == qarshitomon)
                        {
                            yashilchiqar(satr, i);
                            if (asosiykod.doska[satr, i][1] == qarshitomon)
                            {
                                i = 14;
                            }
                        }
                        else
                        {
                            i = 14;
                        }
                    }
                }
                if (ustun > 3)
                {
                    for (int i = ustun - 2; i >= 1; i = i - 2)
                    {
                        if (asosiykod.doska[satr, i] == "bir" || asosiykod.doska[satr, i] == "empty" || asosiykod.doska[satr, i][1] == qarshitomon)
                        {
                            yashilchiqar(satr, i);
                            if (asosiykod.doska[satr, i][1] == qarshitomon)
                            {
                                i = 1;
                            }
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                }
                break;



            case "p2r9": case "p2r2": case "p2r5": case "p2r8": case "p2r6": case "p2r4": case "p2r3": case "p2x1": case "p2x2":
                if (satr +1 < 18 && ustun -1 > 0)
                {
                    yashilchiqar(satr + 1, ustun - 1);
                }
                if (satr +1 < 18 && ustun +1 < 15)
                {
                    yashilchiqar(satr + 1, ustun + 1);
                }
                break;
        }
        if (shohtekshir == false)
        {
            if (asosiykod.selectedplayer == "p2" && asosiykod.p2 == "pc" && joybor == "no")
            {
                avtopilot();
            }
        }


    }

    void yashilchiqar(int satr, int ustun)
    {

        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        

        obyektnomi = "";
        switch (ustun)
        {
            case 1:
                obyektnomi = string.Concat("a", satr.ToString());
                break;
            case 2:
                obyektnomi = string.Concat("b", satr.ToString());
                break;
            case 3:
                obyektnomi = string.Concat("c", satr.ToString());
                break;
            case 4:
                obyektnomi = string.Concat("d", satr.ToString());
                break;
            case 5:
                obyektnomi = string.Concat("e", satr.ToString());
                break;
            case 6:
                obyektnomi = string.Concat("f", satr.ToString());
                break;
            case 7:
                obyektnomi = string.Concat("g", satr.ToString());
                break;
            case 8:
                obyektnomi = string.Concat("h", satr.ToString());
                break;
            case 9:
                obyektnomi = string.Concat("i", satr.ToString());
                break;
            case 10:
                obyektnomi = string.Concat("j", satr.ToString());
                break;
            case 11:
                obyektnomi = string.Concat("k", satr.ToString());
                break;
            case 12:
                obyektnomi = string.Concat("l", satr.ToString());
                break;
            case 13:
                obyektnomi = string.Concat("m", satr.ToString());
                break;
            case 14:
                obyektnomi = string.Concat("n", satr.ToString());
                break;
        }
        //obyektnomi = "c5";
        char qarshitomon;
        if (asosiykod.selectedplayer == "p1")
        {
            qarshitomon = '2';
        }
        else
        {
            qarshitomon = '1';
        }
        
        if (shohtekshir == true)
        {
            shohbormi(satr, ustun);
            if (asosiykod.doska[satr, ustun] == "empty" || asosiykod.doska[satr, ustun] == "bir")
            {
                asosiykod.doska[satr, ustun] = "soya";
            }

        }
        else
        {
            if ((asosiykod.doska[satr, ustun] == "empty" || asosiykod.doska[satr, ustun][1] == qarshitomon) && asosiykod.doska[satr, ustun] != "p1sh" && asosiykod.doska[satr, ustun] != "p2sh")
            {
                imageObject = GameObject.Find(obyektnomi);
                imageObject.transform.SetAsLastSibling();
                var tempColor = imageObject.GetComponent<Image>().color;
                tempColor.a = 1f;
                imageObject.GetComponent<Image>().color = tempColor;
                joybor = "bor";
                if (asosiykod.selectedplayer == "p2" && asosiykod.p2 == "pc")
                {
                    avtopilotyurishsoni++;
                    avtopilotyurishlari[avtopilotyurishsoni, 0] = satr;
                    avtopilotyurishlari[avtopilotyurishsoni, 1] = ustun;
                    avtopilotyurishlari2[avtopilotyurishsoni, 1] = asosiykod.doska[satr, ustun];

                }
            }
            if ((selecteddonanomi == "p1sh" || selecteddonanomi == "p2sh") && (asosiykod.doska[satr, ustun] == "bir" || asosiykod.doska[satr, ustun][1] == qarshitomon))
            {
                imageObject = GameObject.Find(obyektnomi);
                imageObject.transform.SetAsLastSibling();
                var tempColor = imageObject.GetComponent<Image>().color;
                tempColor.a = 1f;
                imageObject.GetComponent<Image>().color = tempColor;
                joybor = "bor";
                if (asosiykod.selectedplayer == "p2" && asosiykod.p2 == "pc")
                {
                    avtopilotyurishsoni++;
                    avtopilotyurishlari[avtopilotyurishsoni, 0] = satr;
                    avtopilotyurishlari[avtopilotyurishsoni, 1] = ustun;

                }
            }
        }
        /*if (asosiykod.doska[17, 7] == "empty")
        {
            asosiykod.doska[17, 7] = "bir";
        }
        if (asosiykod.doska[16, 6] == "empty")
        {
            asosiykod.doska[16, 6] = "bir";
        }
        if (asosiykod.doska[16, 8] == "empty")
        {
            asosiykod.doska[16, 8] = "bir";
        }
        if (asosiykod.doska[1, 7] == "empty")
        {
            asosiykod.doska[1, 7] = "bir";
        }
        if (asosiykod.doska[2, 6] == "empty")
        {
            asosiykod.doska[2, 6] = "bir";
        }
        if (asosiykod.doska[2, 8] == "empty")
        {
            asosiykod.doska[2, 8] = "bir";
        }
        */



    }

    public void shohbormi(int satr, int ustun)
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.doska[satr, ustun] == "p2sh" || asosiykod.doska[satr, ustun][0] == 's' && asosiykod.doska[satr, ustun][1] == 'h')
        {
            tojbor = true;
            p2tojbor = true;
        }
        if (asosiykod.doska[satr, ustun] == "p1sh" || asosiykod.doska[satr, ustun][0] == 's' && asosiykod.doska[satr, ustun][1] == 'h')
        {
            tojbor = true;
            p1tojbor = true;
        }
    }

    public void c5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("c5");
        
        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("c5", 5, 3);
        }
       
    }

    public void b12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("b12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("b12", 12, 2);
        }

    }

    public void d12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("d12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("d12", 12, 4);
        }

    }
    public void g1click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g1");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g1", 1, 7);
        }

    }
    public void h2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h2");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h2", 2, 8);
        }

    }
    public void f2click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f2");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f2", 2, 6);
        }

    }
    public void i3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i3");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i3", 3, 9);
        }

    }
    public void g3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g3");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g3", 3, 7);
        }

    }
    public void e3click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e3");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e3", 3, 5);
        }

    }

    public void g17click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g17");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g17", 17, 7);
        }

    }
    public void h16click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h16");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h16", 16, 8);
        }

    }
    public void f16click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f16");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f16", 16, 6);
        }

    }
    public void i15click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i15");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i15", 15, 9);
        }

    }
    public void g15click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g15");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g15", 15, 7);
        }

    }
    public void e15click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e15");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e15", 15, 5);
        }

    }
    public void m13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("m13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("m13", 13, 13);
        }

    }
    public void k13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("k13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("k13", 13, 11);
        }

    }
    public void i13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i13", 13, 9);
        }

    }
    public void g13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g13", 13, 7);
        }

    }
    public void e13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e13", 13, 5);
        }

    }
    public void c13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("c13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("c13", 13, 3);
        }

    }
    public void a13click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("a13");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("a13", 13, 1);
        }

    }

    public void m11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("m11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("m11", 11, 13);
        }

    }
    public void k11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("k11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("k11", 11, 11);
        }

    }
    public void i11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i11", 11, 9);
        }

    }
    public void g11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g11", 11, 7);
        }

    }
    public void e11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e11", 11, 5);
        }

    }
    public void c11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("c11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("c11", 11, 3);
        }

    }
    public void a11click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("a11");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("a11", 11, 1);
        }

    }

    public void m9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("m9");

        var tempColor = imageObject.GetComponent<Image>().color;
        if (tempColor.a == 1f)
        {
            movedona("m9", 9, 13);
        }

    }
    public void k9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("k9");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("k9", 9, 11);
        }

    }
    public void i9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i9");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i9", 9, 9);
        }

    }
    public void g9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g9");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g9", 9, 7);
        }

    }
    public void e9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e9");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e9", 9, 5);
        }

    }
    public void c9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("c9");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("c9", 9, 3);
        }

    }
    public void a9click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("a9");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("a9", 9, 1);
        }

    }

    public void m7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("m7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("m7", 7, 13);
        }

    }
    public void k7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("k7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("k7", 7, 11);
        }

    }
    public void i7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i7", 7, 9);
        }

    }
    public void g7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g7", 7, 7);
        }

    }
    public void e7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e7", 7, 5);
        }

    }
    public void c7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("c7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("c7", 7, 3);
        }

    }
    public void a7click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("a7");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("a7", 7, 1);
        }

    }

    public void m5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("m5");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("m5", 5, 13);
        }

    }
    public void k5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("k5");

        var tempColor = imageObject.GetComponent<Image>().color;
        if (tempColor.a == 1f)
        {
            movedona("k5", 5, 11);
        }

    }
    public void i5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("i5");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("i5", 5, 9);
        }

    }
    public void g5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("g5");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("g5", 5, 7);
        }

    }
    public void e5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("e5");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("e5", 5, 5);
        }

    }
    public void a5click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("a5");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("a5", 5, 1);
        }

    }

    public void n4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("n4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("n4", 4, 14);
        }

    }

    public void l4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("l4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("l4", 4, 12);
        }

    }
    public void j4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("j4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("j4", 4, 10);
        }

    }
    public void h4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h4", 4, 8);
        }

    }
    public void f4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f4", 4, 6);
        }

    }
    public void d4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("d4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("d4", 4, 4);
        }

    }
    public void b4click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("b4");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("b4", 4, 2);
        }

    }

    public void n6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("n6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("n6", 6, 14);
        }

    }

    public void l6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("l6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("l6", 6, 12);
        }

    }
    public void j6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("j6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("j6", 6, 10);
        }

    }
    public void h6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h6", 6, 8);
        }

    }
    public void f6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f6", 6, 6);
        }

    }
    public void d6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("d6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("d6", 6, 4);
        }

    }
    public void b6click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("b6");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("b6", 6, 2);
        }

    }

    public void n8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("n8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("n8", 8, 14);
        }

    }

    public void l8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("l8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("l8", 8, 12);
        }

    }
    public void j8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("j8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("j8", 8, 10);
        }

    }
    public void h8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h8", 8, 8);
        }

    }
    public void f8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f8", 8, 6);
        }

    }
    public void d8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("d8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("d8", 8, 4);
        }

    }
    public void b8click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("b8");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("b8", 8, 2);
        }

    }

    public void n10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("n10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("n10", 10, 14);
        }

    }

    public void l10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("l10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("l10", 10, 12);
        }

    }
    public void j10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("j10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("j10", 10, 10);
        }

    }
    public void h10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h10", 10, 8);
        }

    }
    public void f10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f10", 10, 6);
        }

    }
    public void d10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("d10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("d10", 10, 4);
        }

    }
    public void b10click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("b10");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("b10", 10, 2);
        }

    }

    public void n12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("n12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("n12", 12, 14);
        }

    }

    public void l12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("l12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("l12", 12, 12);
        }

    }
    public void j12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("j12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("j12", 12, 10);
        }

    }
    public void h12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h12", 12, 8);
        }

    }
    public void f12click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f12");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f12", 12, 6);
        }

    }

    public void n14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("n14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("n14", 14, 14);
        }

    }

    public void l14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("l14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("l14", 14, 12);
        }

    }
    public void j14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("j14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("j14", 14, 10);
        }

    }
    public void h14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("h14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("h14", 14, 8);
        }

    }
    public void f14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("f14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("f14", 14, 6);
        }

    }
    public void d14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("d14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            movedona("d14", 14, 4);
        }

    }
    public void b14click()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        imageObject = GameObject.Find("b14");

        var tempColor = imageObject.GetComponent<Image>().color;

        if (tempColor.a == 1f)
        {
            //movedona("b14", 14, 2, mywidth, myheight, mytop, myleft);
            movedona("b14", 14, 2);
        }

    }

    Sprite getsprite(string nomi)
    {
        Sprite rasm;
        
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        rasm = asosiykod.olditransparent;
        if (asosiykod.p1 == "oq")
        {
            switch (nomi)
            {
                case "p2sh":
                    rasm = asosiykod.qora1;
                    break;
                case "p2x1":
                    rasm = asosiykod.qorax1;
                    break;
                case "p2x2":
                    rasm = asosiykod.qorax2;
                    break;
                case "p2fe":
                    rasm = asosiykod.qorash;
                    break;
                case "p2n2":
                    rasm = asosiykod.qora2;
                    break;
                case "p2n3":
                    rasm = asosiykod.qora3;
                    break;
                case "p2n4":
                    rasm = asosiykod.qora4;
                    break;
                case "p2n5":
                    rasm = asosiykod.qora5;
                    break;
                case "p2n6":
                    rasm = asosiykod.qora6;
                    break;
                case "p2n8":
                    rasm = asosiykod.qora8;
                    break;
                case "p2n9":
                    rasm = asosiykod.qora9;
                    break;
                case "p2r2":
                    rasm = asosiykod.qora2r;
                    break;
                case "p2r3":
                    rasm = asosiykod.qora3r;
                    break;
                case "p2r4":
                    rasm = asosiykod.qora4r;
                    break;
                case "p2r5":
                    rasm = asosiykod.qora5r;
                    break;
                case "p2r6":
                    rasm = asosiykod.qora6r;
                    break;
                case "p2r8":
                    rasm = asosiykod.qora8r;
                    break;
                case "p2r9":
                    rasm = asosiykod.qora9r;
                    break;
            }
        }
        else
        {
            switch (nomi)
            {
                case "p2sh":
                    rasm = asosiykod.oq1;
                    break;
                case "p2x1":
                    rasm = asosiykod.oqx1;
                    break;
                case "p2x2":
                    rasm = asosiykod.oqx2;
                    break;
                case "p2fe":
                    rasm = asosiykod.oqsh;
                    break;
                case "p2n2":
                    rasm = asosiykod.oq2;
                    break;
                case "p2n3":
                    rasm = asosiykod.oq3;
                    break;
                case "p2n4":
                    rasm = asosiykod.oq4;
                    break;
                case "p2n5":
                    rasm = asosiykod.oq5;
                    break;
                case "p2n6":
                    rasm = asosiykod.oq6;
                    break;
                case "p2n8":
                    rasm = asosiykod.oq8;
                    break;
                case "p2n9":
                    rasm = asosiykod.oq9;
                    break;
                case "p2r2":
                    rasm = asosiykod.oq2r;
                    break;
                case "p2r3":
                    rasm = asosiykod.oq3r;
                    break;
                case "p2r4":
                    rasm = asosiykod.oq4r;
                    break;
                case "p2r5":
                    rasm = asosiykod.oq5r;
                    break;
                case "p2r6":
                    rasm = asosiykod.oq6r;
                    break;
                case "p2r8":
                    rasm = asosiykod.oq8r;
                    break;
                case "p2r9":
                    rasm = asosiykod.oq9r;
                    break;
            }
        }
        return rasm;
    }
    void movedona(string yashil, int satr, int ustun)
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();

        char qarshitomon;
        if (asosiykod.selectedplayer == "p1")
        {
            qarshitomon = '2';
        }
        else
        {
            qarshitomon = '1';
        }
        //Debug.Log(satr.ToString()+"  "+ustun.ToString()+"   "+ asosiykod.doska[satr, ustun]);
        if (asosiykod.doska[satr, ustun][1] == qarshitomon)
        {
            string deletedobyektnomi = asosiykod.doska[satr, ustun];
            asosiykod.deleteddona = GameObject.Find(deletedobyektnomi).GetComponent<Image>();
            if (asosiykod.selectedplayer == "p1")
            {
                asosiykod.p1oldisoni++;
                Debug.Log(getsprite(deletedobyektnomi));
                switch (asosiykod.p1oldisoni)
                {
                    case 1:
                        asosiykod.p1oldi1.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 2:
                        asosiykod.p1oldi2.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 3:
                        asosiykod.p1oldi3.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 4:
                        asosiykod.p1oldi4.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 5:
                        asosiykod.p1oldi5.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 6:
                        asosiykod.p1oldi6.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 7:
                        asosiykod.p1oldi7.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 8:
                        asosiykod.p1oldi8.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 9:
                        asosiykod.p1oldi9.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 10:
                        asosiykod.p1oldi10.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 11:
                        asosiykod.p1oldi11.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 12:
                        asosiykod.p1oldi12.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 13:
                        asosiykod.p1oldi13.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 14:
                        asosiykod.p1oldi14.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 15:
                        asosiykod.p1oldi15.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 16:
                        asosiykod.p1oldi16.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 17:
                        asosiykod.p1oldi17.sprite = getsprite(deletedobyektnomi);
                        break;
                    case 18:
                        asosiykod.p1oldi18.sprite = getsprite(deletedobyektnomi);
                        break;
                }
            }
            else
            {
                asosiykod.p2oldisoni++;
                switch (asosiykod.p2oldisoni)
                {
                    case 1:
                        asosiykod.p2oldi1.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 2:
                        asosiykod.p2oldi2.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 3:
                        asosiykod.p2oldi3.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 4:
                        asosiykod.p2oldi4.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 5:
                        asosiykod.p2oldi5.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 6:
                        asosiykod.p2oldi6.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 7:
                        asosiykod.p2oldi7.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 8:
                        asosiykod.p2oldi8.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 9:
                        asosiykod.p2oldi9.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 10:
                        asosiykod.p2oldi10.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 11:
                        asosiykod.p2oldi11.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 12:
                        asosiykod.p2oldi12.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 13:
                        asosiykod.p2oldi13.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 14:
                        asosiykod.p2oldi14.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 15:
                        asosiykod.p2oldi15.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 16:
                        asosiykod.p2oldi16.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 17:
                        asosiykod.p2oldi17.sprite = asosiykod.deleteddona.sprite;
                        break;
                    case 18:
                        asosiykod.p2oldi18.sprite = asosiykod.deleteddona.sprite;
                        break;
                }
            }
            var tempColor2 = asosiykod.deleteddona.color;
            tempColor2.a = 0f;
            //yashil.enabled = false;
            asosiykod.deleteddona.color = tempColor2;
        }

            imageObject = GameObject.Find(yashil);

        var tempColor = imageObject.GetComponent<Image>().color;
        int mywidth = Mathf.FloorToInt(imageObject.GetComponent<Image>().rectTransform.rect.width);
        int myheight = Mathf.FloorToInt(imageObject.GetComponent<Image>().rectTransform.rect.height);
        int myleft = Mathf.FloorToInt(imageObject.transform.localPosition.x);
        int mytop = Mathf.FloorToInt(imageObject.transform.localPosition.y);

        if (tempColor.a == 1f)
        {
            asosiykod.selecteddona.transform.SetAsLastSibling();
            asosiykod.almashadi = satr.ToString();
            asosiykod.almashadiustun = ustun.ToString();

            asosiykod.yashilleft = myleft;
            asosiykod.yashiltop = mytop;
            asosiykod.yashilwidth = mywidth;
            asosiykod.yashilheight = myheight;

            asosiykod.timer1 = true;
            asosiykod.doska[satr, ustun] = asosiykod.doska[asosiykod.selectedsatr, asosiykod.selectedustun];


            asosiykod.doska[asosiykod.selectedsatr, asosiykod.selectedustun] = "empty";
            asosiykod.doskatozala();
            asosiykod.selectedsatr = 0;
            asosiykod.selectedustun = 0;
        }

       
    }

    void donaalmashtir()
    {
        Asosiy asosiykod = GameObject.Find("Canvas").GetComponent<Asosiy>();
        if (asosiykod.selectedplayer == "p1" && asosiykod.almashadi == "5")
        {
            switch (asosiykod.selecteddona.name)
            {
                case "p1r9":
                    asosiykod.selecteddona.sprite = asosiykod.p1n9.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n9";
                        }
                    }
                    break;
                case "p1r2":
                    asosiykod.selecteddona.sprite = asosiykod.p1n2.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n2";
                        }
                    }
                    break;
                case "p1r3":
                    asosiykod.selecteddona.sprite = asosiykod.p1n3.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n3";
                        }
                    }
                    break;
                case "p1r4":
                    asosiykod.selecteddona.sprite = asosiykod.p1n4.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n4";
                        }
                    }
                    break;
                case "p1r5":
                    asosiykod.selecteddona.sprite = asosiykod.p1n5.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n5";
                        }
                    }
                    break;
                case "p1r6":
                    asosiykod.selecteddona.sprite = asosiykod.p1n6.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n6";
                        }
                    }
                    break;
                case "p1r8":
                    asosiykod.selecteddona.sprite = asosiykod.p1n8.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (asosiykod.donaevent[k, 1] == asosiykod.selecteddona.name)
                        {
                            asosiykod.donaevent[k, 1] = "p1n8";
                        }
                    }
                    break;

            }

            /*Case "p1x1"
                Form3.ShowDialog()
                Select Case xtanlov
                    Case "p1fe"
                        selecteddona.Image = p1fe.Image
                    Case "p1n9"
                        selecteddona.Image = p1n9.Image
                    Case "p1n2"
                        selecteddona.Image = p1n2.Image
                    Case "p1n3"
                        selecteddona.Image = p1n3.Image
                    Case "p1n4"
                        selecteddona.Image = p1n4.Image
                    Case "p1n5"
                        selecteddona.Image = p1n5.Image
                    Case "p1n6"
                        selecteddona.Image = p1n6.Image
                    Case "p1n8"
                        selecteddona.Image = p1n8.Image
                End Select
                For i = 1 To 38
                    If donaevent(i, 1) = selecteddona.Name Then
                        donaevent(i, 2) = xtanlov
                    End If
                Next
            Case "p1x2"
                Form3.ShowDialog()
                Select Case xtanlov
                    Case "p1fe"
                        selecteddona.Image = p1fe.Image
                    Case "p1n9"
                        selecteddona.Image = p1n9.Image
                    Case "p1n2"
                        selecteddona.Image = p1n2.Image
                    Case "p1n3"
                        selecteddona.Image = p1n3.Image
                    Case "p1n4"
                        selecteddona.Image = p1n4.Image
                    Case "p1n5"
                        selecteddona.Image = p1n5.Image
                    Case "p1n6"
                        selecteddona.Image = p1n6.Image
                    Case "p1n8"
                        selecteddona.Image = p1n8.Image
                End Select
                For i = 1 To 38
                    If donaevent(i, 1) = selecteddona.Name Then
                        donaevent(i, 2) = xtanlov
                    End If
                Next
        End Select*/

        }
    }

}
