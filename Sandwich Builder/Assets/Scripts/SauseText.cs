using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SauseText : MonoBehaviour
{
    [SerializeField]
    int instance;
    // Use this for initialization
    void Start()
    {
        if (instance < GameManager.Instance.selectedSandwich.sauses.Count)
        {
            GetComponent<Text>().text = GameManager.Instance.selectedSandwich.sauses[instance].ToString();
        }
        else
            GetComponent<Text>().text = "";

    }

    // Update is called once per frame
    void Update()
    {

    }
}