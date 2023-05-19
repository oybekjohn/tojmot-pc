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
                federatsiya.text = "NATIONAL �TOJMOT� FEDERATION OF FERGANA REGION OF THE REPUBLIC OF UZBEKISTAN";
                infotext.text = "    Tojmot was developed as part of a software development project developed by the Ministry of Innovative Development of the Republic of Uzbekistan to create a mathematical model of the game �Tojmot - mental gymnastics�. ";
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
                    buttonyopish.text = "�������";
                    settingtitle.text = "���������";
                    tiltanlash.text = "�������� ����";

                    buttonplay.text = "������";
                    buttonqoidalar.text = "����������";
                    buttonsettings.text = "���������";
                    buttoninfo.text = "����";
                    buttonquit.text = "�����";

                    versiya.text = "������ 1.0.0";
                    federatsiya.text = "������������ ��������� ������һ ���������� ������� ���������� ����������";
                    infotext.text = "    ������ ���������� � ������ ������� �� ���������� ������������ �����������, �������������� ������������� �������������� �������� ���������� ����������, ��� �������� �������������� ������ ���� ������� � ���������� ����������. ";
                    infotitle.text = "� ����";
                    infoclose.text = "�������";
                    qoidatitle.text = "���������� �� ���� ������";
                    qoidaclose.text = "�������";
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
                    federatsiya.text = "O`ZBEKISTON RESPUBLIKASI FARG`ONA VILOYATI               MILLIY �TOJMOT� FEDERATSIYASI";
                    infotext.text = "    Tojmot o`yini O`zbekiston Respublikasi Innovatsion rivojlanish vazirligi tomonidan taqdim etilgan �Tojmot � aql gimnastikasi� o�yinining matematik modelini yaratish orqali uning dasturiy ta�minotini ishlab chiqish loyihasi doirasida tayyorlangan.";
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
            federatsiya.text = "O`ZBEKISTON RESPUBLIKASI FARG`ONA VILOYATI               MILLIY �TOJMOT� FEDERATSIYASI";
            infotext.text = "    Tojmot o`yini O`zbekiston Respublikasi Innovatsion rivojlanish vazirligi tomonidan taqdim etilgan �Tojmot � aql gimnastikasi� o�yinining matematik modelini yaratish orqali uning dasturiy ta�minotini ishlab chiqish loyihasi doirasida tayyorlangan.";
            infotitle.text = "Dastur haqida";
            infoclose.text = "Yopish";
            buttonqoidalar.text = "O`yin qoidasi";
            qoidatitle.text = "O`yin qoidalari";
            qoidaclose.text = "Yopish";
            qoidalar.sprite = uzqoida;
        }


    }


}
