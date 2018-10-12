using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link : MonoBehaviour {
void Start () {
		
	}

    public void type()
    {
        Application.OpenURL("https://www.typeiqs.com/");
    }

    public void medium()
    {
        Application.OpenURL("https://medium.com/typeiqs");
    }

	 public void email()
    {
        Application.OpenURL("https://www.google.com/gmail/");
    }

	 public void linked()
    {
        Application.OpenURL("https://www.linkedin.com/in/guetteluis/");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
