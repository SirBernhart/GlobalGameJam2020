using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.
    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration = 0f;
    private float currentTime = 0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    private bool doShake = false;
    public void Shake()
    {
        originalPos = camTransform.localPosition;
        doShake = true;
        currentTime = shakeDuration;
    }

    void Update()
    {
        if (doShake)
        {
            if (currentTime > 0)
            {
                camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

                currentTime -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                currentTime = 0f;
                camTransform.localPosition = originalPos;
                doShake = false;
            }
        }
    }
}