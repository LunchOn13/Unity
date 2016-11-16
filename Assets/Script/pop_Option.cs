using UnityEngine;
using System.Collections;

public class pop_Option : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(false);
	}
	

    public void Enable()
    {
        Time.timeScale = 0;
        this.gameObject.SetActive(true);
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

}
