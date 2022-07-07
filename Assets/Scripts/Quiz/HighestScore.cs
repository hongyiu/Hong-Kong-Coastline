using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    public string Location;
    private FirebaseManager firebaseManager;

    // Start is called before the first frame update
    void Start()
    {
        firebaseManager = GameObject.Find("FirebaseManager").GetComponent<FirebaseManager>();
        if (firebaseManager.User != null)
        { 
            firebaseManager.LoadScoreData(Location);
        }
    }
}
