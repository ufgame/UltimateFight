using UnityEngine;
using System.Collections;

public class PlayerInfoScript : MonoBehaviour {

    public string playerName;
    public string id;

	// Use this for initialization
	void Start () {
        Object.DontDestroyOnLoad(gameObject);
	}



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

}
