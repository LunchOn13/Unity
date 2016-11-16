using UnityEngine;
using System.Collections;

public class option_Sound : MonoBehaviour {

    public AudioSource audio;

	// Update is called once per frame
	void Update () {
        audio.volume = this.GetComponent<UISlider>().value;
	}
}
