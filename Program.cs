using Figgle;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    return FiggleFonts.Standard.Render("Hey!");
});

app.Run("http://localhost:4032");