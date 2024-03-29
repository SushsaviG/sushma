# DEPENDENCY INJECTION IN ASP.NET MVC
 -  Dependency Injection is an implementation of "Inversion of Control". Inversion of Control (IoC) says that the objects do <br>
  not create other objects on which  they rely to do their work; instead, they get the objects that they need from an outside source.

- Technically, Dependency Injection or DI is defined as a software design pattern which implements Inversion of control (IOC) for 
resolving dependencies across objects. <br>
The dependency is an object (or a service object), which is passed as dependency to the consumer object (or a client application). <br>
This is a pattern using which decoupling (or loose-coupling) across components can be implemented easily.



### The advantages of using Dependency Injection pattern and Inversion of Control are the following:

- Reduces class coupling
- Increases code reusing
- Improves code maintainability
- Improves application testing


### Types of Dependency Injection
 the injector class injects the service (dependency) to the client (dependent). <br>
 The injector class injects dependencies broadly in three ways: through a constructor, through a property, or through a method.

1) Constructor Injection: In the constructor injection, the injector supplies the service (dependency) through the client class constructor.

2) Property Injection: In the property injection, the injector supplies the dependency through a public property of the client class.

3) Method Injection: In this type of injection, the client class implements an interface which declares the methods to supply the dependency and <br>
  the injector uses this interface to supply the dependency to the client class.
