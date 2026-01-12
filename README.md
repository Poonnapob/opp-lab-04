# opp-lab-04
classDiagram
    class Program {
        <<Main Class>>
        +Main(string[] args)$ void
        -DisplayMenu()$ void
        -ProcessUserInput(VendingMachine vm)$ void
    }
    
    class VendingMachine {
        <<Business Logic>>
        -int coffee
        -int water
        -int milk
        -int chokkolat
        +VendingMachine(int coffee, int water, int milk, int chokkolat)
        +Buyblackcoffee() void
        +Buymokca() void
        +Buylatte() void
        +Buychokkolat(int amount) void
        +ShowStock() void
        +IncreaseStock(int co, int wa, int mk, int ckl, int no) void
        +UseStock(int co, int wa, int mk, int ckl) void
        -CheckStock(int co, int wa, int mk, int ckl) bool
    }
    
    class BlackCoffee {
        <<Recipe>>
        +int CoffeeAmount = 20
        +int WaterAmount = 300
        +int MilkAmount = 0
        +int ChokkolatAmount = 0
        +string Name = "Black Coffee"
    }
    
    class Mokca {
        <<Recipe>>
        +int CoffeeAmount = 20
        +int WaterAmount = 300
        +int MilkAmount = 0
        +int ChokkolatAmount = 10
        +string Name = "Mokca"
    }
    
    class Latte {
        <<Recipe>>
        +int CoffeeAmount = 20
        +int WaterAmount = 300
        +int MilkAmount = 10
        +int ChokkolatAmount = 0
        +string Name = "Latte"
    }
    
    class Chokkolat {
        <<Recipe>>
        +int CoffeeAmount = 0
        +int WaterAmount = 300
        +int MilkAmount = 0
        +int ChokkolatAmount = 20
        +string Name = "Chokkolat"
    }
    
    class Ingredient {
        <<Data>>
        +string Name
        +int Quantity
        +string Unit
        +CheckAvailability(int required) bool
        +Consume(int amount) void
        +Refill(int amount) void
    }
    
    Program --> VendingMachine : creates and uses
    VendingMachine ..> BlackCoffee : uses recipe
    VendingMachine ..> Mokca : uses recipe
    VendingMachine ..> Latte : uses recipe
    VendingMachine ..> Chokkolat : uses recipe
    VendingMachine "1" *-- "4" Ingredient : contains
    
    note for Program "Entry point of application\nHandles user interface\nManages main loop"
    note for VendingMachine "Core business logic\nManages inventory\nProcesses purchases"
    note for Ingredient "Represents raw materials:\n- Coffee (g)\n- Water (ml)\n- Milk (ml)\n- Chokkolat (g)"
