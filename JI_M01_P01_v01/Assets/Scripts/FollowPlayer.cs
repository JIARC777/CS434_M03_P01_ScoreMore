using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Grab a reference to the player's position
    public Transform playerTransform;
    // offset parameter for camera - set in inspector
    public Vector3 offset;
    Camera camera;

    private void Start()
    {
        camera = this.GetComponent<Camera>();
        Score.OnMilestone += changeBackground;
    }

    public void changeBackground()
    {
        camera.backgroundColor = Random.ColorHSV();
    }
    // Update is called once per frame
    void Update()
    {
        // snap camera position to offset of player's position
        transform.position = playerTransform.position + offset;
    }
}
