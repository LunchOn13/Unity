using UnityEngine;
using System.Collections;

public class isGameOver : MonoBehaviour {

    void Start()
    {
        this.enabled = false;
    }
    public GameObject Player;
	// Update is called once per frame
	void Update () {


       if(!Player.GetComponent<print_HealthBar>().die)
        {
            this.enabled = true;
        }

	}
}
