using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpotManager : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Cantina;
    public GameObject Cube;
    public GameObject Mezzanine;

    public void LivingRoomClick()
    {
        LivingRoom.SetActive(true);
        Cantina.SetActive(false);
        Mezzanine.SetActive(false);
        Cube.SetActive(false);
    }
    public void CantinaClick()
    {
        LivingRoom.SetActive(false);
        Cantina.SetActive(true);
        Mezzanine.SetActive(false);
        Cube.SetActive(false);
    }
    public void CubeClick()
    {
        LivingRoom.SetActive(false);
        Cantina.SetActive(false);
        Mezzanine.SetActive(false);
        Cube.SetActive(true);
    }
    public void MezzanineClick()
    {
        LivingRoom.SetActive(false);
        Cantina.SetActive(false);
        Mezzanine.SetActive(true);
        Cube.SetActive(false);
    }
}
