using UnityEngine;
using System.Collections;

public class selfdestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DestroyMe()
    {
        Destroy(transform.parent.gameObject);
    }
        
}
