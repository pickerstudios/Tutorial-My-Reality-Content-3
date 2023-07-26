using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_View_Switch : MonoBehaviour
{
    public string Animtrigger;
    public Animator anim;

    public Canvas CoffeeCav;


    private void Start()
    {
        CoffeeCav.gameObject.SetActive(false);
    }
    private void OnTriggerEnter( Collider other)
    {
        anim.SetTrigger(Animtrigger);
        CoffeeCav.gameObject.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("Default");
        CoffeeCav.gameObject.SetActive( false);
    }
}
