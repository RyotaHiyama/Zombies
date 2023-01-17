using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraZoomtest : MonoBehaviour
{
    public void ZoomCamera(Camera camera, float zoom, float duration)
    {
        float defaultFov = camera.fieldOfView;
        DOTween.To(() => camera.fieldOfView, fov => camera.fieldOfView = fov, defaultFov / zoom, duration);
    }
}
