using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsRegurator : MonoBehaviour
{

    private GameObject pointsText;
    private int points = 0;
    private int plaspoints = 0;
    private int touch = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.pointsText = GameObject.Find("PointsText");
        this.pointsText.GetComponent<Text>().text = "Points:0";
    }

    // Update is called once per frame
    void Update()
    {
        if(this.touch > 0)
        {
            if (tag == "SmallStarTag")
            {
                this.plaspoints = 10;
            }
            else if (tag == "LargeStarTag")
            {
                this.plaspoints = 20;
            }
            else if (tag == "SmallCloudTag")
            {
                this.plaspoints = 30;
            }
            else if (tag == "LargeCloudTag")
            {
                this.plaspoints = 50;
            }
            Debug.Log("kakutoku"+ plaspoints);
            this.points += this.plaspoints;
            Debug.Log("goukei"+ points);
            this.pointsText.GetComponent<Text>().text = "Points:" + this.points;
            this.touch = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    { 
        this.touch = 100;
        
    }
}
