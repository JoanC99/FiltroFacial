using System.Collections.Generic;
using UnityEngine;

public class GlassesChangerBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject glassesGroupPrefab; // Prefab de las gafas a asignar en el editor

    // Este m�todo muestra las gafas seg�n el �ndice que se pasa
    public void DisplayGlasses(int glassesIndex)
    {
        glassesGroupPrefab.transform.GetChild(glassesIndex).GetComponent<MeshRenderer>().enabled = true;

        Debug.Log("Enabling " + glassesGroupPrefab.transform.GetChild(glassesIndex).name);

        // Desactivamos las dem�s gafas
        for (int i = 0; i < glassesGroupPrefab.transform.childCount; i++)
        {
            if (i != glassesIndex)
            {
                Debug.Log("Enabling " + glassesGroupPrefab.transform.GetChild(i).name);
                glassesGroupPrefab.transform.GetChild(i).GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
