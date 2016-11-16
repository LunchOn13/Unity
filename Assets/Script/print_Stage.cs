using UnityEngine;
using System.Collections;

public class print_Stage : MonoBehaviour {

    public int stage_Number = 1;
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<UILabel>().text = stage_Number.ToString();
	}
}
