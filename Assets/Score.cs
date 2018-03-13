using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score = 0;
    // Use this for initialization
    [SerializeField]
    GameObject score_text;
    void Start () {
	
	}
	public void updatescore()
    {
        score++;
        score_text.GetComponent<Text>().text = score.ToString();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
