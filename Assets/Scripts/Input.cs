using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Input : MonoBehaviour {

    // Use this for initialization
    [SerializeField] GameObject gameController;
    static bool myRoutine = false;
    string input;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
    }
   public void touch_input()
    {
        //gameObject.SetActive(false);

        //Read the Next String here.
        if (myRoutine == false)
        {
            myRoutine = true;
            StartCoroutine(ExecuteAfterTime(2));
            /////Logic to check if the Input is correct or wrong and then give the appropriate color
            input = this.gameObject.transform.GetChild(0).GetComponent<Text>().text;
            //Debug.Log(input);
            if (input == "=" || input == " = ")
            {
                gameObject.GetComponent<Image>().color = Color.red;
            }
            else
            {
                gameController.GetComponent<CallParser>().CheckAnswer(input, gameObject.name, gameController.GetComponent<PopulateDataonUI>().inputString);
                if (gameController.GetComponent<CallParser>().correct)
                {
                    gameObject.GetComponent<Image>().color = Color.green;
                    gameController.GetComponent<Score>().updatescore();
                }
                    
                else
                {
                    gameObject.GetComponent<Image>().color = Color.red;
                }
                    
            }
            
        }
            

        
        

    }

    IEnumerator ExecuteAfterTime(float time)
    {
        myRoutine = true;
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Image>().color = Color.white;
        
        gameController.GetComponent<PopulateDataonUI>().readNextString();
        gameController.GetComponent<PopulateDataonUI>().ChangeDataUI();
        myRoutine = false;
    }
}
