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
