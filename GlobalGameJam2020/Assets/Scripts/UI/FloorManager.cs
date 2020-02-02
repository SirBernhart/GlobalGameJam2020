using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI floorText;
    private int floor = -1;
    // Start is called before the first frame update
    private void Start()
    {
        floorText.text = floor.ToString();
    }

    public void increaseFloor()
    {
        floor+=1;
        floorText.text = floor.ToString();
    }
}
