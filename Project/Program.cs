using NGRadio;

// Showcase of Menu system

string[] options = [
    "Class",
    "Struct",
    "Record",
    "DTO"
];
Menu m = new Menu("Some header", options);

Console.WriteLine(m.Render());