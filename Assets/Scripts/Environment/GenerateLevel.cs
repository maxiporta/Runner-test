using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creatingSection = false;
    public int sectionNumber;
    public int secToWait = 2;

    void Update()
    {
        if(creatingSection == false) {
            creatingSection = true;
            StartCoroutine(GenerateSeccion());       
        }
    
    }

    IEnumerator GenerateSeccion() {
        sectionNumber = Random.Range(0, 3);
        Instantiate(section[sectionNumber], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(secToWait);
        creatingSection = false;
    }
}
