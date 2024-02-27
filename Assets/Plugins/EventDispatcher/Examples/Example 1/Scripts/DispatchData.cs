using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// A class responsible for dispatching data of type DataManagerExampleStruct and handling user input for the data to be dispatched.
/// </summary>
public class DispatchData : MonoBehaviour
{
    // UI elements for user input
    public TMP_InputField idInputField;
    public TMP_InputField distanceInputField;
    public TMP_InputField nameInputField;
    public Button dispatchDataButton;

    /// <summary>
    /// Called when the object is started.
    /// </summary>
    private void Start()
    {
        // Load the "RecieveData" scene if it is not loaded yet
        if (!SceneManager.GetSceneByName("RecieveData").isLoaded)
            SceneManager.LoadScene("RecieveData", LoadSceneMode.Additive);

        // Add a listener to the dispatchDataButton's click event
        dispatchDataButton.onClick.AddListener(() =>
        {
            CheckDataToDispatch();
        });
    }

    /// <summary>
    /// Checks user input and dispatches data if input is valid.
    /// </summary>
    private void CheckDataToDispatch()
    {
        // Check if ID input can be parsed to an integer
        if (!int.TryParse(idInputField.text, out int resultInt))
        {
            Debug.Log("ID is not an integer!");
            return;
        }

        // Check if Distance input can be parsed to a float
        if (!float.TryParse(distanceInputField.text, out float resultFloat))
        {
            Debug.Log("Distance is not a float!");
            return;
        }

        // Dispatch data with parsed input values
        Dispatch(new DataManagerExampleStruct
        {
            id = int.Parse(idInputField.text),
            distance = float.Parse(distanceInputField.text),
            name = nameInputField.text
        });
    }

    /// <summary>
    /// Dispatches data of type DataManagerExampleStruct using the EventDispatcher.
    /// </summary>
    /// <param name="data">The data to be dispatched.</param>
    private void Dispatch(DataManagerExampleStruct data)
    {
        // Dispatch data using EventDispatcher
        EventDispatcher.Dispatch<DataManagerExampleStruct>(data);

        // Log the dispatched data in the console
        Debug.Log("Data dispatched: \n" +
                  "ID: " + data.id +
                  ", Distance: " + data.distance +
                  ", Name: " + data.name);
    }
}
