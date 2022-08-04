 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSwitch : MonoBehaviour
{
    public GameObject[] maps;
    public Button NextButton;
    public Button PrevButton;

    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        for (int i = 1; i < maps.Length; i++)
        {
            maps[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= maps.Length - 1)
        {
            index = maps.Length - 1;
            maps[index].gameObject.SetActive(true);
            NextButton.gameObject.SetActive(false);
        }
        if (index <= 0)
        {
            index = 0;
            maps[index].gameObject.SetActive(true);
            PrevButton.gameObject.SetActive(false);
        }
    }

    public void Next()
    {
        for (int i = 0; i < maps.Length; i++)
        {
            maps[i].gameObject.SetActive(false);    
        }

        index += 1;
        Debug.Log(index);
        maps[index].gameObject.SetActive(true);
        PrevButton.gameObject.SetActive(true);
        
    }

    public void Prev()
    {
        for (int i = 0; i < maps.Length; i++)
        {
            maps[i].gameObject.SetActive(false);
        }

        index -= 1;
        Debug.Log(index);
        maps[index].gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
    }
}
