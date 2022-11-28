using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TestMarkerTracking : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] AR_Prefabs;

    private readonly Dictionary<string, GameObject> instantiatedPrefabs = new Dictionary<string, GameObject>();

    private ARTrackedImageManager myManager;


    
    void OnEnable()
    {
     myManager = GetComponent<ARTrackedImageManager>();
     myManager.trackedImagesChanged += changeDetected;

    }

    private void OnDisable()
    {
        myManager.trackedImagesChanged -= changeDetected;
    }

    privte void changeDetected(ARTrackedImagesChangedEventArgs eventArguments)
    {
        //i detected the marker
        foreach (var detectedImage in eventArguments.added)
             
            string imageName = detectedImage.name;

            foreach (var scenePrefab in AR_Prefabs)
            {
                string prefabName = scenePrefab.name;

                if(string.Compare(imageName, prefabName, System.StringComparison.Ordinal) == 0 
                    && !instanciatedPrefabs.ContainsKey(imageName))
                    {
                        var createdPref = Instantiate(scenePrefab, detectedImage.transform);

                        instanciatedPrefabs[prefabName] = createdPref;
                    }
            }
        //the marker changed
        foreach (var detectedImage in eventArguments.updated)
        {
            instanciatedPrefabs[detectedImage.referenceImage.name].SetActive(detectedImage.trackingState == trackingState.Tracking);
        }

        //the marker is gone
        foreach (var detectedImage in eventArguments.removed)
        {
            Destroy(instantiatedPrefabs[detectedImage.referenceImage.name]);

            instanciatedPrefabs.Remove(detectedImage.referenceImage.name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}