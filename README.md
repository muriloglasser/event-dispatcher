# EventDispatcher Project

`EventDispatcher` is a utility class designed to simplify event dispatching, registration, and unregistration for different event types. It allows for the decoupling of components and facilitates communication within a Unity project.

## Classes

### 1. EventDispatcher

The main utility class responsible for managing event dispatching, registration, and unregistration.

#### Usage

```csharp
// Example of dispatching data
EventDispatcher.Dispatch<DataManagerExampleStruct>(data);

// Example of registering an observer
EventDispatcher.RegisterObserver<DataManagerExampleStruct>(OnDataReceived);

// Example of unregistering an observer
EventDispatcher.UnregisterObserver<DataManagerExampleStruct>(OnDataReceived);
