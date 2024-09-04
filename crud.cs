var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/**
    Crear POST
    Obtener GET
    Actualizar PUT
    Borrar DELETE

    //api/v1/modulo -> /api/v1/producto
*/

List<ProductoDto> database = new List<ProductoDto>();

app.MapPost("/api/v1/producto", (ProductoDto productoDto) => {

    if(string.IsNullOrWhiteSpace(productoDto.nombre)){
        return Results.BadRequest("field name is required!");
    }

    if(database.Any(producto => producto.uuid == productoDto.uuid)){
        return Results.Conflict($"product with id {productoDto.uuid} exists");
    }

    database.Add(productoDto);
    return Results.Created($"product created", productoDto);
});

app.MapGet("/api/v1/producto", () => {
    return Results.Ok(database);
});

app.MapGet("/api/v1/producto/{uuid}", (Guid uuid) => {
    var product = database.FirstOrDefault( producto => producto.uuid == uuid);

    if(product is null) {
        return Results.NotFound($"product with id {uuid} not found");
    }
    return Results.Ok(product);
});

app.MapPut("/api/v1/producto/{uuid}", (Guid uuid, ProductoDto productoDto) => {

    var product = database.FirstOrDefault( producto => producto.uuid == uuid);

    if(product is null) {
        return Results.NotFound($"product with id {uuid} not found");
    }

    product.nombre = productoDto.nombre;
    product.precio = productoDto.precio;

    return Results.Ok(product);

});
app.MapDelete("/api/v1/producto/{uuid}", (Guid uuid) => {
     var product = database.FirstOrDefault( producto => producto.uuid == uuid);

    if(product is null) {
        return Results.NotFound($"product with id {uuid} not found");
    }

    database.Remove(product);

    return Results.NoContent();
});

app.Run();

public class ProductoDto
{
    public Guid uuid {set; get;}
    public string nombre {set; get;}
    public decimal precio {set; get;}
}
