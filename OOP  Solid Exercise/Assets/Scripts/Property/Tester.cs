using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tester : MonoBehaviour
{
    public BasicProperty prop;
    public PlayerData data;

    private void Start()
    {
        Debug.Log("**********_BasicProperty_****************");
        prop.Score = 10; // set 
        Debug.Log(prop.Score); // get
        Debug.Log("**********_PlayerData_****************");
        Debug.Log(data.playerName);
    }
}
