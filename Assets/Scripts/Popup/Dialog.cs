using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dialog : MonoBehaviour
{
	[TextArea(3,10)]
	public string Content;

    // Start is called before the first frame update
    void Start()
    {
		Button button = GetComponent<Button>();
		button.onClick.AddListener(() => {
			Popup popup = PopupController.Instance.CreatePopup();
			//Init popup with params (canvas, text, text(optional), text(optional), action(optional))
			popup.Init(PopupController.Instance.MainCanvas,
				Content
				);
		});
    }
}
