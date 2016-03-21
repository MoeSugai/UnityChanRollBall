using UnityEngine;
using System.Collections;

public class GateController : MonoBehaviour {

    public GameObject Gate1;
    public GameObject Gate2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Gate1.SetActive(false);
            Gate2.SetActive(false);
            Debug.Log("O key was pressed.");
        }

    }
}
