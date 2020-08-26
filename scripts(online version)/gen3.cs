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

    void Start()
    {
        StartCoroutine("boi");
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
    public IEnumerator boi()
    {
        yield return new WaitForSeconds(0.1f);
        string[] tempList = new string[0];

        tempList = GetComponent<adjective>().adjList;
        foreach (string i in tempList)
        {
            list1.Add(i);
        }

        tempList = GetComponent<noun>().nounList;
        foreach (string i in tempList)
        {
            list2.Add(i);
        }

        tempList = GetComponent<verb>().verbList;
        foreach (string i in tempList)
        {
            list3.Add(i);
        }

        gen();
    }
}
