using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDamage : MonoBehaviour
{
    private SpriteRenderer spriteRenderer = null;
    private GameManager gameManager = null;



    [SerializeField]
    private int hp = 3;
    [SerializeField]
    private int score = 10;

    private Collider2D col = null;

    public bool isDamaged = false;
    public bool isDead = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindObjectOfType<GameManager>();
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return;
        if (collision.CompareTag("iceorb"))
        {
            if (isDamaged) return;
            isDamaged = true;
            StartCoroutine(Damaged());
            if (hp <= 0)
            {
                isDead = true;
                col.enabled = false;
                gameManager.AddScore(score);
                StartCoroutine(Dead());
            }
        }
    }
    private IEnumerator Damaged()
    {
        spriteRenderer.material.SetColor("_Color", new Color(0f, 0f, 0f, 0f));
        hp--;
        yield return new WaitForSeconds(0.3f);
        spriteRenderer.material.SetColor("_Color", new Color(1f, 1f, 1f, 1f));
        isDamaged = false;
    }

    private IEnumerator Dead()
    {
        spriteRenderer.material.SetColor("_Color", new Color(0f, 0f, 0f, 0f));
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
