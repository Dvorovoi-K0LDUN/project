using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int mana;
    [SerializeField] int Gold;

    public int Total_mana;
    public Text manaText;
    public Text GoldText;

    void Start()
    {
        mana = PlayerPrefs.GetInt("mana");
        Total_mana = 0;
        PlayerPrefs.SetInt("Total_mana", Total_mana);
        Total_mana = PlayerPrefs.GetInt("Total_mana");
        PlayerPrefs.SetInt("Gold", Gold);

    }

    public void ButtonClick()
    {
        mana++;
        Total_mana++;
        

        PlayerPrefs.SetInt("mana", mana);
        PlayerPrefs.SetInt("Total_mana", Total_mana);

    }


    //Навигация в меню
    public void ToUpdate()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToIvent_Menu()
    {
        SceneManager.LoadScene(2);
    }

    public void ToArmor_Menu()
    {
        SceneManager.LoadScene(3);
    }

    public void ToShop_Menu()
    {
        SceneManager.LoadScene(4);
    }


    // Update is called once per frame
    void Update()
    {
        Gold = PlayerPrefs.GetInt("Gold");
        manaText.text = mana.ToString();
        GoldText.text = Gold.ToString();

    }
}