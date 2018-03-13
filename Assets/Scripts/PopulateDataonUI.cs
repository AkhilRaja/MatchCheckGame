using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PopulateDataonUI : MonoBehaviour {

    
    public string inputString;
    [SerializeField]
    GameObject BoXContainerSix;
    [SerializeField]
    GameObject BoXContainerSeven;
    GameObject Box;
    [SerializeField] GameObject gameController;
    // Use this for initialization
    int i = 0;
	void Start () {

        gameController.GetComponent<ReadFromFile>().read_FromFile();
        inputString = gameController.GetComponent<ReadFromFile>().input_string;
        
        if (inputString.Length == 6)
        {
            BoXContainerSix.transform.position = new Vector3(0, 0, -9490);
            BoXContainerSeven.transform.position = new Vector3(500, 0, 0);
            Box = BoXContainerSix;
        }

        if (inputString.Length == 7)
        {
            BoXContainerSeven.transform.position = new Vector3(0, 0, 0);
            BoXContainerSix.transform.position = new Vector3(500, 0, 0); ;
            Box = BoXContainerSeven;
        }
        
        ChangeDataUI();
    }

    public void ChangeDataUI()
    {
        
        
        if (inputString.Length == 6)
        {
            BoXContainerSix.transform.position = new Vector3(0, 0, 0);
            BoXContainerSeven.transform.position = new Vector3(500, 0, 0);
            Box = BoXContainerSix;
        }

        if (inputString.Length == 7)
        {
            BoXContainerSeven.transform.position = new Vector3(0, 0, 0);
            BoXContainerSix.transform.position = new Vector3(500, 0, 0); 
            Box = BoXContainerSeven;
        }
       // Debug.Log(inputString.Length);
        
        for (i =0;i<inputString.Length;i++)
        {
            Box.transform.GetChild(i).GetChild(0).GetComponent<Text>().text = inputString[i] + "";
        }
        
        //Boxes[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = inputString[i]+ "";
    }
    
    public void readNextString()
    {
        gameController.GetComponent<ReadFromFile>().read_FromFile();
        inputString = gameController.GetComponent<ReadFromFile>().input_string;
    }
	
}
