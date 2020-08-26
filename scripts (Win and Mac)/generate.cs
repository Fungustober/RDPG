using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class generate : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public List<string> list1;
    public List<string> list2;
    public string path = "\\Adjective.txt";
    public string path2 = "\\Noun.txt";

    void Start()
    {
        StreamReader read = new StreamReader(path);
        for(int i = 0; i< File.ReadAllLines(path).Length; i++)
        {
            list1.Add(read.ReadLine());
        }
        read.Close();
        StreamReader read2 = new StreamReader(path2);
        for (int i = 0; i < File.ReadAllLines(path2).Length; i++)
        {
            list2.Add(read2.ReadLine());
        }
        read2.Close();
        gen();
    }

    public void gen()
    {
        string op1 = list1[UnityEngine.Random.Range(0, list1.Count)];
        string op2 = list2[UnityEngine.Random.Range(0, list2.Count)];
        string[] procOP2;
        text1.GetComponent<TextMeshProUGUI>().text = op1;
        if(op1[0] == 'A' || op1[0] == 'E' || op1[0] == 'I' || op1[0] == 'O' || op1[0] == 'U')
        {
            text3.GetComponent<TextMeshProUGUI>().text = "An";
        }
        else
        {
            text3.GetComponent<TextMeshProUGUI>().text = "A";
        }
        if(op2[0] == '+')
        {
            procOP2 = op2.Split('+');
            text2.GetComponent<TextMeshProUGUI>().text = procOP2[1];
            string op3 = list1[UnityEngine.Random.Range(0, list1.Count)];
            text4.GetComponent<TextMeshProUGUI>().text = op3;
            if (op3[0] == 'A' || op3[0] == 'E' || op3[0] == 'I' || op3[0] == 'O' || op3[0] == 'U')
            {
                text5.GetComponent<TextMeshProUGUI>().text = "An";
            }
            else
            {
                text5.GetComponent<TextMeshProUGUI>().text = "A";
            }
        }
        else
        {
            text2.GetComponent<TextMeshProUGUI>().text = op2;
            text4.GetComponent<TextMeshProUGUI>().text = "";
            text5.GetComponent<TextMeshProUGUI>().text = "";
        }

    }
    public void retToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
