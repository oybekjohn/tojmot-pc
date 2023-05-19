using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Asosiy : MonoBehaviour
{
    public string[,] doska=new string[18,15];
    public string[,] donaevent = new string[40, 3];
    public int x, y;
    public int player1oldisoni, player2oldisoni;
    public string p1, p2;
    public string selectedplayer, xtanlov, selectedplayeralmashadi;
    public int selectedsatr, selectedustun, yashiltop, yashilleft, yashilwidth, yashilheight;
    public string almashadi, almashadiustun;
    public bool timer1, timer2;
    public Dictionary<string, Image> yashillar = new Dictionary<string, Image>();
    public Image selecteddona, deleteddona, almashtirdona;
    public Sprite qorash,qora1,qora2,qora3,qora4,qora5,qora6,qora8,qora9,qora2r, qora3r, qora4r, qora5r, qora6r, qora8r, qora9r,qorax1,qorax2;
    public Sprite oqsh, oq1, oq2, oq3, oq4, oq5, oq6, oq8, oq9, oq2r, oq3r, oq4r, oq5r, oq6r, oq8r, oq9r, oqx1, oqx2;
    public Sprite tqorash, tqora1, tqora2, tqora3, tqora4, tqora5, tqora6, tqora8, tqora9, tqora2r, tqora3r, tqora4r, tqora5r, tqora6r, tqora8r, tqora9r, tqorax1, tqorax2;
    public Sprite toqsh, toq1, toq2, toq3, toq4, toq5, toq6, toq8, toq9, toq2r, toq3r, toq4r, toq5r, toq6r, toq8r, toq9r, toqx1, toqx2;

    public Image p1sh,p1x1,p1x2,p1fe,p1n9,p1n2,p1n5,p1n8,p1n6,p1n4,p1n3,p1r9, p1r2, p1r5, p1r8, p1r6, p1r4, p1r3;
    public Image p2sh, p2x1, p2x2, p2fe, p2n9, p2n2, p2n5, p2n8, p2n6, p2n4, p2n3, p2r9, p2r2, p2r5, p2r8, p2r6, p2r4, p2r3;
    public Image g17,f16,h16,e15,g15,i15,b14,d14,f14,h14,j14,l14,n14,a13,c13,e13,g13,i13,k13,m13;
    public Image b12, d12, f12, h12, j12, l12, n12;
    public Image a11, c11, e11, g11, i11, k11, m11;
    public Image b10, d10, f10, h10, j10, l10, n10;
    public Image a9, c9, e9, g9, i9, k9, m9;
    public Image b8, d8, f8, h8, j8, l8, n8;
    public Image a7, c7, e7, g7, i7, k7, m7;
    public Image b6, d6, f6, h6, j6, l6, n6;
    public Image a5, c5, e5, g5, i5, k5, m5;
    public Image b4, d4, f4, h4, j4, l4, n4;
    public Image g1, f2, h2, e3, g3, i3;
    public int p1oldisoni, p2oldisoni;
    public Transform box, gameoverbox,winnerbox;
    public CanvasGroup background;
    public Button almashtir9, almashtir2, almashtir5, almashtir8, almashtir6, almashtir4, almashtir3, almashtirf;
    public string til;
    public TextMeshProUGUI uyinturititle, uyinturitext1, uyinturitext2, rangtanlash, donatanlash,gameovertext,winnertext;
    public AudioSource yurdi, urdi;
    public Sprite playeroq,playerqora,pcoq,pcqora;
    public Image p1image,p2image;
    public Image p1oldi1, p1oldi2, p1oldi3, p1oldi4, p1oldi5, p1oldi6, p1oldi7, p1oldi8, p1oldi9, p1oldi10, p1oldi11, p1oldi12, p1oldi13, p1oldi14, p1oldi15, p1oldi16, p1oldi17, p1oldi18;
    public Image p2oldi1, p2oldi2, p2oldi3, p2oldi4, p2oldi5, p2oldi6, p2oldi7, p2oldi8, p2oldi9, p2oldi10, p2oldi11, p2oldi12, p2oldi13, p2oldi14, p2oldi15, p2oldi16, p2oldi17, p2oldi18;
    public Sprite olditransparent;
    //private float movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        p1 = "oq";
        p2 = "pc";
        p1image.sprite = playeroq;
        p2image.sprite = pcqora;

        p1oldisoni = 0;
        p2oldisoni = 0;
        player1oldisoni = 0;
        player2oldisoni = 0;
        selectedplayer = "p1";
        timer1 = false;
        timer2 = false;
        //loaddonalar();
        //loadyashillar();
        //doskatozala();
        //loaddoska();
        
        if (PlayerPrefs.GetInt("til") ==1)
        {
            uyinturititle.text = "Kim bilan o`ynaysiz?";
            uyinturitext1.text = "Kompyuterga qarshi";
            uyinturitext2.text = "Insonga qarshi";

            rangtanlash.text = "Qaysi rangda o`ynaysiz?";
            donatanlash.text = "Qaysi donaga almashtirishni xoxlaysiz?";
            gameovertext.text = "Yutqazdingiz!";
            winnertext.text = "Siz yutdingiz!";
        }
        if (PlayerPrefs.GetInt("til") == 2)
        {
            uyinturititle.text = "С кем ты хочешь играть?";
            uyinturitext1.text = "Против компьютера";
            uyinturitext2.text = "Против человека";

            rangtanlash.text = "Каким цветом ты играешь?";
            donatanlash.text = "Какой из них вы хотите заменить?";
            gameovertext.text = "Вы проиграли!";
            winnertext.text = "Вы выиграли!";
        }
        if (PlayerPrefs.GetInt("til") == 3)
        {
            uyinturititle.text = "Who do you want to play with?";
            uyinturitext1.text = "Against the computer";
            uyinturitext2.text = "Against man";

            rangtanlash.text = "What color do you play?";
            donatanlash.text = "Which one do you want to replace?";
            gameovertext.text = "Game over!";
            winnertext.text = "You are winer!";
        }

    }
    private IEnumerator birozkutish(float waitTime)
    {
        //while (true)
        //{
            yield return new WaitForSeconds(waitTime);
            Donalar donalarkod = GameObject.Find("Canvas").GetComponent<Donalar>();
            donalarkod.checkshoh();
            donalarkod.avtopilot();
        //}
    }
    // Update is called once per frame
    void Update()
    {
        if (timer1 == true)
        {
            Donalar donalarkod = GameObject.Find("Canvas").GetComponent<Donalar>();
            selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(yashilleft, yashiltop);
            yurdi.Play();
            timer1 = false;
            
            donaalmashtir();
            if (selectedplayer == "p1")
            {
                selectedplayer = "p2";
                if (p2 == "pc")
                {
                    //Donalar donalarkod = GameObject.Find("Canvas").GetComponent<Donalar>();
                    StartCoroutine(birozkutish(1.0f));
                    //donalarkod.checkshoh();
                    //donalarkod.avtopilot();
                    
                }
                else
                {
                    //Donalar donalarkod = GameObject.Find("Canvas").GetComponent<Donalar>();
                    donalarkod.checkshoh();
                    
                }

            }
            else
            {
                selectedplayer = "p1";
                //Donalar donalarkod = GameObject.Find("Canvas").GetComponent<Donalar>();
                donalarkod.checkshoh();
            }



            if (donalarkod.p2tojbor==false || donalarkod.p1tojbor == false)
            { 
                for (int ii = 0; ii <= 17; ii++)
                {
                    for (int jj = 0; jj <= 14; jj++)
                    {
                        if (doska[ii, jj] == "soya")
                        {
                            doska[ii, jj] = "empty";
                        }

                    }
                }
                if (doska[17, 7] == "empty" || doska[17, 7] == "soya")
                {
                    doska[17, 7] = "bir";
                }
                if (doska[16, 6] == "empty" || doska[16, 6] == "soya")
                {
                    doska[16, 6] = "bir";
                }
                if (doska[16, 8] == "empty" || doska[16, 8] == "soya")
                {
                    doska[16, 8] = "bir";
                }
                if (doska[1, 7] == "empty" || doska[1, 7] == "soya")
                {
                    doska[1, 7] = "bir";
                }
                if (doska[2, 6] == "empty" || doska[2, 6] == "soya")
                {
                    doska[2, 6] = "bir";
                }
                if (doska[2, 8] == "empty" || doska[2, 8] == "soya")
                {
                    doska[2, 8] = "bir";
                }
            }





            /*
            int farq;
            farq = 0;
            if (Mathf.FloorToInt((yashilleft + yashilwidth / 2) - selecteddona.rectTransform.rect.width / 2) < selecteddona.rectTransform.rect.xMin)
            {
                float v = selecteddona.rectTransform.rect.xMin - ((int)(yashilleft + yashilwidth / 2) - (int)(selecteddona.rectTransform.rect.width / 2));
                farq = (int)v;
            }
            if (Mathf.FloorToInt((yashilleft +yashilwidth / 2) -selecteddona.rectTransform.rect.width / 2) > selecteddona.rectTransform.rect.xMin){
                float v = ((yashilleft + yashilwidth / 2) - selecteddona.rectTransform.rect.width / 2) - selecteddona.rectTransform.rect.xMin;
                farq = (int)v;
            }


        //leftni surish
            if (Mathf.FloorToInt((yashilleft +yashilwidth / 2) -selecteddona.rectTransform.rect.width / 2) < selecteddona.rectTransform.rect.xMin)
            {
                //selecteddona.rectTransform.rect.xMin = selecteddona.rectTransform.rect.xMin - 1;
                float v = selecteddona.rectTransform.rect.xMin - 1;
                selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(v, selecteddona.rectTransform.rect.yMin);

            }
            if (Mathf.FloorToInt((yashilleft + yashilwidth / 2) - selecteddona.rectTransform.rect.width / 2) > selecteddona.rectTransform.rect.xMin) {
                float v = selecteddona.rectTransform.rect.xMin + 1;
                selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(v, selecteddona.rectTransform.rect.yMin);
                //selecteddona.rectTransform.rect.xMin = v;
            }
            Debug.Log(yashiltop);
            Debug.Log(yashilleft);
            //topni surish
            if (farq > 0)
            {


                if (Mathf.FloorToInt((yashiltop + yashilheight / 2) - selecteddona.rectTransform.rect.height / 2) < selecteddona.rectTransform.rect.yMin) {
                    float v = selecteddona.rectTransform.rect.yMin - (selecteddona.rectTransform.rect.yMin - Mathf.FloorToInt((yashiltop + yashilheight / 2) - selecteddona.rectTransform.rect.height / 2)) / farq;
                    selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(selecteddona.rectTransform.rect.xMin, v);

                    //selecteddona.rectTransform.rect.yMin 
                }
                if (Mathf.FloorToInt((yashiltop + yashilheight / 2) - selecteddona.rectTransform.rect.height / 2) > selecteddona.rectTransform.rect.yMin)
                {
                    float v = selecteddona.rectTransform.rect.yMin + (Mathf.FloorToInt((yashiltop + yashilheight / 2) - selecteddona.rectTransform.rect.height / 2) - selecteddona.rectTransform.rect.yMin) / farq;
                    selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(selecteddona.rectTransform.rect.xMin,v);

                }

                if (Mathf.FloorToInt((yashilleft +yashilwidth / 2)-selecteddona.rectTransform.rect.width / 2) == selecteddona.rectTransform.rect.xMin) {
                    timer1 = false;
                    //donaalmashtir();
                    selecteddona = null;

                }
            }
            else
            {
            
                if (Mathf.FloorToInt((yashiltop + yashilheight / 2) - selecteddona.rectTransform.rect.height / 2) < selecteddona.rectTransform.rect.yMin)
                {
                    float v = selecteddona.rectTransform.rect.yMin - 1;
                    selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(selecteddona.rectTransform.rect.xMin, v);

                }

                if (Mathf.FloorToInt((yashiltop +yashilheight / 2) -selecteddona.rectTransform.rect.height / 2) > selecteddona.rectTransform.rect.yMin)
                {
                    float v = selecteddona.rectTransform.rect.yMin + 1;
                    selecteddona.GetComponent<RectTransform>().anchoredPosition = new Vector2(selecteddona.rectTransform.rect.xMin, v);

                }


                if (Mathf.FloorToInt((yashiltop +yashilheight / 2) -selecteddona.rectTransform.rect.height / 2) == selecteddona.rectTransform.rect.yMin)
                {
                    timer1 = false;
                    //donaalmashtir()
                    selecteddona = null;
                }

            }*/
        }

    }

    void donaalmashtir()
    {
        
        if (selectedplayer == "p1" && almashadi == "5")
        {
            switch (selecteddona.name)
            {
                case "p1r9":
                    selecteddona.sprite = p1n9.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n9";
                        }
                    }
                    break;
                case "p1r2":
                    selecteddona.sprite = p1n2.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n2";
                        }
                    }
                    break;
                case "p1r3":
                    selecteddona.sprite = p1n3.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n3";
                        }
                    }
                    break;
                case "p1r4":
                    selecteddona.sprite = p1n4.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n4";
                        }
                    }
                    break;
                case "p1r5":
                    selecteddona.sprite = p1n5.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n5";
                        }
                    }
                    break;
                case "p1r6":
                    selecteddona.sprite = p1n6.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n6";
                        }
                    }
                    break;
                case "p1r8":
                    selecteddona.sprite = p1n8.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p1n8";
                        }
                    }
                    break;
                case "p1x1":
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            if (donaevent[k, 1] == donaevent[k, 2])
                            {
                                almashtir2.image.sprite = p1n2.sprite;
                                almashtir3.image.sprite = p1n3.sprite;
                                almashtir4.image.sprite = p1n4.sprite;
                                almashtir5.image.sprite = p1n5.sprite;
                                almashtir6.image.sprite = p1n6.sprite;
                                almashtir8.image.sprite = p1n8.sprite;
                                almashtir9.image.sprite = p1n9.sprite;
                                almashtirf.image.sprite = p1fe.sprite;
                                almashtirdona = selecteddona;
                                selectedplayeralmashadi = selectedplayer;
                                box.gameObject.SetActive(true);
                            }
                        }
                    }
                    
                    break;
                case "p1x2":
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            if (donaevent[k, 1] == donaevent[k, 2])
                            {
                                almashtir2.image.sprite = p1n2.sprite;
                                almashtir3.image.sprite = p1n3.sprite;
                                almashtir4.image.sprite = p1n4.sprite;
                                almashtir5.image.sprite = p1n5.sprite;
                                almashtir6.image.sprite = p1n6.sprite;
                                almashtir8.image.sprite = p1n8.sprite;
                                almashtir9.image.sprite = p1n9.sprite;
                                almashtirf.image.sprite = p1fe.sprite;
                                almashtirdona = selecteddona;
                                selectedplayeralmashadi = selectedplayer;
                                box.gameObject.SetActive(true);
                            }
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
        if (selectedplayer == "p2" && almashadi == "13")
        {
            switch (selecteddona.name)
            {
                case "p2r9":
                    selecteddona.sprite = p2n9.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n9";
                        }
                    }
                    break;
                case "p2r2":
                    selecteddona.sprite = p2n2.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n2";
                        }
                    }
                    break;
                case "p2r3":
                    selecteddona.sprite = p2n3.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n3";
                        }
                    }
                    break;
                case "p2r4":
                    selecteddona.sprite = p2n4.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n4";
                        }
                    }
                    break;
                case "p2r5":
                    selecteddona.sprite = p2n5.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n5";
                        }
                    }
                    break;
                case "p2r6":
                    selecteddona.sprite = p2n6.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n6";
                        }
                    }
                    break;
                case "p2r8":
                    selecteddona.sprite = p2n8.sprite;
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            donaevent[k, 2] = "p2n8";
                        }
                    }
                    break;
                case "p2x1":
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            if (donaevent[k, 1] == donaevent[k, 2])
                            {
                                almashtir2.image.sprite = p1n2.sprite;
                                almashtir3.image.sprite = p1n3.sprite;
                                almashtir4.image.sprite = p1n4.sprite;
                                almashtir5.image.sprite = p1n5.sprite;
                                almashtir6.image.sprite = p1n6.sprite;
                                almashtir8.image.sprite = p1n8.sprite;
                                almashtir9.image.sprite = p1n9.sprite;
                                almashtirf.image.sprite = p1fe.sprite;
                                almashtirdona = selecteddona;
                                selectedplayeralmashadi = selectedplayer;
                                box.gameObject.SetActive(true);
                            }
                        }
                    }

                    break;
                case "p2x2":
                    for (int k = 1; k <= 38; k++)
                    {
                        if (donaevent[k, 1] == selecteddona.name)
                        {
                            if (donaevent[k, 1] == donaevent[k, 2])
                            {
                                almashtir2.image.sprite = p1n2.sprite;
                                almashtir3.image.sprite = p1n3.sprite;
                                almashtir4.image.sprite = p1n4.sprite;
                                almashtir5.image.sprite = p1n5.sprite;
                                almashtir6.image.sprite = p1n6.sprite;
                                almashtir8.image.sprite = p1n8.sprite;
                                almashtir9.image.sprite = p1n9.sprite;
                                almashtirf.image.sprite = p1fe.sprite;
                                almashtirdona = selecteddona;
                                selectedplayeralmashadi = selectedplayer;
                                box.gameObject.SetActive(true);
                            }
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
    public void loaddonalar()
    {
        if (p1=="oq")
        {
            p1sh.sprite = oqsh;
            p1x1.sprite = oqx1;
            p1x2.sprite = oqx2;
            p1fe.sprite = oq1;
            p1n2.sprite = oq2;
            p1n3.sprite = oq3;
            p1n4.sprite = oq4;
            p1n5.sprite = oq5;
            p1n6.sprite = oq6;
            p1n8.sprite = oq8;
            p1n9.sprite = oq9;
            p1r2.sprite = oq2r;
            p1r3.sprite = oq3r;
            p1r4.sprite = oq4r;
            p1r5.sprite = oq5r;
            p1r6.sprite = oq6r;
            p1r8.sprite = oq8r;
            p1r9.sprite = oq9r;

            p2sh.sprite = tqorash;
            p2x1.sprite = tqorax1;
            p2x2.sprite = tqorax2;
            p2fe.sprite = tqora1;
            p2n2.sprite = tqora2;
            p2n3.sprite = tqora3;
            p2n4.sprite = tqora4;
            p2n5.sprite = tqora5;
            p2n6.sprite = tqora6;
            p2n8.sprite = tqora8;
            p2n9.sprite = tqora9;
            p2r2.sprite = tqora2r;
            p2r3.sprite = tqora3r;
            p2r4.sprite = tqora4r;
            p2r5.sprite = tqora5r;
            p2r6.sprite = tqora6r;
            p2r8.sprite = tqora8r;
            p2r9.sprite = tqora9r;
        }
        else
        {
            p1sh.sprite = qorash;
            p1x1.sprite = qorax1;
            p1x2.sprite = qorax2;
            p1fe.sprite = qora1;
            p1n2.sprite = qora2;
            p1n3.sprite = qora3;
            p1n4.sprite = qora4;
            p1n5.sprite = qora5;
            p1n6.sprite = qora6;
            p1n8.sprite = qora8;
            p1n9.sprite = qora9;
            p1r2.sprite = qora2r;
            p1r3.sprite = qora3r;
            p1r4.sprite = qora4r;
            p1r5.sprite = qora5r;
            p1r6.sprite = qora6r;
            p1r8.sprite = qora8r;
            p1r9.sprite = qora9r;

            p2sh.sprite = toqsh;
            p2x1.sprite = toqx1;
            p2x2.sprite = toqx2;
            p2fe.sprite = toq1;
            p2n2.sprite = toq2;
            p2n3.sprite = toq3;
            p2n4.sprite = toq4;
            p2n5.sprite = toq5;
            p2n6.sprite = toq6;
            p2n8.sprite = toq8;
            p2n9.sprite = toq9;
            p2r2.sprite = toq2r;
            p2r3.sprite = toq3r;
            p2r4.sprite = toq4r;
            p2r5.sprite = toq5r;
            p2r6.sprite = toq6r;
            p2r8.sprite = toq8r;
            p2r9.sprite = toq9r;
        }

        p1oldi1.sprite = olditransparent;
        p1oldi2.sprite = olditransparent;
        p1oldi3.sprite = olditransparent;
        p1oldi4.sprite = olditransparent;
        p1oldi5.sprite = olditransparent;
        p1oldi6.sprite = olditransparent;
        p1oldi7.sprite = olditransparent;
        p1oldi8.sprite = olditransparent;
        p1oldi9.sprite = olditransparent;
        p1oldi10.sprite = olditransparent;
        p1oldi11.sprite = olditransparent;
        p1oldi12.sprite = olditransparent;
        p1oldi13.sprite = olditransparent;
        p1oldi14.sprite = olditransparent;
        p1oldi15.sprite = olditransparent;
        p1oldi16.sprite = olditransparent;
        p1oldi17.sprite = olditransparent;
        p1oldi18.sprite = olditransparent;

        p2oldi1.sprite = olditransparent;
        p2oldi2.sprite = olditransparent;
        p2oldi3.sprite = olditransparent;
        p2oldi4.sprite = olditransparent;
        p2oldi5.sprite = olditransparent;
        p2oldi6.sprite = olditransparent;
        p2oldi7.sprite = olditransparent;
        p2oldi8.sprite = olditransparent;
        p2oldi9.sprite = olditransparent;
        p2oldi10.sprite = olditransparent;
        p2oldi11.sprite = olditransparent;
        p2oldi12.sprite = olditransparent;
        p2oldi13.sprite = olditransparent;
        p2oldi14.sprite = olditransparent;
        p2oldi15.sprite = olditransparent;
        p2oldi16.sprite = olditransparent;
        p2oldi17.sprite = olditransparent;
        p2oldi18.sprite = olditransparent;

    }

    public void loadyashillar()
    {
        yashillar.Add("g17", g17);
        yashillar.Add("f16", f16);
        yashillar.Add("h16", h16);
        yashillar.Add("e15", e15);
        yashillar.Add("g15", g15);
        yashillar.Add("i15", i15);
        yashillar.Add("b14", b14);
        yashillar.Add("d14", d14);
        yashillar.Add("f14", f14);
        yashillar.Add("h14", h14);
        yashillar.Add("j14", j14);
        yashillar.Add("l14", l14);
        yashillar.Add("n14", n14);
        yashillar.Add("a13", a13);
        yashillar.Add("c13", c13);
        yashillar.Add("e13", e13);
        yashillar.Add("g13", g13);
        yashillar.Add("i13", i13);
        yashillar.Add("k13", k13);
        yashillar.Add("m13", m13);
        yashillar.Add("b12", b12);
        yashillar.Add("d12", d12);
        yashillar.Add("f12", f12);
        yashillar.Add("h12", h12);
        yashillar.Add("j12", j12);
        yashillar.Add("l12", l12);
        yashillar.Add("n12", n12);
        yashillar.Add("a11", a11);
        yashillar.Add("c11", c11);
        yashillar.Add("e11", e11);
        yashillar.Add("g11", g11);
        yashillar.Add("i11", i11);
        yashillar.Add("k11", k11);
        yashillar.Add("m11", m11);
        yashillar.Add("b10", b10);
        yashillar.Add("d10", d10);
        yashillar.Add("f10", f10);
        yashillar.Add("h10", h10);
        yashillar.Add("j10", j10);
        yashillar.Add("l10", l10);
        yashillar.Add("n10", n10);
        yashillar.Add("a9", a9);
        yashillar.Add("c9", c9);
        yashillar.Add("e9", e9);
        yashillar.Add("g9", g9);
        yashillar.Add("i9", i9);
        yashillar.Add("k9", k9);
        yashillar.Add("m9", m9);
        yashillar.Add("b8", b8);
        yashillar.Add("d8", d8);
        yashillar.Add("f8", f8);
        yashillar.Add("h8", h8);
        yashillar.Add("j8", j8);
        yashillar.Add("l8", l8);
        yashillar.Add("n8", n8);
        yashillar.Add("a7", a7);
        yashillar.Add("c7", c7);
        yashillar.Add("e7", e7);
        yashillar.Add("g7", g7);
        yashillar.Add("i7", i7);
        yashillar.Add("k7", k7);
        yashillar.Add("m7", m7);
        yashillar.Add("b6", b6);
        yashillar.Add("d6", d6);
        yashillar.Add("f6", f6);
        yashillar.Add("h6", h6);
        yashillar.Add("j6", j6);
        yashillar.Add("l6", l6);
        yashillar.Add("n6", n6);
        yashillar.Add("a5", a5);
        yashillar.Add("c5", c5);
        yashillar.Add("e5", e5);
        yashillar.Add("g5", g5);
        yashillar.Add("i5", i5);
        yashillar.Add("k5", k5);
        yashillar.Add("m5", m5);
        yashillar.Add("b4", b4);
        yashillar.Add("d4", d4);
        yashillar.Add("f4", f4);
        yashillar.Add("h4", h4);
        yashillar.Add("j4", j4);
        yashillar.Add("l4", l4);
        yashillar.Add("n4", n4);
        yashillar.Add("e3", e3);
        yashillar.Add("g3", g3);
        yashillar.Add("i3", i3);
        yashillar.Add("f2", f2);
        yashillar.Add("h2", h2);
        yashillar.Add("g1", g1);
    }

    public void doskatozala()
    {
        foreach (var yashil in yashillar.Values)
        {
            var tempColor = yashil.color;
            tempColor.a = 0f;
            //yashil.enabled = false;
            yashil.color = tempColor;
            yashil.transform.SetAsFirstSibling();
        }
    }

    public void loaddoska()
    {
        for (int i = 0; i <= 17; i++)
        {
            for (int j = 0; j <= 14; j++)
            {
                doska[i, j] = "no";
            }
        }
        /*for (int i = 0; i <= 17; i++)
        {
            for (int j = 0; j <= 14; j++)
            {
                doska[i, j] = "empty";
            }
        }*/
        doska[1, 7] = "empty";
        doska[2, 6] = "empty";
        doska[2, 8] = "empty";
        doska[3, 5] = "empty";
        doska[3, 7] = "empty";
        doska[3, 9] = "empty";
        doska[4, 2] = "empty";
        doska[4, 4] = "empty";
        doska[4, 6] = "empty";
        doska[4, 8] = "empty";
        doska[4, 10] = "empty";
        doska[4, 12] = "empty";
        doska[4, 14] = "empty";
        doska[5, 1] = "empty";
        doska[5, 3] = "empty";
        doska[5, 5] = "empty";
        doska[5, 7] = "empty";
        doska[5, 9] = "empty";
        doska[5, 11] = "empty";
        doska[5, 13] = "empty";
        doska[6, 2] = "empty";
        doska[6, 4] = "empty";
        doska[6, 6] = "empty";
        doska[6, 8] = "empty";
        doska[6, 10] = "empty";
        doska[6, 12] = "empty";
        doska[6, 14] = "empty";
        doska[7, 1] = "empty";
        doska[7, 3] = "empty";
        doska[7, 5] = "empty";
        doska[7, 7] = "empty";
        doska[7, 9] = "empty";
        doska[7, 11] = "empty";
        doska[7, 13] = "empty";
        doska[8, 2] = "empty";
        doska[8, 4] = "empty";
        doska[8, 6] = "empty";
        doska[8, 8] = "empty";
        doska[8, 10] = "empty";
        doska[8, 12] = "empty";
        doska[8, 14] = "empty";
        doska[9, 1] = "empty";
        doska[9, 3] = "empty";
        doska[9, 5] = "empty";
        doska[9, 7] = "empty";
        doska[9, 9] = "empty";
        doska[9, 11] = "empty";
        doska[9, 13] = "empty";
        doska[10, 2] = "empty";
        doska[10, 4] = "empty";
        doska[10, 6] = "empty";
        doska[10, 8] = "empty";
        doska[10, 10] = "empty";
        doska[10, 12] = "empty";
        doska[10, 14] = "empty";
        doska[11, 1] = "empty";
        doska[11, 3] = "empty";
        doska[11, 5] = "empty";
        doska[11, 7] = "empty";
        doska[11, 9] = "empty";
        doska[11, 11] = "empty";
        doska[11, 13] = "empty";
        doska[12, 2] = "empty";
        doska[12, 4] = "empty";
        doska[12, 6] = "empty";
        doska[12, 8] = "empty";
        doska[12, 10] = "empty";
        doska[12, 12] = "empty";
        doska[12, 14] = "empty";
        doska[13, 1] = "empty";
        doska[13, 3] = "empty";
        doska[13, 5] = "empty";
        doska[13, 7] = "empty";
        doska[13, 9] = "empty";
        doska[13, 11] = "empty";
        doska[13, 13] = "empty";
        doska[14, 2] = "empty";
        doska[14, 4] = "empty";
        doska[14, 6] = "empty";
        doska[14, 8] = "empty";
        doska[14, 10] = "empty";
        doska[14, 12] = "empty";
        doska[14, 14] = "empty";
        doska[17, 7] = "empty";
        doska[16, 6] = "empty";
        doska[16, 8] = "empty";
        doska[15, 5] = "empty";
        doska[15, 7] = "empty";
        doska[15, 9] = "empty";
        /*doska[15, 1] = "no";
        doska[15, 3] = "no";
        doska[15, 11] = "no";
        doska[15, 13] = "no";
        doska[16, 2] = "no";
        doska[16, 4] = "no";
        doska[16, 10] = "no";
        doska[16, 12] = "no";
        doska[16, 14] = "no";
        doska[17, 1] = "no";
        doska[17, 3] = "no";
        doska[17, 5] = "no";
        doska[17, 9] = "no";
        doska[17, 11] = "no";
        doska[17, 13] = "no";

        doska[3, 1] = "no";
        doska[3, 3] = "no";
        doska[3, 11] = "no";
        doska[3, 13] = "no";
        doska[2, 2] = "no";
        doska[2, 4] = "no";
        doska[2, 10] = "no";
        doska[2, 12] = "no";
        doska[2, 14] = "no";
        doska[1, 1] = "no";
        doska[1, 3] = "no";
        doska[1, 5] = "no";
        doska[1, 9] = "no";
        doska[1, 11] = "no";
        doska[1, 13] = "no";*/

        doska[17, 7] = "bir";
        doska[16, 6] = "bir";
        doska[16, 8] = "bir";
        doska[1, 7] = "bir";
        doska[2, 6] = "bir";
        doska[2, 8] = "bir";






        doska[13, 1] = "p1r9";
        doska[13, 3] = "p1r2";
        doska[13, 5] = "p1r5";
        doska[13, 7] = "p1r8";
        doska[13, 9] = "p1r6";
        doska[13, 11] = "p1r4";
        doska[13, 13] = "p1r3";
        doska[14, 2] = "p1n9";
        doska[14, 4] = "p1n2";
        doska[14, 6] = "p1n5";
        doska[14, 8] = "p1n8";
        doska[14, 10] = "p1n6";
        doska[14, 12] = "p1n4";
        doska[14, 14] = "p1n3";
        doska[15, 5] = "p1x1";
        doska[15, 9] = "p1x2";
        doska[15, 7] = "p1fe";
        doska[17, 7] = "p1sh";

        doska[5, 13] = "p2r9";
        doska[5, 11] = "p2r2";
        doska[5, 9] = "p2r5";
        doska[5, 7] = "p2r8";
        doska[5, 5] = "p2r6";
        doska[5, 3] = "p2r4";
        doska[5, 1] = "p2r3";
        doska[4, 14] = "p2n9";
        doska[4, 12] = "p2n2";
        doska[4, 10] = "p2n5";
        doska[4, 8] = "p2n8";
        doska[4, 6] = "p2n6";
        doska[4, 4] = "p2n4";
        doska[4, 2] = "p2n3";
        doska[3, 9] = "p2x1";
        doska[3, 5] = "p2x2";
        doska[3, 7] = "p2fe";
        doska[1, 7] = "p2sh";

        donaevent[1, 1] = "p1r9";
        donaevent[2, 1] = "p1r2";
        donaevent[3, 1] = "p1r5";
        donaevent[4, 1] = "p1r8";
        donaevent[5, 1] = "p1r6";
        donaevent[6, 1] = "p1r4";
        donaevent[7, 1] = "p1r3";
        donaevent[8, 1] = "p1n9";
        donaevent[9, 1] = "p1n2";
        donaevent[10, 1] = "p1n5";
        donaevent[11, 1] = "p1n8";
        donaevent[12, 1] = "p1n6";
        donaevent[13, 1] = "p1n4";
        donaevent[14, 1] = "p1n3";
        donaevent[15, 1] = "p1x1";
        donaevent[16, 1] = "p1x2";
        donaevent[17, 1] = "p1fe";
        donaevent[18, 1] = "p1sh";

        donaevent[19, 1] = "p2r9";
        donaevent[20, 1] = "p2r2";
        donaevent[21, 1] = "p2r5";
        donaevent[22, 1] = "p2r8";
        donaevent[23, 1] = "p2r6";
        donaevent[24, 1] = "p2r4";
        donaevent[25, 1] = "p2r3";
        donaevent[26, 1] = "p2n9";
        donaevent[27, 1] = "p2n2";
        donaevent[28, 1] = "p2n5";
        donaevent[29, 1] = "p2n8";
        donaevent[30, 1] = "p2n6";
        donaevent[31, 1] = "p2n4";
        donaevent[32, 1] = "p2n3";
        donaevent[33, 1] = "p2x1";
        donaevent[34, 1] = "p2x2";
        donaevent[35, 1] = "p2fe";
        donaevent[36, 1] = "p2sh";

        donaevent[1, 2] = "p1r9";
        donaevent[2, 2] = "p1r2";
        donaevent[3, 2] = "p1r5";
        donaevent[4, 2] = "p1r8";
        donaevent[5, 2] = "p1r6";
        donaevent[6, 2] = "p1r4";
        donaevent[7, 2] = "p1r3";
        donaevent[8, 2] = "p1n9";
        donaevent[9, 2] = "p1n2";
        donaevent[10, 2] = "p1n5";
        donaevent[11, 2] = "p1n8";
        donaevent[12, 2] = "p1n6";
        donaevent[13, 2] = "p1n4";
        donaevent[14, 2] = "p1n3";
        donaevent[15, 2] = "p1x1";
        donaevent[16, 2] = "p1x2";
        donaevent[17, 2] = "p1fe";
        donaevent[18, 2] = "p1sh";

        donaevent[19, 2] = "p2r9";
        donaevent[20, 2] = "p2r2";
        donaevent[21, 2] = "p2r5";
        donaevent[22, 2] = "p2r8";
        donaevent[23, 2] = "p2r6";
        donaevent[24, 2] = "p2r4";
        donaevent[25, 2] = "p2r3";
        donaevent[26, 2] = "p2n9";
        donaevent[27, 2] = "p2n2";
        donaevent[28, 2] = "p2n5";
        donaevent[29, 2] = "p2n8";
        donaevent[30, 2] = "p2n6";
        donaevent[31, 2] = "p2n4";
        donaevent[32, 2] = "p2n3";
        donaevent[33, 2] = "p2x1";
        donaevent[34, 2] = "p2x2";
        donaevent[35, 2] = "p2fe";
        donaevent[36, 2] = "p2sh";


    }

    

}
