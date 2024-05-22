using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectCameraTransformer : MonoBehaviour
{
    public new Camera camera;
    public float duration;
    float startY;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CameraTransformer>() is CameraTransformer cameraTransformer)
        {
            StartCoroutine(Move(cameraTransformer.y));
        }
    }

    IEnumerator Move(float y)
    {
        float elapsedTime = 0f;

        var cameras = camera.GetComponent<Test_CameraController>();
        startY = cameras.y;

        while (elapsedTime < duration)
        {
            cameras.y = Mathf.Lerp(startY, y, elapsedTime / duration);
            
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
