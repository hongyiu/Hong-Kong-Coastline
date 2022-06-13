using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSwitch : MonoBehaviour
{
    public GameObject[] background;
    public Button NextButton;
    public Button PrevButton;

    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= background.Length - 1)
        {
            index = background.Length - 1;
            NextButton.gameObject.SetActive(false);
        }
        if (index <= 0)
        {
            index = 0;
            background[0].gameObject.SetActive(true);
            PrevButton.gameObject.SetActive(false);

        }
    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
            PrevButton.gameObject.SetActive(true);
        }

        Debug.Log(index);
    }

    public void Prev()
    {
        index -= 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }

        Debug.Log(index);
    }
}
