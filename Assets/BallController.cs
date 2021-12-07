using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblePosZ = -6.5f;

    private int points = 0;

    private GameObject pointsText;
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointsText = GameObject.Find("PointsText");
        this.pointsText.GetComponent<Text>().text = "Points:0";
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {

            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        int plaspoints = 0;

        if (collision.gameObject.tag == "SmallStarTag")
        {
            plaspoints = 10;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            plaspoints = 20;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            plaspoints = 30;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            plaspoints = 50;
        }
        Debug.Log("kakutoku" + plaspoints);
        this.points += plaspoints;
        Debug.Log("goukei" + points);
        this.pointsText.GetComponent<Text>().text = "Points:" + this.points;

    }
}
