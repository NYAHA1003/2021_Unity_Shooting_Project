using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Vector2 minPosition { get; private set; }
    public Vector2 maxPosition { get; private set; }
    public Vector2 playerminPosition { get; private set; }
    public Vector2 playermaxPosition { get; private set; }

    [SerializeField]
    private GameObject slime;
    [SerializeField]
    private GameObject fireSlime;
    [SerializeField]
    private GameObject iceSlime;
    [SerializeField]
    private GameObject poisonSlime;
    [SerializeField]
    private Text scoreText = null;
    [SerializeField]
    private Text highScoreText = null;
    [SerializeField]
    private Text lifeText = null;
    [SerializeField]
    private int life = 3;

    private int score = 0;
    private int highScore = 0;

    void Start()
    {
        minPosition = new Vector2(-1.8f, -0.8f);
        maxPosition = new Vector2(1.8f, 0.8f);
        playerminPosition = new Vector2(-1.8f, -0.8f);
        playermaxPosition = new Vector2(0.8f, 0.8f);
        StartCoroutine(SpawnSlime());
        StartCoroutine(SpawnFireSlime());
        StartCoroutine(SpawnIceSlime());
        StartCoroutine(SpawnPoisonSlime());
        UpdateUI();
    }

    public void Dead()
    {
        life--;
        if (life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        UpdateUI();
    }

    public void AddScore(int addScore)
    {
        score += addScore;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HIGHSCORE", score);
        }
        UpdateUI();
    }

    private IEnumerator SpawnSlime()
    {
        float randomY = 0f;
        float randomTime = 0f;
        while (true)
        {
            randomY = Random.Range(-0.85f, 0.85f);
            randomTime = Random.Range(7f, 10f);
            Instantiate(slime, new Vector2(2.3f, randomY), Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }
    private IEnumerator SpawnFireSlime()
    {
        float randomY = 0f;
        float randomTime = 0f;
        while (true)
        {
            randomY = Random.Range(-0.85f, 0.85f);
            randomTime = Random.Range(7f, 10f);
            Instantiate(fireSlime, new Vector2(2.3f, randomY), Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }
    private IEnumerator SpawnIceSlime()
    {
        float randomY = 0f;
        float randomTime = 0f;
        while (true)
        {
            randomY = Random.Range(-0.85f, 0.85f);
            randomTime = Random.Range(7f, 10f);
            Instantiate(iceSlime, new Vector2(2.3f, randomY), Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }

    private IEnumerator SpawnPoisonSlime()
    {
        float randomY = 0f;
        float randomTime = 0f;
        while (true)
        {
            randomY = Random.Range(-0.85f, 0.85f);
            randomTime = Random.Range(7f, 10f);
            Instantiate(poisonSlime, new Vector2(2.3f, randomY), Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }

    public void UpdateUI()
    {
        lifeText.text = string.Format("LIFE\n{0}", life);
        scoreText.text = string.Format("SCORE\n{0}", score);
        highScoreText.text = string.Format("HIGHSCORE\n{0}", highScore);
    }
}
