using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenshotButton : MonoBehaviour
{
    public Button screenshotButton; // Asigna el bot�n desde el Inspector

    private void Start()
    {
        // Aseg�rate de que el bot�n est� asignado
        if (screenshotButton != null)
        {
            screenshotButton.onClick.AddListener(TakeScreenshot);
        }
        else
        {
            Debug.LogError("El bot�n no est� asignado en el Inspector.");
        }
    }

    private void TakeScreenshot()
    {
        StartCoroutine(CaptureScreenshot());
    }

    private IEnumerator CaptureScreenshot()
    {
        // Espera un frame para asegurarte de que la captura se realice correctamente
        yield return new WaitForEndOfFrame();

        // Captura la pantalla
        ScreenCapture.CaptureScreenshot("Screenshot.png");
        Debug.Log("Captura de pantalla realizada: Screenshot.png");
    }
}
