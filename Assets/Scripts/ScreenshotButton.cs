using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenshotButton : MonoBehaviour
{
    public Button screenshotButton; // Asigna el botón desde el Inspector

    private void Start()
    {
        // Asegúrate de que el botón esté asignado
        if (screenshotButton != null)
        {
            screenshotButton.onClick.AddListener(TakeScreenshot);
        }
        else
        {
            Debug.LogError("El botón no está asignado en el Inspector.");
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
