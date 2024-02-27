# EventDispatcher Project

`EventDispatcher` is a utility class designed to simplify event dispatching, registration, and unregistration for different event types. It allows for the decoupling of components and facilitates communication within a Unity project.

## Table of Contents

- [Usage](#usage)
- [Example](#example)

The main utility class responsible for managing event dispatching, registration, and unregistration.

## Usage

### Dispatching data
```csharp
// Example of dispatching data
EventDispatcher.Dispatch<DataManagerExampleStruct>(data);
```

### Registering data observer
```csharp
// Example of registering an observer
EventDispatcher.RegisterObserver<DataManagerExampleStruct>(OnDataReceived);
```


### Unregister data observer
```csharp
// Example of unregistering an observer
EventDispatcher.UnregisterObserver<DataManagerExampleStruct>(OnDataReceived);
```
