using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{

    // Use this for initialization
    void Start() {

      var random =  Random.Range(0,2);


      if (random <= 0.5)
          Debug.Log("Shoot right!");
      else
          Debug.Log("Shoot left!");
 
	}

    // Update is called once per frame
    void Update()
    {

    }
}
