using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text healthTxt;
    public int health;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tourelle")
        {
            LooseHealth(20);
            Destroy(collision.gameObject);
        }
    }

    private void LooseHealth(int val)
    {
        health = health - val;
        healthTxt.text = health + "%";
        if(health < 0)
        {
            health = 0;
            Console.WriteLine("Vous êtes mort");


            //StartCoroutine("Reload");
            new WaitForSecondsRealtime(15);
            SceneManager.LoadScene(0);
        }
    }

}
