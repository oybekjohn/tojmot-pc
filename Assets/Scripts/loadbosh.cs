using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class loadbosh : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI buttonyopish, settingtitle, tiltanlash;
    public TextMeshProUGUI buttonplay, buttonsettings, buttoninfo, buttonquit, buttonqoidalar;
    public TextMeshProUGUI infotext, infotitle, infoclose;
    public Text versiya, federatsiya;
    public TextMeshProUGUI qoidatitle, qoidaclose;
    public Sprite engqoida, uzqoida, ruqoida;
    public Image qoidalar;
    void Start()
    {
        
        if (PlayerPrefs.HasKey("til")==true)
        {
            if (PlayerPrefs.GetInt("til")==3)
            {
                buttonyopish.text = "Close";
                settingtitle.text = "Settings";
                tiltanlash.text = "Choose language";

                buttonplay.text = "Play";
                buttonqoidalar.text = "Instructions";
                buttonsettings.text = "Settings";

                buttoninfo.text = "Info";
                buttonquit.text = "Quit";

                versiya.text = "Version 1.0.0";
                federatsiya.text = "NATIONAL УTOJMOTФ FEDERATION OF FERGANA REGION OF THE REPUBLIC OF UZBEKISTAN";
                infotext.text = "    Tojmot was developed as part of a software development project developed by the Ministry of Innovative Development of the Republic of Uzbekistan to create a mathematical model of the game УTojmot - mental gymnasticsФ. ";
                infotitle.text = "About";
                infoclose.text = "Close";
                qoidatitle.text = "Instructions for the game TAJMAT";
                qoidaclose.text = "Close";
                qoidalar.sprite = engqoida;
            }
            else
            {
                if (PlayerPrefs.GetInt("til") == 2)
                {
                    buttonyopish.text = "«акрыть";
                    settingtitle.text = "Ќастройки";
                    tiltanlash.text = "¬ыберите €зык";

                    buttonplay.text = "»грать";
                    buttonqoidalar.text = "»нструкци€";
                    buttonsettings.text = "Ќастройки";
                    buttoninfo.text = "»нфо";
                    buttonquit.text = "¬ыход";

                    versiya.text = "¬ерси€ 1.0.0";
                    federatsiya.text = "Ќј÷»ќЌјЋ№Ќјя ‘≈ƒ≈–ј÷»я Ђ“ќ∆ћќ“ї ‘≈–√јЌ— ќ… ќЅЋј—“» –≈—ѕ”ЅЋ» » ”«Ѕ≈ »—“јЌ";
                    infotext.text = "    “ожмот разработан в рамках проекта по разработке программного обеспечени€, разработанного ћинистерством инновационного развити€ –еспублики ”збекистан, дл€ создани€ математической модели игры Ђ“ожмот Ц умственна€ гимнастикаї. ";
                    infotitle.text = "ќ игре";
                    infoclose.text = "«акрыть";
                    qoidatitle.text = "»нструкци€ по игре “ј∆ћј“";
                    qoidaclose.text = "«акрыть";
                    qoidalar.sprite = ruqoida;
                }
                else
                {
                    buttonyopish.text = "Yopish";
                    settingtitle.text = "Sozlash";
                    tiltanlash.text = "Tilni tanlang";

                    buttonplay.text = "Boshlash";
                    buttonsettings.text = "Sozlash";
                    buttoninfo.text = "O`yin haqida";
                    buttonquit.text = "Chiqish";

                    versiya.text = "Versiya 1.0.0";
                    federatsiya.text = "O`ZBEKISTON RESPUBLIKASI FARG`ONA VILOYATI               MILLIY УTOJMOTФ FEDERATSIYASI";
                    infotext.text = "    Tojmot o`yini O`zbekiston Respublikasi Innovatsion rivojlanish vazirligi tomonidan taqdim etilgan УTojmot Ц aql gimnastikasiФ oСyinining matematik modelini yaratish orqali uning dasturiy taТminotini ishlab chiqish loyihasi doirasida tayyorlangan.";
                    infotitle.text = "Dastur haqida";
                    infoclose.text = "Yopish";
                    buttonqoidalar.text = "O`yin qoidasi";
                    qoidatitle.text = "O`yin qoidalari";
                    qoidaclose.text = "Yopish";
                    qoidalar.sprite = uzqoida;
                }
            }
        }
        else
        {
            buttonyopish.text = "Yopish";
            settingtitle.text = "Sozlash";
            tiltanlash.text = "Tilni tanlang";

            buttonplay.text = "Boshlash";
            buttonsettings.text = "Sozlash";
            buttoninfo.text = "O`yin haqida";
            buttonquit.text = "Chiqish";

            versiya.text = "Versiya 1.0.0";
            federatsiya.text = "O`ZBEKISTON RESPUBLIKASI FARG`ONA VILOYATI               MILLIY УTOJMOTФ FEDERATSIYASI";
            infotext.text = "    Tojmot o`yini O`zbekiston Respublikasi Innovatsion rivojlanish vazirligi tomonidan taqdim etilgan УTojmot Ц aql gimnastikasiФ oСyinining matematik modelini yaratish orqali uning dasturiy taТminotini ishlab chiqish loyihasi doirasida tayyorlangan.";
            infotitle.text = "Dastur haqida";
            infoclose.text = "Yopish";
            buttonqoidalar.text = "O`yin qoidasi";
            qoidatitle.text = "O`yin qoidalari";
            qoidaclose.text = "Yopish";
            qoidalar.sprite = uzqoida;
        }


    }


}
