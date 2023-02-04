# Geometry

This repository contains the geometry library. To use this library, add a reference to the Geometry project.
The current version allows you to calculate: 
1. The area of a circle by radius
  ```csharp
    var circle = new Circle(radius);
    var circleArea = circle.GetArea();
  ```

2. The area of a triangle by three sides
  ```csharp
    var triangle = new Triangle(a, b, c);
    var triangleArea = triangle.GetArea();
  ```

3. Determine whether the triangle is right-angled 
  ```csharp
    var triangle = new Triangle(a, b, c);
    var isRightTriangle = triangle.IsRightTriangle();
  ```

Using the CalculationService class, you can get the area of any shape:
  ```csharp
    var firstShape = new Circle(2d);
    var secondShape = new Triangle(3d, 4d, 5d);

    var calculateService = new CalculateService();

    var firstShapeArea = calculateService.GetShapeArea(firstShape);
    var secondShapeArea = calculateService.GetShapeArea(secondShape);
  ```
