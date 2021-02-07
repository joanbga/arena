using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject Menu;

    public void ToogleMenu()
    {
        if (Menu)
        {
            Menu.SetActive(!Menu.activeInHierarchy);
        }
    }
}
