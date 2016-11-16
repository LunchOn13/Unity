using UnityEngine;
using System.Collections;

public class bring_Numbers : MonoBehaviour {

    public GameObject Stage;
    public GameObject Score;
    public GameObject Stage_set;
    public GameObject Score_set;

	public void bringScore()
    {
        Score_set.GetComponent<UILabel>().text=Score.GetComponent<UILabel>().text;
    }

    public void bringStage()
    {
        Stage_set.GetComponent<UILabel>().text = Stage.GetComponent<UILabel>().text;
    }
}
