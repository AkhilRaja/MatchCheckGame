using UnityEngine;
using System.Collections;
using B83.ExpressionParser;
using System;

public class CallParser : MonoBehaviour {
    string substr;
    int integer_answer;
    public bool correct = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

      //  var parser = new ExpressionParser();
     //   Expression exp = parser.EvaluateExpression("5 +3*2 = 13");
     //   Debug.Log("Result: " + exp.Value);
    }

    public void CheckAnswer(string value, string name, string input)
    {
        if(name == "One")
        {
            input = input.Remove(0,1);
        }
        if (name == "Two")
        {
            input = input.Remove(1, 1);
        }
        if (name == "Three")
        {
            input = input.Remove(2, 1);
        }
        if (name == "Four")
        {
            input = input.Remove(3, 1);
        }
        if (name == "Five")
        {
            input = input.Remove(4, 1);
        }
        if (name == "Six")
        {
            input = input.Remove(5, 1);
        }
        if (name == "Seven")
        {
            input = input.Remove(6, 1);
        }
        if (name == "Eight")
        {
            input = input.Remove(7, 1);
        }

         

       
        //Debug.Log(splitString);
        
        string[] splitString = input.Split(new string[] { "=" }, StringSplitOptions.None);
        Debug.Log(splitString[1]);

        var parser = new ExpressionParser();
        Expression exp = parser.EvaluateExpression(splitString[0]);
        int.TryParse(splitString[1], out integer_answer);

        if (exp.Value == integer_answer)
            correct = true;
        else
            correct = false;
    }
}
