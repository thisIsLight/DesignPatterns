namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Composite pattern makes sure that if you ahve a particular class which contains types of its own
            //You should be able to do whatever you could with collection of the types as well

            //Create a component
            var cpu = new LeafComponent("CPU", 2000);
            var gpu = new LeafComponent("GPU", 5000);
            var ram = new LeafComponent("RAM", 5000);

            var mouse = new LeafComponent("Mouse", 500);
            var keyboard = new LeafComponent("Keyboard", 1000);

            var motherboard = new CompositeComponent("MotherBoard");
            motherboard.AddComponents(cpu);
            motherboard.AddComponents(gpu);
            motherboard.AddComponents(ram);

            var iodevice = new CompositeComponent("IODeivces");
            iodevice.AddComponents(mouse);
            iodevice.AddComponents(keyboard);

            var computer = new CompositeComponent("Computer");
            computer.AddComponents(motherboard);
            computer.AddComponents(iodevice);

            //Printing leaf node
            cpu.ShowPrice();
            gpu.ShowPrice();
            ram.ShowPrice();

            //Printing Composite objects
            motherboard.ShowPrice();
            iodevice.ShowPrice();

            //Printing Super Components
            computer.ShowPrice();
        }
    }
}