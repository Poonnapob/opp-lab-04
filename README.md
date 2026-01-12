# Poonnapop Sansom 683450057-7
classDiagram
    class Program {
        +Main(args: string[]): void
    }

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

    Program --> VendingMachine : creates / uses
