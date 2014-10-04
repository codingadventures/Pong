using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour
{

    public Camera mainCam;
    public BoxCollider2D topWall, bottomWall, leftWall, rightWall;

    public Transform Player01, Player02;


    // Update is called once per frame
    void Update()
    {

        //Move each wall to its edge location
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        topWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

        leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0, 0f, 0f)).x - 0.5f, 0f);

        var vec = Player01.position;
        vec.x = mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x;
        Player01.position = vec;
        var vec2 = Player02.position;
        vec2.x = mainCam.ScreenToWorldPoint(new Vector3(-75f, 0f, 0f)).x;
        Player02.position = vec2;


        Player01.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, Player01.position.y, 0f);
        Player02.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x, Player02.position.y, 0f);


    }
}
