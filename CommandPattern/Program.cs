// Setup
using CommandPattern;

Canvas canvas = new Canvas();
Invoker invoker = new Invoker();

// Define shapes
Shape circle = new Circle(1, 10, 10, 5);
Shape rectangle = new Rectangle(2, 20, 20, 5, 10);

ICommand addCircleCommand = new AddShapeCommand(canvas, circle);
invoker.ExecuteCommand(addCircleCommand); // Adds the circle to the canvas

ICommand addRectangleCommand = new AddShapeCommand(canvas, rectangle);
invoker.ExecuteCommand(addRectangleCommand); // Adds the rectangle to the canvas

ICommand moveCircleCommand = new MoveShapeCommand(canvas, circle, x: 30, y: 30);
invoker.ExecuteCommand(moveCircleCommand); // Moves the circle to (30, 30)

invoker.Undo(); // Moves the circle back to its original position

invoker.Redo(); // Moves the circle to (30, 30) again

ICommand removeRectangleCommand = new RemoveShapeCommand(canvas, rectangle);
invoker.ExecuteCommand(removeRectangleCommand); // Removes the rectangle from the canvas


invoker.Undo(); // Adds the rectangle back to the canvas

invoker.Redo(); // Removes the rectangle again