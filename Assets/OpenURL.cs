using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    public string lk = set_link_2.linkedin_url;
    public string web = set_link.web_url ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public  void linkedin()
    {

        Application.OpenURL("https://www.linkedin.com/in/aymeric-noblanc/");
        //Cette ligne ci-dessous remplace celle d'au-dessus pour l'affichage du lien écrit dans le InputField de la scene d'acceuil, idem pour la méthode website()
        //Application.OpenURL(web);
    }
    public void website()
    {
        Application.OpenURL("https://www.softoucan.com/");
        //Application.OpenURL(lk);
    }
}
