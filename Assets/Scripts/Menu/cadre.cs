using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cadre : MonoBehaviour
{
    public int slider = 0;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    // Start is called before the first frame update
    void Start()
    {
        slider = 1;
    }

    void Update()
    {
        if (slider == 4)
        {
            slider = 1;
        }

        if (slider == 0)
        {
            slider = 3;
        }

        if (slider == 1)
        {
            image1.gameObject.SetActive(true);
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(false);
        }

        if (slider == 2)
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(true);
            image3.gameObject.SetActive(false);
        }

        if (slider == 3)
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(true);
        }
    }


    public void gaucheImage()
    {
        slider -= 1;
        Debug.Log(slider);
    }
    public void droiteImage()
    {
        slider += 1;
        Debug.Log(slider);
    }
}
