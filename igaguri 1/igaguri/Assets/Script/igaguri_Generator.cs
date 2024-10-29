using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguri_Generator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 woldDir = ray.direction;
            igaguri.GetComponent<igaguri_Cotroller>().Shoot(woldDir.normalized * 2000);
        }

    }
}
