using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCllick_Kiosk : MonoBehaviour
{
    public GameObject buy;
    public GameObject card;
    public GameObject Main;
    public GameObject Check;
    public GameObject End;
 
    public void buy_btn_clicked()
    {
        Main.SetActive(false);
        buy.SetActive(true);
 
    }
    public void check_btn_clicked()
    {
        buy.SetActive(false);
        Check.SetActive(true);
 
    }
    public void check_back_clicked()
    {
        Check.SetActive(false);
        buy.SetActive(true);
    }
    public void card_btn_clicked()
    {
        Check.SetActive(false);
        card.SetActive(true);
    }
    public void end_btn_clicked()
    {
        card.SetActive(false);
        End.SetActive(true);
    }
}
