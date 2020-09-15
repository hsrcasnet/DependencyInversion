# DependencyInversion
Sample app which demonstrates the dependency inversion principle + dependency injection techniques using Autofac as DI Framework.

#### Example 1
Shows a tightly-coupled implementation of a Switch and a Lamp. Whenever Switch is used, we need to deliver an instance of Lamp. Switch cannot be tested in isolation.

<img src="https://github.com/hsrcasnet/DependencyInversion/blob/master/Img/Example1.png?raw=true" alt="Example 1" height="300"/>

#### Example 2
Switch and Lamp are abstracted by ISwitch and ISwitchable. The application resolves the ISwitch dependency using a dependency injection container. Switch can now be tested in isolation because it no longer depends on an implementation but on the abstraction ISwitchable.

<img src="https://github.com/hsrcasnet/DependencyInversion/blob/master/Img/Example2.png?raw=true" alt="Example 2" height="300"/>


