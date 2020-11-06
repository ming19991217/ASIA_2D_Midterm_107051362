using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorUI : MonoBehaviour
{
    public GameObject E;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            E.SetActive(true);
            anim.SetTrigger("Trigger");
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            E.SetActive(false);
            anim.SetTrigger("Trigger");
        }

    }
}
