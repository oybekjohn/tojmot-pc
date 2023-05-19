using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class chooselanguage : MonoBehaviour
{
    public TextMeshProUGUI buttonyopish, settingtitle, tiltanlash;
    public TextMeshProUGUI buttonplay, buttonsettings, buttoninfo, buttonquit, buttonqoidalar;
    public TextMeshProUGUI infotext, infotitle, infoclose;
    public TextMeshProUGUI qoidatitle, qoidaclose;
    public Text versiya, federatsiya;
    public Sprite engqoida, uzqoida, ruqoida;
    public Image qoidalar;
    public void uzbeklang()
    {
        buttonyopish.text = "Yopish";
        settingtitle.text = "Sozlash";
        tiltanlash.text = "Tilni tanlang";

        buttonplay.text = "Boshlash";
        buttonqoidalar.text = "O`yin qoidasi";
        buttonsettings.text = "Sozlash";
        buttoninfo.text = "O`yin haqida";
        buttonquit.text = "Chiqish";

        versiya.text = "Versiya 1.0.0";
        federatsiya.text = "O`ZBEKISTON RESPUBLIKASI FARG`ONA VILOYATI               MILLIY “TOJMOT” FEDERATSIYASI";
        infotext.text = "    Tojmot o`yini O`zbekiston Respublikasi Innovatsion rivojlanish vazirligi tomonidan taqdim etilgan “Tojmot – aql gimnastikasi” o‘yinining matematik modelini yaratish orqali uning dasturiy ta’minotini ishlab chiqish loyihasi doirasida tayyorlangan.";
        infotitle.text = "Dastur haqida";
        infoclose.text = "Yopish";

        qoidatitle.text = "O`yin qoidalari";
        qoidaclose.text = "Yopish";
        qoidalar.sprite = uzqoida;
        PlayerPrefs.SetInt("til", 1);
        PlayerPrefs.Save();
    }
    public void ruslang()
    {
        buttonyopish.text = "Закрыть";

        settingtitle.text = "Настройки";
        tiltanlash.text = "Выберите язык";

        buttonplay.text = "Играть";
        buttonqoidalar.text = "Инструкция";
        buttonsettings.text = "Настройки";
        buttoninfo.text = "Инфо";
        buttonquit.text = "Выход";

        versiya.text = "Версия 1.0.0";
        federatsiya.text = "НАЦИОНАЛЬНАЯ ФЕДЕРАЦИЯ «ТОЖМОТ» ФЕРГАНСКОЙ ОБЛАСТИ РЕСПУБЛИКИ УЗБЕКИСТАН";
        infotext.text = "    Тожмот разработан в рамках проекта по разработке программного обеспечения, разработанного Министерством инновационного развития Республики Узбекистан, для создания математической модели игры «Тожмот – умственная гимнастика». ";
        infotitle.text = "О игре";
        infoclose.text = "Закрыть";

        qoidatitle.text = "Инструкция по игре ТАЖМАТ";
        qoidaclose.text = "Закрыть";
        qoidalar.sprite = ruqoida;
        PlayerPrefs.SetInt("til", 2);
        PlayerPrefs.Save();
    }
    public void englang()
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
        federatsiya.text = "NATIONAL “TOJMOT” FEDERATION OF FERGANA REGION OF THE REPUBLIC OF UZBEKISTAN";
        infotext.text = "    Tojmot was developed as part of a software development project developed by the Ministry of Innovative Development of the Republic of Uzbekistan to create a mathematical model of the game “Tojmot - mental gymnastics”. ";
        infotitle.text = "About";
        infoclose.text = "Close";
        qoidatitle.text = "Instructions for the game TAJMAT";
        qoidaclose.text = "Close";
        qoidalar.sprite = engqoida;
        PlayerPrefs.SetInt("til", 3);
        PlayerPrefs.Save();
    }
}
