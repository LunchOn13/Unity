using UnityEngine;
using System.Collections;

public class print_Score : MonoBehaviour {

    public int number = 0;
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<UILabel>().text = number.ToString();
	}
}
