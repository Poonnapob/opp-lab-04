# Poonnapop Sansom 683450057-7
## Class Diagram
mermaid

classDiagram
    class Program {
        +Main()
    }

    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +CoffeeMachine()
        +MakeBlackCoffee()
        +MakeMocha()
        +MakeLatte()
        +MakeChocolate()
        +ShowStock()
    }

    Program --> CoffeeMachine
