# 📐 HeritageWorkshop — Geometric Figures in C#

> A structured C# .NET 10.0 solution demonstrating **object-oriented programming** through inheritance, abstraction, and polymorphism using geometric figures.

---

## 🗂️ Project Structure

```
HeritageWorkshop/
├── HeritageWorkshop.Backend/     # Domain logic — figures & calculations
│   ├── GeometricFigure.cs        # Abstract base class
│   ├── Circle.cs
│   ├── Square.cs
│   ├── Rhombus.cs
│   ├── Kite.cs
│   ├── Rectangle.cs
│   ├── Parallelogram.cs
│   ├── Triangle.cs
│   └── Trapeze.cs
└── HeritageWorkshop.Frontend/    # Console output & entry point
    └── Program.cs
```

---

## 🧱 Class Hierarchy

```
GeometricFigure  (abstract)
├── Circle
└── Square
    ├── Rhombus
    │   └── Kite
    └── Rectangle
        ├── Parallelogram
        └── Triangle
            └── Trapeze
```

---

## 📐 Supported Figures & Formulas

| Figure | Area | Perimeter |
|---|---|---|
| **Circle** | `π · R²` | `2 · π · R` |
| **Square** | `A²` | `4A` |
| **Rhombus** | `(D1 · D2) / 2` | `4A` |
| **Kite** | `(D1 · D2) / 2` | `2(A + B)` |
| **Rectangle** | `A · B` | `2(A + B)` |
| **Parallelogram** | `B · H` | `2(A + B)` |
| **Triangle** | `(B · H) / 2` | `A + B + C` |
| **Trapeze** | `(B + D) · H / 2` | `A + B + C + D` |

---

## ▶️ Sample Usage

```csharp
using HeritageWorkshop.Backend;

var circle       = new Circle(name: nameof(Circle), r: 5);
var square       = new Square(name: nameof(Square), a: 10);
var rhombus      = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);
var kite         = new Kite(name: nameof(Kite), a: 7, b: 8, d1: 6, d2: 5);
var rectangle    = new Rectangle(name: nameof(Rectangle), a: 4.568, b: 67.790);
var parallelogram = new Parallelogram(name: nameof(Parallelogram), a: 14.65, b: 54.67, h: 23.09);
var triangle     = new Triangle(name: nameof(Triangle), a: 45.56, b: 12.34, c: 27.09, h: 15);
var trapeze      = new Trapeze(name: nameof(Trapeze), a: 10, b: 20, c: 30, d: 40, h: 20);

var figures = new List<GeometricFigure>
{
    circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
};

foreach (var figure in figures)
    Console.WriteLine(figure);
```

---

## 💻 Expected Output

```
Circle          => Area.....:        78.53982    Perimeter:        31.41593
Square          => Area.....:       100.00000    Perimeter:        40.00000
Rhombus         => Area.....:        35.00000    Perimeter:        20.00000
Kite            => Area.....:        15.00000    Perimeter:        30.00000
Rectangle       => Area.....:       309.66472    Perimeter:       144.71600
Parallelogram   => Area.....:     1,262.33030    Perimeter:       138.64000
Triangle        => Area.....:        92.55000    Perimeter:        84.99000
Trapeze         => Area.....:       600.00000    Perimeter:       100.00000
```

---

## ⚙️ Requirements

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ or any C#-compatible IDE

---

## 🚀 Getting Started

```bash
# Clone the repository
git clone https://github.com/your-username/HeritageWorkshop.git
cd HeritageWorkshop

# Run the project
dotnet run --project HeritageWorkshop.Frontend
```

---

## 🧠 Key OOP Concepts Applied

- **Abstraction** — `GeometricFigure` defines the contract via abstract methods `GetArea()` and `GetPerimeter()`
- **Inheritance** — each figure extends a parent class, reusing shared logic
- **Polymorphism** — all figures are stored as `List<GeometricFigure>` and resolved at runtime
- **Encapsulation** — private fields with validated properties on every class

---

## 👩‍💻 By Teffidev

Made with 💜 as part of the *Data Structures* coursework at **ITM — Instituto Tecnológico Metropolitano**.
