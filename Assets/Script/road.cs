using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{

    public GameObject roadPrefab;
    public Vector3 lastRoad;
    public float offset = 0.630f;
    public int counter = 0;
    // Start is called before the first frame update
    public void StartBuilding()
    {   
        InvokeRepeating("CreateNewRoadPart", 1f, 0.5f);
    }
    public void CreateNewRoadPart()
    {
        Debug.Log("create");
        Vector3 spawn = Vector3.zero;
        float chance = Random.Range(0, 100);
        if (chance < 50)
        {
            spawn = new Vector3(lastRoad.x + offset, lastRoad.y, lastRoad.z + offset);
        }
        else
        {
            spawn = new Vector3(lastRoad.x - offset, lastRoad.y, lastRoad.z + offset);
        }
        GameObject r = Instantiate(roadPrefab, spawn, Quaternion.Euler(0,45,0));
        counter++;
        lastRoad = r.transform.position;

        if(counter % 7==0)
        {
            r.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

   
}
