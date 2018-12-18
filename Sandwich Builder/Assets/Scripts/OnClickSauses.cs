using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnClickSauses : MonoBehaviour
{

    [SerializeField]
    Sauses sause;

    public void onClick()
    {
        if (!GameManager.Instance.selectedSandwich.sauses.Contains(sause))
        {
            GameManager.Instance.selectedSandwich.sauses.Add(sause);
        }
        else if (GameManager.Instance.selectedSandwich.sauses.Contains(sause))
        {
            GameManager.Instance.selectedSandwich.sauses.Remove(sause);
        }

    }
}

