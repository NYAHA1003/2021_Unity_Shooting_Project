using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OrbMove : MonoBehaviour
{
    [SerializeField]
    private float orbspeed = 3f;
    [SerializeField]
    private GameObject[] Orb;

    public bool inputorbup = false;
    public bool inputorbdown = false;
    public bool inputorbleft = false;
    public bool inputorbright = false;
    GameManager gamemanager = null;
    private SpriteRenderer spriteRenderer = null;
    SwitchButton switchMod = null;

    void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        switchMod = FindObjectOfType<SwitchButton>();
        Orb[0].SetActive(true);
        Orb[1].SetActive(false);
        Orb[2].SetActive(false);
        Orb[3].SetActive(false);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        if (inputorbup == true)
        {
            pos.y += orbspeed * Time.deltaTime;
        }
        if (inputorbdown == true)
        {
            pos.y -= orbspeed * Time.deltaTime;
        }
        if (inputorbright == true)
        {
            pos.x += orbspeed * Time.deltaTime;
        }
        if (inputorbleft == true)
        {
            pos.x -= orbspeed * Time.deltaTime;
        }
        pos.x = Mathf.Clamp(pos.x, gamemanager.minPosition.x, gamemanager.maxPosition.x);
        pos.y = Mathf.Clamp(pos.y, gamemanager.minPosition.y, gamemanager.maxPosition.y);
        transform.position = pos;
        SummonOrb();
    }

    private void SummonOrb()
    {
        if(switchMod.mod == 1)
        {
            Orb[0].SetActive(false);
            Orb[1].SetActive(true);
            Orb[2].SetActive(false);
            Orb[3].SetActive(false);
        }
        else if (switchMod.mod == 2)
        {
            Orb[0].SetActive(false);
            Orb[1].SetActive(false);
            Orb[2].SetActive(true);
            Orb[3].SetActive(false);
        }
        else if (switchMod.mod == 3)
        {
            Orb[0].SetActive(false);
            Orb[1].SetActive(false);
            Orb[2].SetActive(false);
            Orb[3].SetActive(true);
        }
        else if (switchMod.mod == 0)
        {
            Orb[0].SetActive(true);
            Orb[1].SetActive(false);
            Orb[2].SetActive(false);
            Orb[3].SetActive(false);
        }
    }

}
