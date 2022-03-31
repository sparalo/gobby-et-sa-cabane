using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCondition : MonoBehaviour
{
    public GameObject boss1;
    public GameObject boss2;
    public GameObject boss3;

    // Update is called once per frame
    void FixedUpdate()
    {
        boss1 = GameObject.Find("Big Zombie");
        boss2 = GameObject.Find("Big Demon");
        boss3 = GameObject.Find("Big Skelet");

        if ((boss1 == null) && (boss2 == null) && (boss3 == null))
        {
            SceneManager.LoadScene(1);
        }
    }
}
