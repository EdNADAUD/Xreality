using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_link_2 : MonoBehaviour
{
    public static string linkedin_url;

    public void GetInput(string s)
    {
        linkedin_url = s;

        Debug.Log(linkedin_url);
    }
}
