using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject loginPanel;
    public GameObject MainPanel;
    public GameObject signupPanel;
    public GameObject leftMenuPanel;
    public GameObject ShowroomPanel;
    public GameObject ShopPanel;
    public GameObject QRPanel;


    public void ShowLoginPanel()
    {
        // 로그인 패널 표시
        StartPanel.SetActive(false);
        loginPanel.SetActive(true);
    }

    public void ShowMainPanel()
    {
        loginPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void ShowSignupPanel()
    {
        // 회원가입 패널 표시
        loginPanel.SetActive(false);
        signupPanel.SetActive(true);
    }

    public void BackToLoginPanel()
    {
        loginPanel.SetActive(true);
        signupPanel.SetActive(false);
    }

    public void ShowShowroomPanel()
    {
        leftMenuPanel.SetActive(false);
        ShowroomPanel.SetActive(true);
    }
    public void ShowShopPanel()
    {
        MainPanel.SetActive(false);
        ShopPanel.SetActive(true);
    }

    public void ShowQRPanel()
    {
        QRPanel.SetActive(true);
        ShopPanel.SetActive(false);
    }

    public void BackToMainPanel()
    {
        ShopPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void BackToShopPanel()
    {
        ShopPanel.SetActive(true);
        QRPanel.SetActive(false);
    }

    public void ExitShowroom()
    {
        ShowroomPanel.SetActive(false);
        leftMenuPanel.SetActive(true);
    }

    public void ExitMenu()
    {
        MainPanel.SetActive(false);
    }
}
