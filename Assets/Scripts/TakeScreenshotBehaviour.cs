using System;
using System.Collections;
using System.IO;
using UnityEngine;

public class TakeScreenshotBehaviour : MonoBehaviour
{
    public void TakePhoto()
    {
        TakeScreenshot();
    }

    // M�todo para tomar la captura de pantalla
    public void TakeScreenshot()
    {
        // Ruta de la ra�z del almacenamiento interno
        string rootPath = Application.persistentDataPath;

        // Tomar la captura de pantalla y guardarla en la ruta especificada
        ScreenCapture.CaptureScreenshot(rootPath);

    }
}
