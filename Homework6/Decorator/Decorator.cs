using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ChristmasTree and two Decorators
            ConcreteChristmasTree c = new ConcreteChristmasTree();
            Tree1 d1 = new Tree1();
            Tree2 d2 = new Tree2();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Decorate();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class ChristmasTree
    {
        public bool decorations = false;
        public abstract void Decorate();
    }

    // "ChristmasTree"
    class ConcreteChristmasTree : ChristmasTree
    {
        public override void Decorate()
        {
            Console.WriteLine("ChristmasTree.Decorate(), decorations is enabled");
            decorations=true;
        }
    }
    // "Decorator"
    abstract class ChristmasTreeDecorator : ChristmasTree
    {
        protected ChristmasTree christmasTree;

        public void SetComponent(ChristmasTree christmasTree)
        {
            this.christmasTree = christmasTree;
        }
        public override void Decorate()
        {
            if (christmasTree != null)
            {
                christmasTree.Decorate();
            }
        }
    }

    // "Tree1"
    class Tree1 : ChristmasTreeDecorator
    {
        private string addedState;

        public override void Decorate()
        {
            base.Decorate();
            addedState = "New State";
            decorations=true;
            Console.WriteLine("Tree1.Decorate(), decorations is enabled");
        }
    }

    // "Tree2" 
    class Tree2 : ChristmasTreeDecorator
    {
        public override void Decorate()
        {
            base.Decorate();
            AddedBehavior();
            decorations=true;
            Console.WriteLine("Tree2.Decorate(), decorations is enabled");
        }
        void AddedBehavior()
        { }
    }
}
