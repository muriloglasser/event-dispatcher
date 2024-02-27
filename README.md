# EventDispatcher Project

`EventDispatcher` is a utility class designed to simplify event dispatching, registration, and unregistration for different event types. It allows for the decoupling of components and facilitates communication within a Unity project.

## Table of Contents

- [Usage](#usage)
- [Example](#example)

The main utility class responsible for managing event dispatching, registration, and unregistration.

## Usage

### Dispatching data
This example demonstrates how to dispatch data using the EventDispatcher. In this case, the data is of type DataManagerExampleStruct. Use this pattern when you want to notify other parts of your codebase that a specific event or change has occurred.
```csharp
// Example of dispatching data
EventDispatcher.Dispatch<DataManagerExampleStruct>(data);
```

### Registering data observer
This example illustrates how to register an observer to listen for events of a specific type (DataManagerExampleStruct). Observers are notified when the corresponding data is dispatched. Use this when you want certain parts of your code to react to specific events.
```csharp
// Example of registering an observer
EventDispatcher.RegisterObserver<DataManagerExampleStruct>(OnDataReceived);
```

### Unregister data observer
This example demonstrates how to unregister an observer, preventing it from receiving further events of a specific type (DataManagerExampleStruct). Use this when an observer is no longer interested in listening to particular events.
```csharp
// Example of unregistering an observer
EventDispatcher.UnregisterObserver<DataManagerExampleStruct>(OnDataReceived);
```

## Example

Note: This example is available in the Example1 scene. Be sure to check out that scene to see the code in action.

### Struct
```csharp
// Example struct to represent data.
public struct DataManagerExampleStruct
{
    public int id;
    public float distance;
    public string name;
}

```

### Dispatching
```csharp

// Dispatch data with parsed input values
Dispatch(new DataManagerExampleStruct
{
    id = int.Parse(idInputField.text),
    distance = float.Parse(distanceInputField.text),
    name = nameInputField.text
});

  
/// Dispatches data of type DataManagerExampleStruct using the EventDispatcher.   
private void Dispatch(DataManagerExampleStruct data)
{
    // Dispatch data using EventDispatcher
    EventDispatcher.Dispatch<DataManagerExampleStruct>(data); 
}
```

### Register and unregister
```csharp
/// Called when the object becomes enabled/active.  
private void OnEnable()
{
    // Register this object as an observer for events of type DataManagerExampleStruct.
    EventDispatcher.RegisterObserver<DataManagerExampleStruct>(OnDataDispatched);
}
  
/// Called when the object is disabled.   
private void OnDisable()
{
    // Unregister this object as an observer for events of type DataManagerExampleStruct.
    EventDispatcher.UnregisterObserver<DataManagerExampleStruct>(OnDataDispatched);
}

/// Called when data of type DataManagerExampleStruct is dispatched.
private void OnDataDispatched(DataManagerExampleStruct data)
{
    // Display the received data in the console.
    Debug.Log("Received data: \n" +
              "ID: " + data.id +
              ", Distance: " + data.distance +
              ", Name: " + data.name);
}
```

# Thank You

I sincerely appreciate you taking the time to explore this project. I hope you enjoyed the experience and found valuable information. If you have any questions or suggestions, feel free to share them.

