using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playermove : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    
    public bool inputup = false;
    public bool inputdown = false;
    public bool inputleft = false;
    public bool inputright = false;
    GameManager gameManager = null;
    private SpriteRenderer spriteRenderer = null;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
}

    void Update()
    {
        Vector3 pos = transform.position;
        if(inputup == true)
        {
            pos.y += speed * Time.deltaTime;
        }
        if (inputdown == true)
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (inputright == true)
        {
            pos.x += speed * Time.deltaTime;
        }
        if (inputleft == true)
        {
            pos.x -= speed * Time.deltaTime;
        }
        pos.x = Mathf.Clamp(pos.x, gameManager.playerminPosition.x, gameManager.playermaxPosition.x);
        pos.y = Mathf.Clamp(pos.y, gameManager.playerminPosition.y, gameManager.playermaxPosition.y);
        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDamaged) return;
        if (collision.CompareTag("slime"))
        {
            StartCoroutine(Damaged());
        }
    }

    private bool isDamaged = false;
    private IEnumerator Damaged()
    {
        if (!isDamaged)
        {
            isDamaged = true;
            gameManager.Dead();
            for (int i = 0; i < 3; i++)
            {
                spriteRenderer.enabled = false;
                yield return new WaitForSeconds(0.2f);
                spriteRenderer.enabled = true;
                yield return new WaitForSeconds(0.2f);
            }
            isDamaged = false;
        }
    }
}
