using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountToGamemodethree : MonoBehaviour
{
    [SerializeField] public  Text textcountball;
    [SerializeField] public int countball;
    GameObject ball;
    [SerializeField] int record;
    [SerializeField] Text textrecord;
    [SerializeField] GameObject platform1;
    [SerializeField] GameObject platform2;
    [SerializeField] GameObject platform3;

    public DeleteUseBall DeleteUseBall;
    public List<GameObject> objs;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("gameRecordthree"))  // ���������, ���� �� � ���������� �������� ����������
        {
            record = PlayerPrefs.GetInt("gameRecordthree");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (countball > 25)
        {
            
        }
        ball = GameObject.FindWithTag("Ball");
        textcountball.text = countball + " ����� �� ���������";
        countball = objs.Count * 2;
        if (countball > record)
        {
            record = countball;
        }
        textrecord.text = "������: " + record;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            PlayerPrefs.SetInt("gameRecordthree", record);
            objs.Add(other.gameObject);
        }
        if (other.tag == "BadBall")
        {

            SceneManager.LoadScene("SampleScene 1");
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {

            objs.Remove(other.gameObject);
        }
    }
}
