
# Implement a notification system

Notification system supports Email & SMS
and the Following design patterns are used in the solution:
1.	Factory
2.	Singleton
3.	Adapter
4.	Façade
5.	Strategy
6.	Observer / PubSub




## Run Locally

Clone the project

```bash
  git clone https://github.com/amityv0113/design-patterns.git
```

Go to the project directory

```bash
  cd NotificationSystem
```


Run application

```bash
  dotnet run
```


## Description of classes

#### Factory Pattern:

The NotificationFactory class creates instances of notification channels.
It encapsulates the creation logic and allows for easy extension by adding new channel types.


#### Singleton Pattern:

The NotificationManager class ensures that only one instance of itself is created.
The Instance property provides global access to that instance.

#### Adapter Pattern:

The NotificationAdapter class adapts the complex NotificationSystem to a simplified interface for sending notifications.
It acts as a bridge between the client and the underlying system

#### Facade Pattern:

The NotificationFacade class simplified the interface for sending notifications.Encapsulates the process of setting the notification strategy and notifying subscribers

#### Strategy Pattern:

The INotificationStrategy interface defines a strategy for sending notifications.
The EmailNotificationStrategy and SMSNotificationStrategy classes implement different strategies

#### Observer Pattern:

The NotificationPublisher class maintains a list of subscribers and notifies them using a chosen strategy.
Subscribers can subscribe to the service and receive notifications




## Assumption taken

focus is on showing how patterns can be applied to build a flexible notification system without the actual implementation of email or SMS sending logic

The Observer pattern implementation in the solution is simplified. a more robust event-handling mechanism might be used in a real-world scenario

## Screenshots

![App Screenshot](https://github.com/amityv0113/design-patterns/assets/41436957/cbd56b7d-56fd-4e6c-b352-1898c2c4d1b4)


## Tech Stack

**C#** 
