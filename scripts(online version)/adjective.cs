using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adjective : MonoBehaviour
{
    public string[] adjList;
    public string adj = "Thunderous|Glamorous|Ugly|Stupid|Cool|Giant|Dead|Rabid|Dangerous|Defiant|Depressed|Annoyed|Anxious|Bewildered|Brave|Calm|Clumsy|Stinky|Cruel|Cute|Enchanting|Evil|Fierce|Filthy|Frantic|Glorious|Grumpy|Helpless|Hungry|Important|Jealous|Kind|Lucky|Lively|Misty|Modern|Nasty|Obedient|Old-Fashioned|Obnoxious|Outrageous|Pleasant|Powerful|Prickly|Putrid|Quaint|Repulsive|Selfish|Sleepy|Sore|Stormy|Strange|Tasty|Talented|Thoughtless|Tough|Upset|Victorious|Wandering|Witty|Worried|Zealous|Accurate|Boring|Cold|Delicate|Efficient|Faithful|Quick|Young";
    private void Start()
    {
        adjList = adj.Split('|');
    }
}
