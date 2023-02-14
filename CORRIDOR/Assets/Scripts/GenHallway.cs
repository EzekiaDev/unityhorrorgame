using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenHallway : MonoBehaviour
{

    public Transform wall;
    public Transform ceilingBars;
    float wallGenPos = 0f;
    float barsGenPos = 0f;

    void FixedUpdate()
    {
        Transform genWall = Instantiate(wall, new Vector3(wallGenPos - 19.67f, 1.791f, -1.979999f), Quaternion.identity);
        genWall.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        genWall.transform.localRotation = new Quaternion(0, 180, 0, 0);

        Transform genWall2 = Instantiate(wall, new Vector3(wallGenPos - 19.67f, 1.791f, 1.989f), Quaternion.identity);
        genWall2.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);

        wallGenPos += 2.4f;

        Transform genCeilingBars = Instantiate(ceilingBars, new Vector3(barsGenPos - 13.908f, 3.492f, -2.02f), Quaternion.identity);
        genCeilingBars.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        genCeilingBars.transform.localRotation = new Quaternion(0, 90, 0, 0);

        barsGenPos += 6.5f;
    }
}
