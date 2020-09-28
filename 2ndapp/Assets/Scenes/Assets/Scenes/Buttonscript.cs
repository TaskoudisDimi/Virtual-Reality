using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Numerics;

public class Buttonscript : MonoBehaviour
{
    public Image imgCircle;
    //public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    public int distanceofRay = 10;
    private RaycastHit _hit;


    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

       // if (gvrTimer > totalTime)
       // {
       //     GVRClick.Invoke();
       // }
        Ray ray = Camera.main.ViewportPointToRay(new UnityEngine.Vector3(0.5f, 0.5f, 0f));
        if(Physics.Raycast(ray, out _hit, distanceofRay))
        {
            if (imgCircle.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {
                _hit.transform.gameObject.GetComponent<Teleport2>().TeleportPlayer();

            }
        }
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;

    }


}
