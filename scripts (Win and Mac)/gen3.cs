using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gen3 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public List<string> list1;
    public List<string> list2;
    public List<string> list3;
    public string path = "Adjective.txt";
    public string path2 = "Noun.txt";
    public string path3 = "Verb.txt";

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
        StreamReader read3 = new StreamReader(path3);
        for (int i = 0; i < File.ReadAllLines(path3).Length; i++)
        {
            list3.Add(read3.ReadLine());
        }
        read3.Close();
        gen();
    }

    public void gen()
    {
        string op1 = list1[UnityEngine.Random.Range(0, list1.Count)];
        string op2 = list2[UnityEngine.Random.Range(0, list2.Count)];
        text1.GetComponent<TextMeshProUGUI>().text = op1;
        text2.GetComponent<TextMeshProUGUI>().text = op2;
        if (op1[0] == 'A' || op1[0] == 'E' || op1[0] == 'I' || op1[0] == 'O' || op1[0] == 'U')
        {
            text3.GetComponent<TextMeshProUGUI>().text = "An";
        }
        else
        {
            text3.GetComponent<TextMeshProUGUI>().text = "A";
        }
        string op3 = list3[UnityEngine.Random.Range(0, list2.Count)];
        string[] procOP3;
        if (op3[0] == '+')
        {
            procOP3 = op3.Split('+');
            text4.GetComponent<TextMeshProUGUI>().text = procOP3[1];
            string op4 = list2[UnityEngine.Random.Range(0, list1.Count)];
            text5.GetComponent<TextMeshProUGUI>().text = op4;
            if (op4[0] == 'A' || op4[0] == 'E' || op4[0] == 'I' || op4[0] == 'O' || op4[0] == 'U')
            {
                text6.GetComponent<TextMeshProUGUI>().text = "An";
            }
            else
            {
                text6.GetComponent<TextMeshProUGUI>().text = "A";
            }
        }
        else
        {
            text4.GetComponent<TextMeshProUGUI>().text = op3;
            text5.GetComponent<TextMeshProUGUI>().text = "";
            text6.GetComponent<TextMeshProUGUI>().text = "";
        }
    }
    public void retToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
