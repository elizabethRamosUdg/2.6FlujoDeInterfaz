using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sing : MonoBehaviour
{
    Animator sing_Animator;

    GameObject sing;

    GameObject[] sings;

    void Awake()
    {
        sings = GameObject.FindGameObjectsWithTag("Sing");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        foreach (GameObject sing in sings)
        {
            sing_Animator = sing.GetComponent<Animator>();
            sing_Animator.SetBool("isSinging", true);
        }

    }

    void OnTriggerExit2D(Collider2D collider)
    {
        foreach (GameObject sing in sings)
        {
            sing_Animator = sing.GetComponent<Animator>();
            sing_Animator.SetBool("isSinging", false);
        }
    }
}