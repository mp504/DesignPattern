# Design Patterns in C#

This repository contains examples of various design patterns implemented in C#. The design patterns are categorized into three types: Creational, Structural, and Behavioral.

## Creational Patterns

1. **Abstract Factory**: [AbstractFactory/Program.cs](#abstractfactory\program.cs-context)
   - Example: The `Application` class uses a `GUIFactory` to create UI components (`IButton` and `ICheckBox`). This allows the application to be independent of the specific types of buttons and checkboxes it uses, enabling it to work with different UI libraries.

2. **Builder**: [Builder/HouseBuilder.cs](#file:'repos\mp504\DesignPattern\Builder\HouseBuilder.cs')
   - Example: The `HouseBuilder` class constructs a `House` object step by step. This allows for the construction of complex `House` objects with different configurations.

3. **Factory Method**: [Factory/DocumentProcessingFactory.cs](#file:'repos\mp504\DesignPattern\Fatory\DecumentProcessingFactory.cs')
   - Example: The `DocumentProcessingFactory` class defines a method for creating `Document` objects. Subclasses of `DocumentProcessingFactory` can override this method to create specific types of documents.

4. **Prototype**: [Prototype/Characters.cs](#file:'repos\mp504\DesignPattern\Prototype\Characters.cs')
   - Example: The `Attacker` and `Defender` classes implement the `Icharacter` interface, which includes a `clone` method. This allows for the creation of new `Attacker` and `Defender` objects by copying existing ones.

5. **Singleton**: [Singleton/ConfigurationManager.cs](#file:'repos\mp504\DesignPattern\Singleton\ConfigurationManager.cs')
   - Example: The `ConfigurationManager` class ensures that only one instance of the configuration manager exists. It provides a global point of access to the configuration settings.

## Structural Patterns

1. **Adapter**: [Adapter/Paypal.cs](#file:'repos\mp504\DesignPattern\Adapter\Paypal.cs')
   - Example: The `PaypalAdapter` class adapts the interface of the `Paypal` class to be compatible with the `IPaymentProcessor` interface. This allows the `Paypal` class to be used where an `IPaymentProcessor` is expected.

2. **Bridge**: [Bridge/Databases.cs](#file:'Repos\mp504\DesignPattern\Bridge\Databases.cs')
   - Example: The `Database` class uses a `DatabaseImplementation` to perform database operations. This decouples the abstraction (`Database`) from its implementation (`DatabaseImplementation`), allowing them to vary independently.

3. **Composite**: [Composite/Components.cs](#file:'repos\mp504\DesignPattern\Composite\Components.cs')
   - Example: The `Composite` class represents a group of `Component` objects. This allows clients to treat individual `Component` objects and compositions of `Component` objects uniformly.

4. **Decorator**: [Decorator/Decorator.cs](#file:'repos\mp504\DesignPattern\Decorator\Decorator.cs')
   - Example: The `Decorator` class adds additional responsibilities to a `Component` object dynamically. This provides a flexible alternative to subclassing for extending functionality.

5. **Facade**: [Facade/Facade.cs](#file:'repos\mp504\DesignPattern\Facade\Facade.cs')
   - Example: The `Facade` class provides a simplified interface to a complex subsystem. This makes the subsystem easier to use by hiding its complexity.

6. **Flyweight**: [Flyweight/FlyWeight.cs](#file:'repos\mp504\DesignPattern\FlyWeight\FlyWeight.cs')
   - Example: The `Flyweight` class uses sharing to support large numbers of fine-grained objects efficiently. This reduces memory usage by sharing common state among multiple objects.

7. **Proxy**: [Proxy/proxy.cs](#file:'repos\mp504\DesignPattern\Proxy\proxy.cs')
   - Example: The `CachingProxy` class provides a surrogate for the `ExpensiveComputation` class. It caches the results of expensive computations to avoid redundant calculations.

## Behavioral Patterns

1. **Chain of Responsibility**: [ChainOfResponsibility/ChainOfResponsibility.cs](#file:'repos\mp504\DesignPattern\ChainOfresponsibility\ChainOfResponsibility.cs')
   - Example: The `ChainOfResponsibility` class passes a request along a chain of handlers. Each handler can either handle the request or pass it to the next handler in the chain.

2. **Command**: [Command/Command.cs](#file:'repos\mp504\DesignPattern\Command\Command.cs')
   - Example: The `Command` class encapsulates a request as an object. This allows for parameterization of clients with queues, requests, and operations.

3. **Iterator**: [Iterator/Iterator.cs](#file:'repos\mp504\DesignPattern\Iterator\Iterator.cs')
   - Example: The `Iterator` class provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

4. **Mediator**: [Mediator/Mediator.cs](#file:'repos\mp504\DesignPattern\Mediator\Mediator.cs')
   - Example: The `Mediator` class defines an object that encapsulates how a set of objects interact. This promotes loose coupling by keeping objects from referring to each other explicitly.

5. **Memento**: [Memento/Memento.cs](#file:'repos\mp504\DesignPattern\Memento\Memento.cs')
   - Example: The `Memento` class captures and externalizes an object's internal state without violating encapsulation. This allows the object to be restored to this state later.

6. **Observer**: [Observer/observer.cs](#file:'repos\mp504\DesignPattern\Observer\observer.cs')
   - Example: The `Observer` class defines a one-to-many dependency between objects. When one object changes state, all its dependents are notified and updated automatically.

7. **State**: [State/State.cs](#file:'repos\mp504\DesignPattern\State\State.cs')
   - Example: The `State` class allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

8. **Strategy**: [Strategy/Strategy.cs](#file:'repos\mp504\DesignPattern\Strategy\Strategy.cs')
   - Example: The `Strategy` class defines a family of algorithms, encapsulates each one, and makes them interchangeable. This allows the algorithm to vary independently from clients that use it.

9. **Template Method**: [Template/Template.cs](#file:'repos\mp504\DesignPattern\Template\Template.cs')
   - Example: The `TemplateMethod` class defines the skeleton of an algorithm in an operation. Subclasses can redefine certain steps of the algorithm without changing its structure.

10. **Visitor**: [Visitor/Visitor.cs](#file:'repos\mp504\DesignPattern\Visitor\Visitor.cs')
    - Example: The `Visitor` class represents an operation to be performed on the elements of an object structure. This allows you to define a new operation without changing the classes of the elements on which it operates.

## How to Run

1. Clone the repository:
    
    
