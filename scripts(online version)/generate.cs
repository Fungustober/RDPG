using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class generate : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public List<string> list1;
    public List<string> list2;
    public string comppath1;
    public string comppath2;
    public string op1;

    void Start()
    {
        StartCoroutine("boi");
    }

    public void gen()
    {
        string op1 = list1[UnityEngine.Random.Range(0, list1.Count)];
        string op2 = list2[UnityEngine.Random.Range(0, list2.Count)];
        if (op1[0] == 'A' || op1[0] == 'E' || op1[0] == 'I' || op1[0] == 'O' || op1[0] == 'U')
        {
            text3.GetComponent<TextMeshProUGUI>().text = "An";
        }
        else
        {
            text3.GetComponent<TextMeshProUGUI>().text = "A";
        }
        string[] procOP2;
        text1.GetComponent<TextMeshProUGUI>().text = op1;
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
    public IEnumerator boi()
    {
        yield return new WaitForSeconds(0.1f);
        string[] tempList = new string[0];
        if (comppath1 == "adjective")
        {
            tempList = GetComponent<adjective>().adjList;
        }
        else
        {
            tempList = GetComponent<noun>().nounList;
        }
        foreach (string i in tempList)
        {
            list1.Add(i);
        }
        if (comppath2 == "noun")
        {
            tempList = GetComponent<noun>().nounList;
        }
        else
        {
            tempList = GetComponent<verb>().verbList;
        }
        foreach (string i in tempList)
        {
            list2.Add(i);
        }
        gen();
    }
}
