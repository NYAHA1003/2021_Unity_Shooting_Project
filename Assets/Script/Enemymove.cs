using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    private SpriteRenderer spriteRenderer = null;
    private GameManager gameManager = null;

    private Vector3 diff = Vector3.zero;
    private playermove player = null;

    [SerializeField]
    private float speed = 0.1f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindObjectOfType<GameManager>();
        player = FindObjectOfType<playermove>();
    }

    void Update()
    {
        diff = player.transform.position;
        transform.position = Vector2.MoveTowards(transform.localPosition, diff, speed * Time.deltaTime);
    }
}