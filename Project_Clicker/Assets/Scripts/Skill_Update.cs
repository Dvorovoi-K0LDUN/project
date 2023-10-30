using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Update : MonoBehaviour
{
    public GameObject Skill_Strong;

    public void ShowSkillStrong1()
    {
        Skill_Strong.gameObject.SetActive(true);
    }


    public void Exit()
    {
        Skill_Strong.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
