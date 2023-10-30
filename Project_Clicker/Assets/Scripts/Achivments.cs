using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achivments : MonoBehaviour

   
{
    public int Gold;
    public int Total_mana;
    [SerializeField] Button Achiv_1_btn;
    [SerializeField] bool isFirst;
    

    // Start is called before the first frame update
    void Start()
    {
        isFirst = false;
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0);
    }

    public void GetFirst()
    {
        int Gold = PlayerPrefs.GetInt("Gold");// priz
        Gold += 150;
        PlayerPrefs.SetInt("Gold", Gold);
        isFirst = true;
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0) ;
    }

    // Update is called once per frame
    void Update()

    {
        Gold = PlayerPrefs.GetInt("Gold");
        Total_mana = PlayerPrefs.GetInt("Total_mana");
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;

        if (Total_mana >= 10 && !isFirst)
        {
            Achiv_1_btn.interactable = true;
        }
        else
        {
            Achiv_1_btn.interactable = false;
        }
    }
}
