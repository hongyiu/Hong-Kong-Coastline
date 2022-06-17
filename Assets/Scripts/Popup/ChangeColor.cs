using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

		Action action = () => {
			Camera.main.backgroundColor = UnityEngine.Random.ColorHSV();
            Debug.Log("Action Button pressed");
		};

		Button button = GetComponent<Button>();
		button.onClick.AddListener(() => {
			Popup popup = PopupController.Instance.CreatePopup();
			//Init popup with params (canvas, text, text, text, action)
			popup.Init(PopupController.Instance.MainCanvas,
				"Do you really want to change color?",
				"Maybe not",
				"Sure!",
				action
				);
		});
    }
}
