using System;

// Lớp gốc của nhân vật (prototype)
public abstract class CharacterPrototype : ICloneable
{
    public string Name { get; set; }
    public abstract void Display();

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

// Lớp nhân vật cụ thể
public class ConcretePrototypeWarrior : CharacterPrototype
{
    public ConcretePrototypeWarrior()
    {
        Name = "Warrior";
    }

    public override void Display()
    {
        Console.WriteLine("This is a Warrior.");
    }
}

public class ConcretePrototypeMage : CharacterPrototype
{
    public ConcretePrototypeMage()
    {
        Name = "Mage";
    }

    public override void Display()
    {
        Console.WriteLine("This is a Mage.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Tạo nhân vật gốc
        CharacterPrototype warriorPrototype = new ConcretePrototypeWarrior();
        CharacterPrototype magePrototype = new ConcretePrototypeMage();

        // Sao chép nhân vật từ mẫu gốc
        CharacterPrototype warrior1 = (CharacterPrototype)warriorPrototype.Clone();
        CharacterPrototype warrior2 = (CharacterPrototype)warriorPrototype.Clone();
        CharacterPrototype mage1 = (CharacterPrototype)magePrototype.Clone();
        CharacterPrototype mage2 = (CharacterPrototype)magePrototype.Clone();

        // Hiển thị thông tin nhân vật
        warrior1.Display();
        warrior2.Display(); 
        mage1.Display();    
        mage2.Display();    

        Console.ReadLine();
    }
}