﻿using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
 
namespace PrototypeFigure 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.OutputEncoding = Encoding.UTF8; 
 
            IFigure figure = new Triangle(10, 20, 30); 
            IFigure clonedFigure = figure.Clone(); 
            figure.GetInfo(); 
            clonedFigure.GetInfo(); 
            figure = new Circle(15); 
            clonedFigure = figure.Clone(); 
            figure.GetInfo(); 
            clonedFigure.GetInfo(); 
 
            Console.Read(); 
        } 
    } 
 
    interface IFigure 
    { 
        IFigure Clone(); 
        void GetInfo(); 
        } 
    class Rectangle : IFigure 
    { 
        int width; 
        int height; 
        public Rectangle(int w, int h) 
        { 
            width = w; 
            height = h; 
        } 
        public IFigure Clone() 
        { 
            return new Rectangle(this.width, this.height); 
        } 
        public void GetInfo() 
        { 
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width); 
        } 
    } 
    class Circle : IFigure 
    { 
        int radius; 
        public Circle(int r) 
        { 
            radius = r; 
        } 
        public IFigure Clone() 
        { 
            return new Circle(this.radius); 
        } 
        public void GetInfo() 
        { 
            Console.WriteLine("Круг радіусом {0}", radius); 
        } 
    } 
    class Triangle : IFigure 
    { 
        int a,b,c;
        public Triangle(int a, int b, int c) 
        { 
            this.a=a;
            this.b=b;
            this.c=c;
        } 
        public IFigure Clone() 
        { 
            return new Triangle(this.a, this.b, this.c); 
        } 
        public void GetInfo() 
        { 
            Console.WriteLine("Трикутник зі сторонами {0},{1},{2}", a, b, c); 
        } 
    } 
} 
