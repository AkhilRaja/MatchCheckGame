using UnityEngine;
using System.IO;
using System.Collections;

public class ReadFromFile : MonoBehaviour {

    public string input_string;
    StreamReader reader = new StreamReader(@"Equat.txt");
    // Use this for initialization
    void Start () {
       
    }
   public void read_FromFile()
    { 
        string s = reader.ReadLine();
        if(s != null)
        {
            input_string = s;
        }
    }

}
