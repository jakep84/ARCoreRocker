using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{


    public GameObject Prefab;
    //GameObject PrefabClone;
    public int instanceDuration;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayCastHit;

            if (Physics.Raycast(ray.origin, ray.direction, out rayCastHit, Mathf.Infinity))
            {
                StartCoroutine(hotspotActivator());
            }
        }
    }


    IEnumerator hotspotActivator()
    {
        //Activate the prefab 
		Prefab.SetActive(true);
		//PrefabClone = Instantiate(Prefab,Prefab.transform.position, Prefab.transform.rotation) as GameObject;
		Debug.Log("Mouse Click");

        //Wait 5 seconds
		yield return new WaitForSeconds(5);

        //Disable the prefab
		Prefab.SetActive(false);
		//Destroy(PrefabClone, instanceDuration);
		Debug.Log(("instane destroyed"));
    }

}
