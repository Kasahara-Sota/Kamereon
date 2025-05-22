using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Transform HeartIconsParent;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        
    }
    public void DegreeHeartUI()
    {
        Destroy(HeartIconsParent.GetChild(HeartIconsParent.childCount - 1).gameObject);
    }
}

