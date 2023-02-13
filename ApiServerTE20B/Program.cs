WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

Cheese dairy = new Cheese();
dairy.Kind = "Fourme d'Ambert";
dairy.Taste = "Soft and creamy, milky with earthy undertones.";
dairy.Smellyness = 4;




app.MapGet("/", Answer);

app.MapGet("/cheese/", () => {
return dairy;

});

app.Run();


static string Answer()
{
    return "cheesed to meet you";
}