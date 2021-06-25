using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Buttonmanager : MonoBehaviour
{
    playermove playerMove = null;
    GameManager gameManager = null;
    OrbMove orbMove = null;

    void Start()
    {
        playerMove = FindObjectOfType<playermove>();
        orbMove = FindObjectOfType<OrbMove>();
        gameManager = FindObjectOfType<GameManager>();
    }

    //�÷��̾� �̵� ��ư ������ ��
    public void up()
    {
        playerMove.inputup = true;
    }
    public void down()
    {
        playerMove.inputdown = true;
    }
    public void left()
    {
        playerMove.inputleft = true;
    }
    public void right()
    {
        playerMove.inputright = true;
    }

    //�÷��̾� �̵� ��ư ������ ������� ��
    public void up1()
    {
        playerMove.inputup = false;
    }
    public void down1()
    {
        playerMove.inputdown = false;
    }
    public void left1()
    {
        playerMove.inputleft = false;
    }
    public void right1()
    {
        playerMove.inputright = false;
    }

    //���� �̵� ��ư ������ ��
    public void orbup()
    {
        orbMove.inputorbup = true;
    }
    public void orbdown()
    {
        orbMove.inputorbdown = true;
    }
    public void orbleft()
    {
        orbMove.inputorbleft = true;
    }
    public void orbright()
    {
        orbMove.inputorbright = true;
    }

    //���� �̵� ��ư ������ ������� ��
    public void orbup1()
    {
        orbMove.inputorbup = false;
    }
    public void orbdown1()
    {
        orbMove.inputorbdown = false;
    }
    public void orbleft1()
    {
        orbMove.inputorbleft = false;
    }
    public void orbright1()
    {
        orbMove.inputorbright = false;
    }
}
