using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_link : MonoBehaviour
{
    public InputField mainInputField;
    public static string web_url;
    
  
    public void GetInput (string s )
    {
        web_url = s;
        
        Debug.Log("\"https://"+web_url+"\"");
    }
}
