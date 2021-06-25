using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttontouch : MonoBehaviour
{

    Buttonmanager buttonManager = null;
    GameManager gamemanager = null;

    void Start()
    {
        buttonManager = GetComponent<Buttonmanager>();
        gamemanager = FindObjectOfType<GameManager>();
    }
}
