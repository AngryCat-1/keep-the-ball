using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    [SerializeField] int Score;
    [SerializeField] Text Scoretext;
    [SerializeField] int record;
    [SerializeField] Text Recordtext;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("gametwoRecord"))  // проверяем, есть ли в сохранении подобная информация
        {
            record = PlayerPrefs.GetInt("gametwoRecord");

        }
        InvokeRepeating("ScoreClass", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = Score + " очков";

        if (record < Score)
        {
            record = Score;
        }
        Recordtext.text = "рекорд: " + record;
    }
    private void OnTriggerEnter(Collider colider)
    {
        if (colider.tag  == "Ball")
        {
            SceneManager.LoadScene("SampleScene 2");
        }
    }
    void ScoreClass()
    {
        Score += 1;
        PlayerPrefs.SetInt("gametwoRecord", record);
    }
}
