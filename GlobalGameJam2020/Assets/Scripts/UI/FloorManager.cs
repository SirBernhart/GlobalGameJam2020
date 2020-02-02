using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI floorText;
    [SerializeField] private ScoreSO so;
    
    // Start is called before the first frame update
    private void Start()
    {
        floorText.text = so.floor.ToString();
    }

    public void Update()
    {
        floorText.text = so.floor.ToString();
    }
}
