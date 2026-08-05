using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;

    public bool canFire;
    private float timer;

    public float fireDelay;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //make gun look at mouse
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        //gunfire
        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > fireDelay)
            {
                canFire = true;
                timer = 0;
            }
        }

        if (Input.GetMouseButton(0)&& canFire == true)
        {
            canFire = false;
           Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
        
    }
}
