// Create an original cake (the prototype)
using Protottype;

CustomCake prototypeCake = new("Vanilla", "Buttercream", "Sprinkles");

Console.WriteLine("Prototype Cake: " + prototypeCake);

// Clone the prototype and customize the copy
CustomCake customCake = (CustomCake)prototypeCake.Clone();
customCake.Decorations = "Chocolate Shavings"; // Customize decorations

Console.WriteLine("Customized Cake: " + customCake);

// Clone another cake with a different customization
CustomCake anotherCake = (CustomCake)prototypeCake.Clone();
anotherCake.Frosting = "Chocolate Ganache"; // Customize frosting

Console.WriteLine("Another Customized Cake: " + anotherCake);