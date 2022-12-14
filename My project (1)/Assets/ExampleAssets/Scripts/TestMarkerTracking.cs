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

    public static ARTrackedImageManager myManager;

    public static string imageName;
    

    void OnEnable()
    {
        myManager = GetComponent<ARTrackedImageManager>();
        myManager.trackedImagesChanged += changeDetected;

    }

    private void OnDisable()
    {
        myManager.trackedImagesChanged -= changeDetected;
    }

    public void changeDetected(ARTrackedImagesChangedEventArgs eventArguments)
    {
        //i detected the marker
        foreach (var detectedImage in eventArguments.added)
        {

            imageName = detectedImage.name;

            foreach (var scenePrefab in AR_Prefabs)
            {
                string prefabName = scenePrefab.name;

                if (string.Compare(imageName, prefabName, System.StringComparison.Ordinal) == 0
                    && !instantiatedPrefabs.ContainsKey(imageName))
                {
                    var createdPref = Instantiate(scenePrefab, detectedImage.transform);

                    instantiatedPrefabs[prefabName] = createdPref;
                }
            }
        }
            //the marker changed
        foreach (var detectedImage in eventArguments.updated)
        {
            instantiatedPrefabs[detectedImage.referenceImage.name].SetActive(detectedImage.trackingState == TrackingState.Tracking);
        }

            //the marker is gone
        foreach (var detectedImage in eventArguments.removed)
        {
            Destroy(instantiatedPrefabs[detectedImage.referenceImage.name]);

            instantiatedPrefabs.Remove(detectedImage.referenceImage.name);
        }

        

        // Update is called once per frame
        void Update()
        {

        }
    }
}

