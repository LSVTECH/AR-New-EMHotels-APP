using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using UnityEngine;

public class HotelManager : MonoBehaviour
{
    public string selectedHotel;
    public ObjectSpawner m_ObjectSpawner;
    public GameObject m_ObjectsMenuToHide;
    private Dictionary<string, List<GameObject>> allObjects;

    void Start()
    {
        allObjects = new Dictionary<string, List<GameObject>>() {
            { "CartagenaPlaza", m_ObjectSpawner.objectCartagenaPlaza },
            { "AndezPlaza", m_ObjectSpawner.objectAndezPlaza },
        };
    }

    public void ChangeHotelObjects()
    {
        m_ObjectSpawner.objectPrefabs = allObjects[selectedHotel];
        m_ObjectsMenuToHide.SetActive(false);
    }
}
