using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectingSauses : MonoBehaviour
{

    [SerializeField]
    Sauses sause;
    bool selected;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.selectedSandwich.sauses.Contains(sause))
        {

            selected = true;
        }
        if (!GameManager.Instance.selectedSandwich.sauses.Contains(sause))
        {
            selected = false;
        }
        if (selected)
        {
            GetComponent<Button>().image.color = new Color(1, 1, 1, 1);
        }
        if (!selected)
        {
            GetComponent<Button>().image.color = new Color(1, 1, 1, .35f);
        }

    }

}
