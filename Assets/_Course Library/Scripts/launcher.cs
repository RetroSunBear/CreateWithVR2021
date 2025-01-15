using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject projectile;
    public GameObject SpawnPoint;
    public GameObject tvControl;

    // Start is called before the first frame update
   public void Shoot()
    {
        Instantiate(projectile, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
    }
}
