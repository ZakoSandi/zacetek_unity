using UnityEngine;
using System.Collections;

public class NevemSystem : MonoBehaviour {
    public int theDamage = 50;
    public float distance;
    public int zdravje;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ;

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward)))
            {
                distance = hit.distance;
                hit.transform.SendMessage("ApplyDamage", theDamage, SendMessageOptions.DontRequireReceiver);
            }
        }
	}
   

}




