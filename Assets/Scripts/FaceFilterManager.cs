using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class FaceFilterManager : MonoBehaviour
{
    [SerializeField] private GameObject topModel;
    [SerializeField] private GameObject middleModel;
    [SerializeField] private GameObject bottomModel;

    [SerializeField] private List<Material> materials;
    [SerializeField] private List<GameObject> topModels;
    [SerializeField] private List<GameObject> middleModels;
    [SerializeField] private List<GameObject> bottomModels;

    private GameObject actualTopModel;
    private GameObject actualMiddleModel;
    private GameObject actualBottomModel;

    int topModelIndex = 0;
    int middleModelIndex = 0;
    int bottomModelIndex = 0;

    int topMaterialIndex = 0;
    int middleMaterialIndex = 0;
    int bottomMaterialIndex = 0;

    public void ChangeTopModel()
    {
        //Si te fill, el mata
        if (topModel.transform.childCount > 0)
            Destroy(topModel.transform.GetChild(0).gameObject);

        //Spawnea fill
        actualTopModel = Instantiate(topModels[topModelIndex]);
        actualTopModel.transform.SetParent(topModel.transform);

        //canviar material
        if (actualTopModel.GetComponent<Renderer>() != null)
            actualTopModel.GetComponent<Renderer>().material = materials[topMaterialIndex];

        //inc compt si no arriba al final de la llista, sino 0
        if (topModelIndex < topModels.Count - 1)
        {
            topModelIndex++;
        }
        else
        {
            topModelIndex = 0;
        }
    }

    public void ChangeMiddleModel()
    {
        //Si te fill, el mata
        if (middleModel.transform.childCount > 0)
            Destroy(middleModel.transform.GetChild(0).gameObject);

        //Spawnea fill
        actualMiddleModel = Instantiate(middleModels[middleModelIndex]);
        actualMiddleModel.transform.SetParent(middleModel.transform);

        //canviar material
        if (actualMiddleModel.GetComponent<Renderer>() != null)
            actualMiddleModel.GetComponent<Renderer>().material = materials[middleMaterialIndex];

        //inc compt si no arriba al final de la llista, sino 0
        if (middleModelIndex < middleModels.Count - 1)
        {
            middleModelIndex++;
        }
        else
        {
            middleModelIndex = 0;
        }
    }

    public void ChangeBottomModel()
    {
        //Si te fill, el mata
        if (bottomModel.transform.childCount > 0)
            Destroy(bottomModel.transform.GetChild(0).gameObject);

        //Spawnea fill
        actualBottomModel = Instantiate(bottomModels[bottomModelIndex]);
        actualBottomModel.transform.SetParent(bottomModel.transform);

        //canviar material
        if (actualBottomModel.GetComponent<Renderer>() != null)
            actualBottomModel.GetComponent<Renderer>().material = materials[bottomMaterialIndex];

        //inc compt si no arriba al final de la llista, sino 0
        if (bottomModelIndex < bottomModels.Count - 1)
        {
            bottomModelIndex++;
        }
        else
        {
            bottomModelIndex = 0;
        }
    }


    public void ChangeTopMaterial()
    {
        //inc compt si no arriba al final de la llista, sino 0
        if (topMaterialIndex < materials.Count - 1)
        {
            topMaterialIndex++;
        }
        else
        {
            topMaterialIndex = 0;
        }

        if (actualTopModel.GetComponent<Renderer>() != null)
            actualTopModel.GetComponent<Renderer>().material = materials[topMaterialIndex];
    }

    public void ChangeMiddleMaterial()
    {
        //inc compt si no arriba al final de la llista, sino 0
        if (middleMaterialIndex < materials.Count - 1)
        {
            middleMaterialIndex++;
        }
        else
        {
            middleMaterialIndex = 0;
        }
        if (actualMiddleModel.transform.childCount > 0)
        {
            actualMiddleModel.transform.GetChild(0).GetComponent<Renderer>().material = materials[middleMaterialIndex];
            actualMiddleModel.transform.GetChild(1).GetComponent<Renderer>().material = materials[middleMaterialIndex];
        }
    }

    public void ChangeBottomMaterial()
    {
        //inc compt si no arriba al final de la llista, sino 0
        if (bottomMaterialIndex < materials.Count - 1)
        {
            bottomMaterialIndex++;
        }
        else
        {
            bottomMaterialIndex = 0;
        }

        actualBottomModel.GetComponent<Renderer>().material = materials[bottomMaterialIndex];
    }
}