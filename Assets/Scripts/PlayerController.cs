using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] projectiles;
    int projectileIndex ;
        // Update is called once per frame
    void Update()
    {       
        //acciones
        if(Input.GetKeyDown(KeyCode.Space))
		{
            //lanzar proyectil
            projectileIndex = Random.Range(0, projectiles.Length);
            Instantiate(projectiles[projectileIndex], 
                        transform.position, 
                        projectiles[projectileIndex].transform.rotation);
		}
    }
}
