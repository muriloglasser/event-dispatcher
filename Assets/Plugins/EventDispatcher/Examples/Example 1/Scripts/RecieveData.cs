using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// A class responsible for receiving and processing data of type DataManagerExampleStruct dispatched by the EventDispatcher.
/// </summary>
public class RecieveData : MonoBehaviour
{
    /// <summary>
    /// Called when the object becomes enabled/active.
    /// </summary>
    private void OnEnable()
    {
        // Register this object as an observer for events of type DataManagerExampleStruct.
        EventDispatcher.RegisterObserver<DataManagerExampleStruct>(OnDataDispatched);
    }

    /// <summary>
    /// Called when the object is disabled.
    /// </summary>
    private void OnDisable()
    {
        // Unregister this object as an observer for events of type DataManagerExampleStruct.
        EventDispatcher.UnregisterObserver<DataManagerExampleStruct>(OnDataDispatched);
    }

    /// <summary>
    /// Called when the object is started.
    /// </summary>
    private void Start()
    {
        // Load the "DispatchData" scene if it is not loaded yet.
        if (!SceneManager.GetSceneByName("DispatchData").isLoaded)
            SceneManager.LoadScene("DispatchData", LoadSceneMode.Additive);
    }

    /// <summary>
    /// Called when data of type DataManagerExampleStruct is dispatched.
    /// </summary>
    /// <param name="data">The received data of type DataManagerExampleStruct.</param>
    private void OnDataDispatched(DataManagerExampleStruct data)
    {
        // Display the received data in the console.
        Debug.Log("Received data: \n" +
                  "ID: " + data.id +
                  ", Distance: " + data.distance +
                  ", Name: " + data.name);
    }
}
