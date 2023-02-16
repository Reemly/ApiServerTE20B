WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");



List<Cheese> cheeses = new();

cheeses.Add(new() {Kind = "Fourme d'Ambert", Taste = "Soft and creamy, mily with earthy undertones.", Smellyness = 4 });
cheeses.Add(new() {Kind = "Langres", Taste = "Mild flavour, nutty with a certain saltyness, it has a long aftertaste.", Smellyness = 6 });
cheeses.Add(new() {Kind = "Comté", Taste = "Semi-Hard, Strong tasting,Sweet and a little nutty", Smellyness = 2});



// Cheese dairy = new Cheese();
// dairy.Kind = "Fourme d'Ambert";
// dairy.Taste = "Soft and creamy, milky with earthy undertones.";
// dairy.Smellyness = 4;




app.MapGet("/", Answer);

app.MapGet("/cheese/", () => {
return cheeses;

});

app.MapGet("/Cheese/{num}", (int num) =>
{

if (num >= 0 && num < cheeses.Count)
{
return Results.Ok(cheeses[num]);
}

return Results.NotFound();
});

app.MapPost("/Cheese/", () => 
{
System.Console.WriteLine("POST!");

});

app.Run();


static string Answer()
{
    return "cheesed to meet you";
}