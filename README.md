# Poonnapop Sansom 683450057-7
## Class Diagram
mermaid

classDiagram
    class Program {
        +Main()
        +Main(args: string[]): void
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
    class VendingMachine {
        -coffee: int
        -water: int
        -milk: int
        -chokkolat: int

        +VendingMachine(coffee: int, water: int, milk: int, chokkolat: int)
        +Buyblackcoffee(): void
        +Buymokca(): void
        +Buylatte(): void
        +Buychokkolat(amount: int): void
        +ShowStock(): void
        +IncreaseStock(co: int, wa: int, mk: int, ckl: int, no: int): void
        +UseStock(co: int, wa: int, mk: int, ckl: int): void
        -CheckStock(co: int, wa: int, mk: int, ckl: int): bool
    }

    Program --> CoffeeMachine
    Program --> VendingMachine : creates / uses
