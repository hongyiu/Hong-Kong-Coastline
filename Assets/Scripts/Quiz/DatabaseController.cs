using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseController : MonoBehaviour
{
    public static DatabaseController Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null) {
			GameObject.Destroy(this.gameObject);
			return;
		}

		Instance = this;
    }

	// public Database CreateDatabase() {
	// 	GameObject popUpGo = Instantiate(Resources.Load("UI/Popup") as GameObject);
	// 	return popUpGo.GetComponent<Popup>();
	// }
}
